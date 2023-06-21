using System.Text.RegularExpressions;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox6.UseSystemPasswordChar = !textBox6.UseSystemPasswordChar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox5.Text;
            // Проверяем, содержат ли первые два TextBox текст
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                textBox7.Text = "login";
            }
            else if (IsValidEmail(email))
            {
                textBox7.Text = email;
                textBox7.Text = textBox5.Text;
            }
            else 
            {
                textBox7.Text = "Invalid email";
            }
           

            if (string.IsNullOrEmpty(textBox6.Text))
            {
                textBox8.Text = "password";
            }
            else
            {
                textBox8.Text = textBox6.Text;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            textBox6.UseSystemPasswordChar = true;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
    }
}