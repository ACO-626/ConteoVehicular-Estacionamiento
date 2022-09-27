#include <MFRC522.h>   //Biblioteca para el manejo de módulo RFID

#define ssRXPin 10  //Se define PIN de recepción
#define rstTXPin 5  //Se define PIN de transmisión

MFRC522 moduleRFID(ssRXPin,rstTXPin);  //Construcción de objeto módulo RFID

void setup() {
  Serial.begin(9600);    //Se inicializa comunicación a 9600 baudios
  SPI.begin();           //Iniciar SPI
  moduleRFID.PCD_Init(); // Iniciar módulo

  Serial.println("Lectura en espera [RFID/NFC ]: "); //Se indica el estado de lectura
}

void loop() {
  if (moduleRFID.PICC_IsNewCardPresent()) { // Si hay cambio en la lectura 
    if (moduleRFID.PICC_ReadCardSerial()) { // Si la lectura cumple el formato

      /*Bloque de obtención de tipo de credencial
        MFRC522::PICC_Type piccType = moduleRFID.PICC_GetType(moduleRFID.uid.sak); //Se obtiene el tipo  y se guarda en la variable
        Serial.print("RFID/NFC Tag Type: ");                                       //Se imprime formato
        Serial.println(moduleRFID.PICC_GetTypeName(piccType));                     //Se imprime el tipo de credencial
      */

      // Impresión del número de credencial en formato hexadecimal
      
      Serial.print("ID:"); 
      for (int i = 0; i < moduleRFID.uid.size; i++) {
        Serial.print(moduleRFID.uid.uidByte[i] < 0x10 ? " 0" : " ");
        Serial.print(moduleRFID.uid.uidByte[i], HEX);
      }
      Serial.println(); //Se agrega un salto de renglón
      moduleRFID.PICC_HaltA(); // detener PICC
      moduleRFID.PCD_StopCrypto1(); // detener encryption en PCD
    }
  }
}
