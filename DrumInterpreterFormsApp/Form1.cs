using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.IO;
using System.Runtime.Hosting;


/*
 * The idea is this: Using asynchronous media players, define one for each drum, with "browse..." buttons to select each sample. Once samples are loaded, 
 * check to see if a serial connection is available on the com port by sending a chunk of data to each available port, and wait for an identification response(use bytes).
 * Once the correct response is received, begin steady communication with the device on that port, using 1 byte for each drum trigger, allowing for velocity sensing.
 * This byte will be interpreted here as a command to play x sample at volume y%. Potentially allow for connection via bluetooth. The maximum amount of drum triggers will be
 * 8, because 8 bytes is one 64-bit packet.  Maybe it could use more? Do I have to limit it that way? Or could I have a specific byte value serve as a 'STOP' value that signifies
 * the end of a concurrent 'packet'? This way, more drums may be a bit slower in it's response time, but could still be acceptable...
 * sound.VolumePercentage = ((int)byte / 255) * 100;
 * 
 * I need:
 *  -A function that sets up the array of media players, and event handlers for each OpenFileDialog.Open() event, to change the current sample
 *  -A function that checks COM ports for an active receiver
 *  -A function that receives and interprets data packets as play commands, and plays each one, sending a "Ready" signal each time(use 00000000 for 'Ready' and 'STOP' signals)
 *  -A function that saves and loads sample selections for easy playing once initial setup is done
*/





namespace DrumInterpreterFormsApp
{
    public partial class frmDrum : Form
    {
        string version = "1.0.0.2";
        Button[] btnsBrowse = new Button[8];
        Button[] btnsPlay = new Button[8];
        TextBox[] texts = new TextBox[8];
        int[] Volumes = new int[8];
        List<MediaPlayer> players;
        Uri[] uris;

