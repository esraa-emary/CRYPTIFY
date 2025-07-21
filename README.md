# CRYPTIFY

This is a GUI application (built with C#) that allows users to encrypt and decrypt messages using a collection of classical cipher techniques.
The user-friendly interface makes it easy to choose a cipher, enter your message, and view the encrypted or decrypted output instantly.

---

## 📜 Supported Ciphers

1. **Affine Cipher**  
   A substitution cipher that uses mathematical functions for encryption. It applies the formula `E(x) = (a * x + b) mod m`, where `a` and `b` are keys, `x` is the letter index, and `m` is the alphabet size (usually 26).

2. **Route Cipher**  
   A transposition cipher where the plaintext is written in a grid and then read off using a specific route pattern (e.g., spiral or zigzag), changing the order of characters.

3. **Atbash Cipher**  
   A monoalphabetic substitution cipher where each letter is mapped to its reverse in the alphabet. For example, A becomes Z, B becomes Y, etc.

4. **Vigenère Cipher**  
   A polyalphabetic substitution cipher that uses a keyword to shift letters of the plaintext. Each letter of the keyword determines the Caesar shift for each letter of the message.

5. **Baconian Cipher**  
   A cipher that encodes each letter into a 5-letter string of A's and B's. It can be hidden in formatted text (like bold/italic) for steganographic purposes.

6. **Simple Substitution Cipher**  
   Each letter in the plaintext is replaced by a unique corresponding letter from a scrambled alphabet. The same key is used for both encryption and decryption.

7. **Polybius Square Cipher**  
   A cipher that uses a 5x5 grid to convert each letter into a pair of coordinates (row and column). Commonly used with digits (e.g., A = 11, B = 12, ..., Z = 55).

8. **Morse Cipher**  
   Converts text into sequences of dots (`.`) and dashes (`-`) representing letters and digits. It’s useful for telecommunication and has pauses between letters and words.

9. **XOR Cipher**  
   A cipher that uses the XOR bitwise operation between the plaintext and a repeating key to encrypt and decrypt messages. It’s simple but effective when used with a truly random key.

10. **Rail Fence Cipher**  
   A transposition cipher that writes the message in a zigzag pattern (like rails of a fence) across multiple rows, then reads row by row to get the ciphertext.

---

## 💡 Features

- Provides both **encryption** and **decryption** for each method.
- Great for **learning**, **testing**, or **demonstrating** classical cryptographic techniques.

---

## 🤝 Contributing
Contributions are welcome! Feel free to fork the repo, create a new branch, and submit a pull request.

## 📬 Contact
- Esraa Emary Abd El-Salam: [GitHub](https://github.com/esraa-emary) - [LinkedIn](https://www.linkedin.com/in/esraa-emary-b372b8303/)

## 📜 License
This project is licensed under the MIT License.
