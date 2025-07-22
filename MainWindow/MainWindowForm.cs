namespace Encryption_and_Decryption_Application_GUI
{
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
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

        private void Form1_Load(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            AtbashForm atbash = new AtbashForm();
            atbash.Show(); 
            //this.Hide();s
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SimpleSubstitutionForm simpleSubstitution = new SimpleSubstitutionForm();
            simpleSubstitution.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BaconoianForm baconoian = new BaconoianForm();
            baconoian.Show();
            //this.Hide();
        }
    }
}
