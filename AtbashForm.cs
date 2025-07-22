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
    public partial class AtbashForm : Form
    {
        public AtbashForm()
        {
            InitializeComponent();
        }

        bool checkFirst = false;
        Atbash atbash = new Atbash();

        private void button1_Click(object sender, EventArgs e)
        {
            if (atbash.checkText(textBox1.Text)) checkFirst = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkFirst)
            {
                string result = atbash.cipher(textBox1.Text);
                label1.Text = "Encryption Text";
                button4.Text = result;
                checkFirst = false;
            }
            else
            {
                MessageBox.Show("Error: You must check text at first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkFirst)
            {
                string result = atbash.decipher(textBox1.Text);
                label1.Text = "Decryption Text";
                button4.Text = result;
                checkFirst = false;
            }
            else
            {
                MessageBox.Show("Error: You must check text at first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
