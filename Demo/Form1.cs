using SimplePBKDF2;
using System;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hashstring_button_Click(object sender, EventArgs e)
        {
            output_textBox.Text = Pbkdf2.Hash(string_textBox.Text, salt_textBox.Text);
        }

        private void generatepassword_button_Click(object sender, EventArgs e)
        {
            string_textBox.Text = Pbkdf2.GeneratePassword();
        }

        private void generatesalt_button_Click(object sender, EventArgs e)
        {
            salt_textBox.Text = Pbkdf2.GenerateSalt();
        }
    }
}