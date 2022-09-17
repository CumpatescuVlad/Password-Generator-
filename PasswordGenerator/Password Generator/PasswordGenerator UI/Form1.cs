using PasswordGenerator_2;

namespace PasswordGenerator_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Generate generate = new Generate();

            textBox1.Text = $"PASSWORD IS : {generate.GenerateAndStorePassword($@"C:\Users\{Environment.UserName}\Documents\Password.txt")}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText($@"C:\Users\{Environment.UserName}\Documents\Password.txt");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}