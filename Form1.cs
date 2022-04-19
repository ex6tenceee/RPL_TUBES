using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace TUBESRPL_inputBuku
{
    public partial class Form1 : Form
    {
        private object book;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Lengkapi data terlebih dahulu.!", "Message");
            }
            else
            {
                MessageBox.Show("berhasil di tambahkan.!","message");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class InputBukuConfig
    {
        public Buku Config;
        public string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        public string fileConfigName = "Input_Buku_Config.json";

        public InputBukuConfig()
        {
            try
            {
               
                ReadConfigFile();
            }
            catch (Exception)
            {
                SetDefault();
                WriteNewConfigFile();
            }
        }

        private void ReadConfigFile()
        {
            throw new NotImplementedException();
        }

        public Buku ReadConfigFile(string jsonStringFromFile)
        {
            string jsonStringFromFile = File.ReadAllText(path + "/" + fileConfigName);
            Config = JsonSerializer.Deserialize<Buku>(jsonStringFromFile);
            return Config ;
        }

        private void SetDefault()
        {
            int id_buku = 14325;
            string judul_buku = "manusia setengah dewa";
            string penerbit = "pt.percetakaan jaya abadi";
            int tahun_terbit = 2018;
            string penulis = "mangku alam";

        }

        private void WriteNewConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(Config, options);
            string fullFilePath = path + "/" + fileConfigName;
            File.WriteAllText(fullFilePath, jsonString);
        }

       public class Buku
        {
        public int id_buku { get; set; }
        public string judul_buku { set; get; }
        public string penerbit { set; get; }
        public int tahun_terbit { set; get; }
        public string penulis { set; get; }
        public pesanAwal pesanAwal { set; get; }
        

        public Buku (int id_buku, string judul_buku, string penerbit, int tahun_terbit, string penulis,pesanAwal pesanAwal)
        {
            this.id_buku = id_buku;
            this.judul_buku = judul_buku;
            this.penerbit=penerbit;
            this.tahun_terbit = tahun_terbit;
            this.penulis = penulis;
            this.pesanAwal = pesanAwal;
        }
       }


     class pesanAwal
    {
        private string en { get; set; }
        private string id { get; set; }
    }



}
