/*  Drum Interpreter - 02/06/19
 * Receive packet from computer, check first 2 and last bits, and send analog values if valid.
 * If not valid, send empty data values.
 */


int AnalogPins[9] = { A0, A1, A2, A3, A4, A5, A6, A7, A8 }; //Declare Pin Array
byte buffer[12];  //Declare Serial Buffer, will be filled reversed
void setup() {
  // put your setup code here, to run once:
	Serial.begin(115200);
  for (int i = 0; i < 11; i++)
  {
    buffer[i] = 0;
  }
}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available() == 12)
  {
    while(Serial.available() > 0){
      buffer[Serial.available() - 1] = (byte)Serial.read();
    }
	bool isValid = false;
    switch (buffer[11]){
      case 127: //Valid Start Byte
	    
      switch (buffer[10]){
        case 60:  //Valid Identifier Bit

        switch (buffer[0]){
          case 67: //Valid Stop Bit
		  {
			  isValid = true;
			GatherData();
			
		  }
            
          break;
        }
        break;
      }
      break;
    }
	if (!isValid) {
		for (int i = 9; i > 0; i--)
		{
			buffer[i] = 0; //Set empty data values before sending back - the computer will use them for player volumes, invoked by 8 threads created for delegate(void MediaPlayer.Play)
		}
		for (int i = 11; i > -1; i--)
		{
			Serial.write(buffer[i]);  //write empty buffer
		}
	}
  }
  //If data is not valid, no need to read data
  
  
}

void GatherData()
{
  for (int i = 9; i > 0; i--)
  {
    buffer[i] = (byte)analogRead(AnalogPins[i-1]); //Read analog voltage from last pin to first, and store in buffer, 
  }
  //Send it back to the computer with the same Identifier codes
  for (int i = 11; i > -1; i--)
  {
    Serial.write(buffer[i]);
  }
}
