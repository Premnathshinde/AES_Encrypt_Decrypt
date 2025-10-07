# AES Encrypt/Decrypt Tool

A simple Windows Forms application for encrypting and decrypting text using AES (Advanced Encryption Standard) with 256-bit key size and CBC mode.

---

## Features

- AES-256 encryption and decryption
- CBC mode with PKCS7 padding
- User input for Initialization Vector (IV) and Key
- Base64 encoded output for encrypted data
- Clear input and output fields with a button
- Basic validation for input fields

---

## Prerequisites

- .NET Framework (compatible version for Windows Forms apps)
- Visual Studio or any C# IDE to build and run the project

---

## How to Use

1. **Enter the Initialization Vector (IV):**  
   Must be 16 characters (128 bits) long.

2. **Enter the Key:**  
   Must be 32 characters (256 bits) long.

3. **Enter the input data:**  
   - For encryption: Enter the plaintext you want to encrypt.  
   - For decryption: Enter the Base64 encoded ciphertext you want to decrypt.

4. **Click the Encrypt button** to encrypt the input data.  
   The encrypted Base64 string will appear in the output box.

5. **Click the Decrypt button** to decrypt the input data.  
   The decrypted plaintext will appear in the output box.

6. **Click the Clear button** to reset all fields.

---

## Important Notes

- The IV must be exactly 16 characters in length (128 bits).  
- The Key must be exactly 32 characters in length (256 bits).  
- Incorrect key or IV length will result in runtime errors.  
- Use secure ways to store or transfer keys and IVs.

---

## Code Overview

- Encryption uses `AesCryptoServiceProvider` with CBC mode and PKCS7 padding.  
- Decryption uses `AesManaged` with the same parameters.  
- Input and output are UTF-8 encoded text.  
- Encrypted data is Base64 encoded for easy text representation.  
- Errors are logged via a custom `Loger` class (make sure you have this implemented).

---

## Example

```plaintext
IV: 1234567890123456
Key: 12345678901234567890123456789012
Input (plaintext): Hello World!
Encrypted Output: (Base64 String)

![AESTool](./docs/AESTool.jpg)
