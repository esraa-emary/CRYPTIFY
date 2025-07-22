using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Encryption_and_Decryption_Application_GUI
{
    internal class Baconoian
    {
        public bool checkTextForEncrypt(string text)
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
                if (char.IsLetter(c)) count++;
                else
                {
                    return false;
                }
            }
            return true;
        }

        public bool checkTextForDecrypt(string text)
        {
            // Check if empty
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            int count = 0;
            foreach (char c in text)
            {
                if (c  == 'A' || c == 'B' || c == 'a' || c == 'b') count++;
                else
                {
                    return false;
                }
            }
            return true;
        }

        public string cipher(string text) {
            List<string> elements = new List<string>();
            string old_result = "", result = "";

            // Make a deque that contain binary conversion to elements from A to Z
            for (char i = 'A'; i <= 'Z'; i++)
            {
                int digit = 0;
                string digit2 = "";
                digit = i - 65;
                digit2 = Convert.ToString(digit, 2).PadLeft(5, '0');
                elements.Add(digit2);
            }

            // Convert all characters into uppercase and add the opposite index to each character in elements deque from A to Z to old_result
            foreach (char character in text)
            {
                int digit = 0;
                char index;
                index = char.ToUpper(character);
                digit = index - 'A';
                old_result += elements[digit];
            }

            // Convert every '1' to b and every '0' to a then add it to result
            foreach (char character in old_result)
            {
                if (character == '1') result += 'b';
                else if (character == '0') result += 'a';
            }
            return result;
        }

        public string decipher(string text)
        {
            var sb = new StringBuilder();
            foreach (char c in text)
            {
                if (c == 'A' || c == 'a') sb.Append('0');
                else if (c == 'B' || c == 'b') sb.Append('1');
            }
            string text2 = sb.ToString();

            if (text2.Length % 5 != 0)
            {
                MessageBox.Show("Error: Invalid number of letters.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

            var numbers = new List<int>();
            var invalidPatterns = new HashSet<string> { "11111", "11110", "11101", "11100", "11010", "11011" };

            for (int i = 0; i <= text2.Length - 5; i += 5)
            {
                string fiveBits = text2.Substring(i, 5);
                if (invalidPatterns.Contains(fiveBits))
                    continue;

                int digit = Convert.ToInt32(fiveBits, 2);
                numbers.Add(digit);
            }

            var result = new StringBuilder();
            foreach (int num in numbers)
            {
                if (num >= 0 && num < 26)
                {
                    char letter = (char)('a' + num); // lowercase
                    result.Append(letter);
                }
            }
            return result.ToString();
        }
    }
}
