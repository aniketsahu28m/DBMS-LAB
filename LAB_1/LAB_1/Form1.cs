using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = textBox1.Text;
            String pass = textBox2.Text;
            if (id == "123" && pass == "123456")
            {
                if (radioButton1.Checked)
                {
                    MessageBox.Show("VALID USER MALE WELCOME");
                }
                else if (radioButton2.Checked)
                {
                    MessageBox.Show("VALID USER FEMALE WELCOME");
                }
            }
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "HELLO WORLD";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
