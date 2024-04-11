namespace Palindrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            string input = (string)textBox1.Text;

            if (input.Length == 0)
            {
                MessageBox.Show("Input too short!");
            }

            char[] stringarray = input.ToCharArray();
            Array.Reverse(stringarray);
            string reversestring = new string(stringarray);

            if (input == reversestring)
            {
                MessageBox.Show((input) + " is a palindrome!");
            }
            else
            {
                MessageBox.Show((input) + " is not a palindrome!");
            }
        }
        
    }
}
