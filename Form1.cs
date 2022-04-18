using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
