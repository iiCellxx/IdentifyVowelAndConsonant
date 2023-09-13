namespace IdentifyVowelAndConsonant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterB_Click(object sender, EventArgs e)
        {
            // Get the input from the TextBox
            string input;
            input = finderTB.Text.ToLower();

            if ("aeiou".Contains(input))
            {
                MessageBox.Show("This is a vowel");
            }
            else
            {
                MessageBox.Show("This is a consonant");
            }


        }
    }
}