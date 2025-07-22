using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Encryption_and_Decryption_Application_GUI
{
    partial class AtbashForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtbashForm));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            toolStripContainer1 = new ToolStripContainer();
            button4 = new Button();
            toolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(907, 122);
            label1.Name = "label1";
            label1.Size = new Size(196, 37);
            label1.TabIndex = 1;
            label1.Text = "Encryption Text";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(49, 203, 0);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 255);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F);
            button1.ForeColor = Color.FromArgb(18, 18, 18);
            button1.Location = new Point(540, 234);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 3;
            button1.Text = "Check Text";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(49, 203, 0);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 255);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15F);
            button2.ForeColor = Color.FromArgb(18, 18, 18);
            button2.Location = new Point(470, 295);
            button2.Name = "button2";
            button2.Size = new Size(120, 40);
            button2.TabIndex = 4;
            button2.Text = "Encrypt";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(49, 203, 0);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 255);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 255);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 15F);
            button3.ForeColor = Color.FromArgb(18, 18, 18);
            button3.Location = new Point(610, 295);
            button3.Name = "button3";
            button3.Size = new Size(120, 40);
            button3.TabIndex = 5;
            button3.Text = "Decrypt";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = SystemColors.Window;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(50, 265);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Input Text";
            textBox1.Size = new Size(300, 70);
            textBox1.TabIndex = 6;
            // 
            // toolStripContainer1
            // 
            toolStripContainer1.Anchor = AnchorStyles.None;
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Size = new Size(300, 45);
            toolStripContainer1.Location = new Point(50, 265);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(300, 70);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.FromArgb(49, 203, 0);
            button4.Enabled = false;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 15F);
            button4.ForeColor = Color.FromArgb(18, 18, 18);
            button4.Location = new Point(850, 265);
            button4.Name = "button4";
            button4.Size = new Size(300, 70);
            button4.TabIndex = 8;
            button4.Text = "RmkfgGvcg";
            button4.UseVisualStyleBackColor = false;
            // 
            // AtbashForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1200, 600);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(toolStripContainer1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(49, 203, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AtbashForm";
            Text = "Atbash";
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private ToolStripContainer toolStripContainer1;
        private Button button4;
    }
}