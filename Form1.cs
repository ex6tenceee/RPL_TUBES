using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TUBESRPL_inputBuku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.Assert(textBox1.Text.Length < 20, "Username harus kurang 20 karakter");
            Debug.Assert(textBox2.Text.Length < 10, "Pasword harus kurang dari 10 karakter");

            if (textBox1.Text == "")
            {
                MessageBox.Show("Masukan Username yang benar");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Masukan password yang benar");
            }
            else
            {
                if (textBox1.Text != "3terakhir" && textBox2.Text != "240202")
                {
                    MessageBox.Show("Masukan username dan password yang benar");
                }
                else
                {
                    this.Hide();
                    Form2 aa = new Form2();
                    aa.ShowDialog();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form3 bb = new Form3();
            bb.ShowDialog();

        }
    }
}
