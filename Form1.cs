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

        private void button1_Click(object sender, EventArgs e)
        {
            string nama, alamat, username, password;
            long telp;

            nama = textBox1.Text;
            alamat = richTextBox1.Text;
            username = textBox3.Text;
            password = textBox4.Text;
            telp = long.Parse(textBox2.Text);
            MessageBox.Show("Nama : " + nama + "\nNo. Telp : " + telp + "\nAlamat : " + alamat + "\nUsername : " + username + "\nPassword : " + password);

        }
    }
}
