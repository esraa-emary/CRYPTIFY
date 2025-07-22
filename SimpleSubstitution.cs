using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;
using static System.Net.Mime.MediaTypeNames;

namespace Encryption_and_Decryption_Application_GUI
{
    internal class SimpleSubstitution
    {
        public bool checkText(string text)
        {
            // Check if empty
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Error: Text can not be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int count = 0;
            foreach (char c in text)
            {
                if (char.IsLetter(c)) count++;
                else
                {
                    MessageBox.Show("Error: Text must contain only letters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            MessageBox.Show("Text is valid!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        // Check if the input has any character except alphabet, and it is 5 digits.
        public bool checkKeyword(string text)
        {
            // Check if empty
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Error: Keyword cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int count = 0;
            if (text.Length != 5)
            {
                MessageBox.Show("Error: keyword must be 5 alphabet distinct letters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            for (int i = 0; i < (int)text.Length; i++)
            {
                for (int j = 0; j < (int)text.Length; j++)
                {
                    if (char.IsLetter(text[i]) && (text[i] != text[j]))
                        count++;
                }
            }

            if (count != 20)
            {
                MessageBox.Show("Error: Keyword letters are not distinct.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            MessageBox.Show("Keyword is valid!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public string cipher(string text,string keyword) 
        {
            string result = "", text2 = "", keyword2 = "";
            List <char> alphabet = new List<char>();
            List<char> key = new List<char>();
            List<char> new_alphabet = new List<char>();

            // Convert the message and keyword into uppercase
            foreach (char character in text)
            {
                text2 += char.ToLower(character);
            }

            foreach (char character in keyword)
            {
                keyword2 += char.ToLower(character);
            }

            // Make a list for alphabetic letters and add keyword and rest of alphabetic letters to it
            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet.Add(i);
            }

            foreach (char character in keyword2)
            {
                key.Add(character);
                new_alphabet.Add(character);
            }

            foreach (char character in alphabet)
            {
                if (!key.Contains(character))
                {
                    new_alphabet.Add(character);
                }
            }

            foreach (char character in text2)
            {
                if (char.IsLetter(character))
                    result += new_alphabet[character - 'a'];
            }
            return result;
        }
        
        public string decipher(string text, string keyword) 
        {
            string result = "";
            string text2 = "";
            string keyword2 = "";
            List<char> alphabet = new List<char>();
            List<char> key = new List<char>();
            List<char> new_alphabet = new List<char>();

            // Convert the message and keyword into uppercase
            foreach (char character in text)
            {
                text2 += char.ToLower(character);
            }

            foreach (char character in keyword)
            {
                keyword2 += char.ToLower(character);
            }

            // Build the alphabet A–Z
            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet.Add(i);
            }

            // Build the key and new_alphabet (keyword first, then remaining letters)
            foreach (char character in keyword2)
            {
                if (!key.Contains(character))
                {
                    key.Add(character);
                    new_alphabet.Add(character);
                }
            }

            foreach (char character in alphabet)
            {
                if (!key.Contains(character))
                {
                    new_alphabet.Add(character);
                }
            }

            // Now map each character from text2
            foreach (char c in text2)
            {
                // Find c in new_alphabet
                int index = new_alphabet.IndexOf(c);
                if (index >= 0)
                {
                    // Get the corresponding letter from the normal alphabet
                    result += alphabet[index];
                }
                else
                {
                    // If c is not in A-Z (e.g., space or punctuation), keep it as is
                    result += c;
                }
            }

            return result;
        }
    }
}
