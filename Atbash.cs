using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Encryption_and_Decryption_Application_GUI
{
    internal class Atbash
    {
        public bool chechText(string text)
        {
            // Check if empty
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Error: Text cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int count = 0;
            foreach (char c in text)
            {
                if (char.IsLetter(c) || char.IsWhiteSpace(c)) count++;
                else
                {
                    // Found a non-letter → show error and stop
                    MessageBox.Show("Error: Text must contain only alphabetic characters and white spaces.",
                                    "Validation Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return false;
                }
            }
            MessageBox.Show("Text is valid!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public string cipher(string text)
        {
            string result = "";
            foreach (char character in text)
            {
                // Check if the letter is uppercase to encrypt
                if (char.IsUpper(character))
                {
                    result += (char)('A' + ('Z' - character));
                }

                // Check if the letter is lowercase to encrypt
                else if (char.IsLower(character))
                {
                    result += (char)('a' + ('z' - character));
                }
            }
            return result;
        }

        public string decipher(string text)
        {
            string result = "";
            foreach (char character in text)
            {
                // Check if the letter is uppercase to decrypt
                if (char.IsUpper(character))
                {
                    result += (char)('A' + ('Z' - character));
                }

                // Check if the letter is lowercase to decrypt
                else if (char.IsLower(character))
                {
                    result += (char)('a' + ('z' - character));
                }
            }
            return result;
        }
    }
}
