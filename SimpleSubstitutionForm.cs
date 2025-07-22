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
    public partial class SimpleSubstitutionForm : Form
    {
        public SimpleSubstitutionForm()
        {
            InitializeComponent();
        }

        bool checkKeyword = false, checkText = false;
        SimpleSubstitution simpleSubstitution = new SimpleSubstitution();

        private void button1_Click(object sender, EventArgs e)
        {
            if (simpleSubstitution.checkText(textBox1.Text)) checkText = true;
            if (checkText)
            {
                if (simpleSubstitution.checkKeyword(textBox2.Text)) checkKeyword = true;
                else checkText = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkText && checkKeyword)
            {
                string result = simpleSubstitution.cipher(textBox1.Text, textBox2.Text);
                label1.Text = "Encryption Text";
                button4.Text = result;
                checkKeyword = false;
                checkText = false;
            }
            else
            {
                MessageBox.Show("Error: You must check text at first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkText && checkKeyword)
            {
                string result = simpleSubstitution.decipher(textBox1.Text, textBox2.Text);
                label1.Text = "Decryption Text";
                button4.Text = result;
                checkKeyword = false;
                checkText = false;
            }
            else
            {
                MessageBox.Show("Error: You must check text at first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