        public frmDrum()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            uris = new Uri[8];
            players = new List<MediaPlayer>();
            Setup();
            GetSerial();
            serialPort1.DataReceived += (snd, arg) => GotData();
        }
        public bool Browse(int BtnIndex, out Uri uri)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Uri myuri;
                if (Uri.TryCreate(openFileDialog1.FileName, UriKind.RelativeOrAbsolute, out myuri))
                {
                    char[] delim = { '\\' };
                    string[] parts = openFileDialog1.FileName.Split(delim);
                    texts[BtnIndex].Text = parts[parts.Length - 1];
                    uri = myuri;
                    return true;
                }
                else
                {
                    uri = null;
                    return false;
                }

            }
            else
            {
                uri = null;
                return false;
            }

        }
        public void Setup()
        {
            btnsBrowse[0] = btnBrowse1;
            btnsBrowse[1] = btnBrowse2;
            btnsBrowse[2] = btnBrowse3;
            btnsBrowse[3] = btnBrowse4;
            btnsBrowse[4] = btnBrowse5;
            btnsBrowse[5] = btnBrowse6;
            btnsBrowse[6] = btnBrowse7;
            btnsBrowse[7] = btnBrowse8;
            btnsPlay[0] = btnPlay1;
            btnsPlay[1] = btnPlay2;
            btnsPlay[2] = btnPlay3;
            btnsPlay[3] = btnPlay4;
            btnsPlay[4] = btnPlay5;
            btnsPlay[5] = btnPlay6;
            btnsPlay[6] = btnPlay7;
            btnsPlay[7] = btnPlay8;
            texts[0] = txtDrum1;
            texts[1] = txtDrum2;
            texts[2] = txtDrum3;
            texts[3] = txtDrum4;
            texts[4] = txtDrum5;
            texts[5] = txtDrum6;
            texts[6] = txtDrum7;
            texts[7] = txtDrum8;
            for (int i = 0; i < Volumes.Length; i++)
            {
                Volumes[i] = 100;
            }
            foreach (Button btn in btnsBrowse)
            {
                btn.Click += (sndr, args) =>
                {
                    for (int i = 0; i < btnsBrowse.Length; i++)
                    {
                        if (sndr.Equals(btnsBrowse[i]))
                        {
                            Uri thisuri;
                            if (Browse(i, out thisuri))
                            {
                                uris[i] = thisuri;
                                
                            }
                            else
                            {
                                MessageBox.Show("File could not be opened. Please select a valid file.", "Error Opening File");
                            }
                        }
                    }
                };
            } //Browse EventHandler Setup
            foreach (Button btn in btnsPlay)
            {
                btn.Click += (sndr, args) =>
                {
                    for (int i = 0; i < btnsPlay.Length; i++)
                    {
                        if (sndr.Equals(btnsPlay[i]))
                        {
                            players.Add(new MediaPlayer());
                            players[players.Count - 1].Open(uris[i]);
                            players[players.Count - 1].MediaEnded += (sendr, arg) =>
                            {
                                int indx = players.FindIndex((plyr) => sendr == plyr);
                                players.RemoveAt(indx);
                            };
                            if (args != EventArgs.Empty)
                            {
                                
                            }
                            players[players.Count - 1].Volume = (double)Volumes[i];
                            players[players.Count - 1].Play();
                        }
                    }
                };
            } //Play EventHandler Setup
        }
        public void SaveKit()
        {
            if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK) && saveFileDialog1.CheckPathExists && saveFileDialog1.FileName != "")
            {
                FileStream fstream = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                BinaryWriter bwriter = new BinaryWriter(fstream);
                foreach (Uri ur in uris)
                {
                    bwriter.Write('~');
                    bwriter.Write(ur.ToString().ToCharArray());
                    
                }
                bwriter.Close();
                MessageBox.Show("Kit Save Operation Successful!", "Save Successful");
            }
            else
            {
                MessageBox.Show("Kit Save Operation Not Successful", "Error Saving");
            }
            
            
        }
        public void LoadKit()
        {
            openSaveFile.CheckFileExists = true;
            
            if (openSaveFile.ShowDialog().Equals(DialogResult.OK))
            {
                Stream mystream = openSaveFile.OpenFile();
                BinaryReader breader = new BinaryReader(mystream);
                char[] readdata = breader.ReadChars((int)mystream.Length);
                string readin = "";
                char[] delim = { '~' };
                for (int i = 0; i < readdata.Length; i++)
                {
                    readin += readdata[i];
                }
                string[] readuris = readin.Split(delim, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < readuris.Length; i++)
                {
                    Uri uri = new Uri(readuris[i]);
                    uris[i] = uri;
                    char[] del = { '/' };
                    string[] segments = uri.AbsolutePath.Split(del);
                    texts[i].Text = segments.Last().ToUpper();
                }
                breader.Close();
                MessageBox.Show("Kit Load Operation Successful!", "Load Successful");
            }
            else
            {
                MessageBox.Show("Kit Load Operation Not Successful", "Load Error");
            }
        }
        public void LoadKit(string fName)
        {
            openSaveFile.FileName = fName;
            Stream mystream = openSaveFile.OpenFile();
            BinaryReader breader = new BinaryReader(mystream);
            char[] readdata = breader.ReadChars((int)mystream.Length);
            string readin = "";
            char[] delim = { '~' };
            for (int i = 0; i < readdata.Length; i++)
            {
                readin += readdata[i];
            }
            string[] readuris = readin.Split(delim, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < readuris.Length; i++)
            {
                Uri uri = new Uri(readuris[i]);
                uris[i] = uri;
                char[] del = { '/' };
                string[] segments = uri.AbsolutePath.Split(del);
                texts[i].Text = segments.Last().ToUpper();
            }
            breader.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveKit();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadKit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Drum Machine \n Tim Earley \nVersion " + version, "About OpenDrumMachine", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void userGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!", "Not Yet Implemented");
        }

        private void cOMPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        public void GetSerial()
        {
            serialPort1.DataBits = 8;
            string[] openPorts = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string port in openPorts)
            {
                ToolStripMenuItem mnu = new ToolStripMenuItem();
                mnu.Text = port;
                cOMPortToolStripMenuItem.ComboBox.Items.Add(mnu);
                cOMPortToolStripMenuItem.ComboBox.SelectedIndexChanged += (sandur, ergs) =>
                {
                    ToolStripMenuItem menu = cOMPortToolStripMenuItem.ComboBox.SelectedItem as ToolStripMenuItem;
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Close();
                    }
                    serialPort1.PortName = menu.Text;
                    try
                    {
                        serialPort1.BaudRate = 115200;
                        serialPort1.Open();
                        MessageBox.Show("Port Opened Successfully", "Port Open");
                    }
                    catch
                    {
                        MessageBox.Show("Port could not be opened.", "Serial Error");
                    }
                };
            }
        }
        public void GotData()
        {
            //read data from serial buffer, decode it into volume-sensitive commands for each drum, play them, and flush the buffer
            if (serialPort1.BytesToRead == 8)
            {
                byte[] data = new byte[8];
                serialPort1.Read(data, 0, 8);
                int[] commands = new int[8];
                for (int i = 0; i < data.Length; i++)
                {
                    Volumes[i] = (data[i] * 100)/ 255;
                    foreach (Button btn in btnsPlay)
                    {
                        btn.PerformClick();
                    }
                }
                serialPort1.DiscardInBuffer();
            }
            //else, just keep stacking into the inbuffer until there are 8 bytes present
        }
    }
}
