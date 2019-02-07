using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.IO;
using System.Runtime.Hosting;


/*
 * Arduino now seems to be sending correct(mostly) data - need to "debounce" the buttons or add schmidt triggers
 * Forms App locks up after trying to play too much, too fast - need to determine why, could be related to media player list memory consumption, or data packets
 * going out of sync (byte 1 shows up in byte 4 position, etc)
 * Consider conversion to DirectSound API for faster async audio playback(may not be needed?) -Measure audio playback time to see if below 50ms(20Hz max drum speed)
*/





namespace DrumInterpreterFormsApp
{
    public partial class frmDrum : Form
    {
        string version = "1.0.0.2";
        Button[] btnsBrowse = new Button[8];
        Button[] btnsPlay = new Button[8];
        TextBox[] texts = new TextBox[8];
        double[] Volumes = new double[8];
        Uri[] uris;
        byte[] playdata = new byte[9];

        public frmDrum()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            uris = new Uri[8];
            Setup();
            GetSerial();
            serialPort1.DataReceived += (sndr, args) => GotData();
            timer1.Tick += (sndr, args) => GetDrums();
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
                            playdata[i + 1] = 255;
                        }
                        else
                        {
                            playdata[i + 1] = 0;
                        }
                        
                    }
                    PlayDrum(playdata);
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
                            timer1.Start();
                        
                            
                        }
                        catch
                        {
                            MessageBox.Show("Port could not be opened.", "Serial Error");
                            if (serialPort1.IsOpen) { serialPort1.Close(); }
                            if (timer1.Enabled) { timer1.Stop(); }
                        }
                    
                };
            }
        }
        public void GotData()
        {
            
            
            //read data from serial buffer, decode it into volume-sensitive commands for each drum, play them, and flush the buffer
            if (serialPort1.BytesToRead == 12)
            {
                byte[] data = new byte[12];
                serialPort1.Read(data, 0, 12);
                switch (data[0])
                {
                    case 127:
                        switch (data[1])
                        {
                            case 60:
                                switch (data[11])
                                {
                                    case 67:
                                        {
                                            byte[] comds = new byte[9]; //make this only call play if data[3-10] != 0
                                            for (int i = 2; i < 11; i++)
                                            {
                                                comds[i - 2] = data[i];
                                            }
                                            for (int i = 1; i < comds.Length; i++)
                                            {
                                                if (comds[i] != 0)
                                                {
                                                    PlayDrum(comds);
                                                }
                                            }
                                            
                                        }
                                        break;
                                    
                                }
                                break;
                            
                        }
                        break;
                    
                }


                
                serialPort1.DiscardInBuffer();
            }
            //else, just keep stacking into the inbuffer until there are 12 bytes present
        }
        public void GetDrums()
        {
            byte[] output = new byte[12];   //build array to send out, containing identifier bytes
            output[0] = 127;
            output[1] = 60;
            output[11] = 67;
            for (int i = 2; i < 11; i++)
            {
                output[i] = 0;
            }
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(output, 0, 12);   //if a response is sent, it will trigger DataReceived event.
            }
            else { GetSerial(); }
        }



        public void PlayDrum(byte[] datain) //Working properly
        {
            try
            {
                for (int i = 1; i < datain.Length; i++)
                {
                    if ((uint)datain[i] != 0 && (uint)datain[i] >= (uint)datain[0])   //Check to see if the volume data for each drum meets the user-defined threshold sent from arduino && not 0
                    {
                        double x = (double)datain[i];
                        int a = i - 1;
                        object[] p = { x, a };
                        object d = p;
                        
                        //Create a thread with a new media player, load the source file, play it, then dispose of the thread. This avoids relying on EventHandlers that may not work.
                        ParameterizedThreadStart tstart = new ParameterizedThreadStart((o) => {
                            MediaPlayer player = new MediaPlayer();
                            object[] input = (object[])o;
                            player.Volume = (double)input[0] / (double)255;
                            player.Open(uris[(int)input[1]]);
                            player.Volume = x / 255;
                            while (!player.NaturalDuration.HasTimeSpan)
                            {
                                Thread.Sleep(1);
                            }
                            player.Play();
                            if (player.NaturalDuration.HasTimeSpan) { Thread.Sleep((int)player.NaturalDuration.TimeSpan.TotalMilliseconds); }
                            player.Dispatcher.BeginInvokeShutdown(System.Windows.Threading.DispatcherPriority.Normal);
                            player.Close();
                            player = null;
                        });
                        Thread t = new Thread(tstart);
                        t.Start(d);
                        

                    }

                }
                
            }
            catch
            {
                MessageBox.Show("Play Problem");
            }

        }
                
    }
}
