using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = textBox1.Text;
            String pass = textBox2.Text;
            if (id == "aniksahu28m" && pass == "123456")
            {
                MessageBox.Show("VALID USER WELCOME");
                Form2 f2 = new Form2(textBox1.Text);
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("INVALID USER, NOT WELCOME");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(textBox1.Text);
            f3.Show();
            this.Hide();
        }
    }
}
