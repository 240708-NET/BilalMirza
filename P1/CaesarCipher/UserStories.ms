# P1: (Caesar Cipher) User Stories

## Input Validation
- The app checks for non-alphabetic characters in the plain text and encrypted messages.
- The app provides appropriate error messages for invalid inputs.

## Encryption
- The user can input a plain text message.
- The user can select a shift value (key).
- The app outputs the encrypted message.

## Decryption
- The user can input an encrypted message.
- The user can select the shift value (key) used for encryption.
- The app outputs the decrypted message.

## Exit Program
- The user can restart program.
- The user can exit program.

## Data Persistence
- The app stores encrypted and decrypted messages along with their shift values (keys) in a SQL Server database using Entity Framework.
- The app retrieves and displays previously stored messages and their keys from the database.

## Interface Class
- The app includes an interface ICipher with methods for encryption and decryption.
- The app includes a class CaesarCipher that implements the ICipher interface and provides the Caesar cipher-specific logic.