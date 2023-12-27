using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PemesananTiketBus
{
    public partial class DetailPembayaran : Form
    {
        

        public DetailPembayaran()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            
           

        }
        

      

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void DetailPembayaran_Load(object sender, EventArgs e)
        {
            nama1.Text = "";
            tanggal1.Text = "";
            kelas1.Text = "";
            jumlah1.Text = "";
            total1.Text = "";
            asal1.Text = "";
            tujuan1.Text = "";
            jamberangkat.Text = "";
            jamsampai.Text = "";


            nama1.Text = Form1.Nama;
            tanggal1.Text = LoginSuccesForm.Tanggal;
            kelas1.Text = LoginSuccesForm.Kelas;
            jumlah1.Text = LoginSuccesForm.Jumlah;
            total1.Text = LoginSuccesForm.Total;
            asal1.Text = LoginSuccesForm.Asal;
            tujuan1.Text = LoginSuccesForm.Tujuan;
            jamberangkat.Text = KelasEkonomi.JamBerangkat;
            jamberangkat.Text = KelasExecutive.JamBerangkat;
            jamsampai.Text = KelasExecutive.JamTiba;
        }
    }
}
