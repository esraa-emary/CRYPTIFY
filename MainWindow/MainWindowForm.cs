namespace Encryption_and_Decryption_Application_GUI
{
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();
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
