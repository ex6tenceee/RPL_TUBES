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

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            int input = int.Parse(textBox1.Text);
            if (input != 1302200097)
            {
                this.label5.Text = "NIM Tidak terdaftar!";
                this.label6.Text = " ";
            }
            else
            {
                this.label5.Text = "NIM Terdaftar!";
                this.label6.Text = "Nama : Daffa Aqilah \nJurusan : RPL";
            }

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Feedback sudah Terkirim!");
        }
    }
}
