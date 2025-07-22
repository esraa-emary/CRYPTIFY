using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_and_Decryption_Application_GUI
{
    public partial class BaconoianForm : Form
    {
        public BaconoianForm()
        {
            InitializeComponent();

            button1.MouseEnter += (s, e) =>
            {
                button1.ForeColor = ColorTranslator.FromHtml("#31cb00");
            };
            button1.MouseLeave += (s, e) =>
            {
                button1.ForeColor = Color.FromArgb(18, 18, 18);
            };


            button2.MouseEnter += (s, e) =>
            {
                button2.ForeColor = ColorTranslator.FromHtml("#31cb00");
            };
            button2.MouseLeave += (s, e) =>
            {
                button2.ForeColor = Color.FromArgb(18, 18, 18);
            };


            button3.MouseEnter += (s, e) =>
            {
                button3.ForeColor = ColorTranslator.FromHtml("#31cb00");
            };
            button3.MouseLeave += (s, e) =>
            {
                button3.ForeColor = Color.FromArgb(18, 18, 18);
            };
        }

        bool checkFirstForEncrypt = false, checkFirstForDecrypt = false, checkText = false;
        Baconoian baconoian = new Baconoian();

        private void button1_Click(object sender, EventArgs e)
        {
            if (baconoian.checkTextForEncrypt(textBox1.Text)) checkFirstForEncrypt = true;
            if (baconoian.checkTextForDecrypt(textBox1.Text)) checkFirstForDecrypt = true;
            checkText = true;
            MessageBox.Show("Text checked!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkText)
            {
                if (checkFirstForEncrypt)
                {
                    MessageBox.Show("Text is valid!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string result = baconoian.cipher(textBox1.Text);
                    label1.Text = "Encryption Text";
                    button4.Text = result;
                    checkFirstForEncrypt = false;
                    checkFirstForDecrypt = false;
                    checkText = false;
                }
                else
                {
                    // Found a non-letter → show error and stop
                    MessageBox.Show("Error: Text must contain only alphabetic characters.",
                                    "Validation Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error: You must check text at first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkText)
            {
                if (checkFirstForDecrypt)
                {
                    MessageBox.Show("Text is valid!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string result = baconoian.decipher(textBox1.Text);
                    label1.Text = "Decryption Text";
                    button4.Text = result;
                    checkFirstForEncrypt = false;
                    checkFirstForDecrypt = false;
                    checkText = false;
                }
                else
                {
                    MessageBox.Show("Error: Text must contain only 'a', 'A', 'b', 'B' characters.",
                                         "Validation Error",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error: You must check text at first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
