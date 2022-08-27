#include <SPI.h>
#include <nRF24L01.h>
#include <RF24.h>

int msg[1];
RF24 radio(9,10);//check your pin number on RF24 github check you have the right
//pin number for the arduino you're using. this pin is diffrent for diffrent arduino models.

const uint64_t pipe = 0xF0F0F0F0D2L;
int led1 = 7;

void setup(void)
{
  pinMode(7, OUTPUT);
  Serial.begin(9600);
  radio.begin();
  radio.openReadingPipe(1, pipe);
  radio.startListening();
  pinMode(led1, OUTPUT);
}

void loop(void)
{
  if(radio.available()){
    bool done = false;
    while (!done) {
      radio.read(msg, 1);
      Serial.println(msg[0]);
      if (msg[0] == 111) {
      //delay(10);
      digitalWrite(led1, HIGH);
      }else {   
      digitalWrite(led1, LOW);
      }
    }
  }
}
