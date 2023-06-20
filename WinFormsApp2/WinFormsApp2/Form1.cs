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
            // Проверяем, содержат ли первые два TextBox текст
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                textBox7.Text = "login";
            }
            else
            {
                textBox7.Text = textBox5.Text;
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
    }
}