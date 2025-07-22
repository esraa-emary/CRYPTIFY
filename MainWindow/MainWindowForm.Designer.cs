namespace Encryption_and_Decryption_Application_GUI
{
    partial class MainWindowForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
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
            button1.Font = new Font("Segoe UI", 20F);
            button1.ForeColor = Color.FromArgb(18, 18, 18);
            button1.Location = new Point(285, 350);
            button1.Name = "button1";
            button1.Size = new Size(300, 70);
            button1.TabIndex = 3;
            button1.Text = "Atbash";
            button1.UseVisualStyleBackColor = false;
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
            button2.Font = new Font("Segoe UI", 20F);
            button2.ForeColor = Color.FromArgb(18, 18, 18);
            button2.Location = new Point(450, 450);
            button2.Name = "button2";
            button2.Size = new Size(300, 70);
            button2.TabIndex = 4;
            button2.Text = "Simple Substitution";
            button2.UseVisualStyleBackColor = false;
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
            button3.Font = new Font("Segoe UI", 20F);
            button3.ForeColor = Color.FromArgb(18, 18, 18);
            button3.Location = new Point(615, 350);
            button3.Name = "button3";
            button3.Size = new Size(300, 70);
            button3.TabIndex = 5;
            button3.Text = "Baconoian";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(260, 170);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(680, 37);
            label1.TabIndex = 6;
            label1.Text = "Welcome To Our Encryption And Decryption Application";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 35F, FontStyle.Bold);
            label2.Location = new Point(470, 100);
            label2.Name = "label2";
            label2.Size = new Size(241, 62);
            label2.TabIndex = 7;
            label2.Text = "CRYPTIFY";
            // 
            // MainWindowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1200, 600);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = Color.FromArgb(49, 203, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindowForm";
            Text = "CRYPTIFY";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
    }
}
