using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PemesananTiketBus
{
    public partial class LoginSuccesForm : Form
    {
        public static string Tanggal = "";
        public static string Kelas = "";
        public static string Jumlah = "";
        public static string Total = "";
        public static string Asal = "";
        public static string Tujuan = "";


        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

        public LoginSuccesForm()
        {
            InitializeComponent();
        }

        private void LoginSuccesForm_Load_1(object sender, EventArgs e)
        {
            cboAsalkota.Items.Add("Jogja");
            cboAsalkota.Items.Add("Surabaya");
            cboAsalkota.Items.Add("Malang");
            cboTujuan.Items.Add("Jogja");
            cboTujuan.Items.Add("Surabaya");
            cboTujuan.Items.Add("Malang");
            cbkelas.Items.Add("Eksekutif");
            cbkelas.Items.Add("Ekonomi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboAsalkota.Text) || string.IsNullOrEmpty(cboTujuan.Text) || string.IsNullOrEmpty(penumpang.Text) || string.IsNullOrEmpty(cbkelas.Text))
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            try
            {
                connection.Open();

                // Menghitung total harga berdasarkan jumlah penumpang dan tarif per tiket
                int jumlahPenumpang = int.Parse(penumpang.Text);
                int hargaPerTiket = 0;
                int totalHarga = 0;

                if (cbkelas.Text == "Eksekutif")
                {
                    if (cboAsalkota.Text == "Malang")
                    {
                        if (cboTujuan.Text == "Surabaya")
                        {
                            hargaPerTiket = 50000;
                        } 
                        else if (cboTujuan.Text == "Jogja")
                        {
                            hargaPerTiket = 100000;
                        }
                    }
                    else if (cboAsalkota.Text == "Jogja")
                    {
                        if (cboTujuan.Text == "Surabaya")
                        {
                            hargaPerTiket = 150000;
                        }
                        else if (cboTujuan.Text == "Malang")
                        {
                            hargaPerTiket = 100000;
                        }
                    }
                    else if (cboAsalkota.Text == "Surabaya") 
                    {
                        if (cboTujuan.Text == "Malang")
                        {
                            hargaPerTiket = 50000;
                        }
                        else if (cboTujuan.Text == "Jogja")
                        {
                            hargaPerTiket = 150000;
                        }
                    }
                    
                }
                else if (cbkelas.Text == "Ekonomi")
                {
                    if (cboAsalkota.Text == "Malang")
                    {
                        if (cboTujuan.Text == "Surabaya")
                        {
                            hargaPerTiket = 40000;
                        }
                        else if (cboTujuan.Text == "Jogja")
                        {
                            hargaPerTiket = 80000;
                        }
                    }
                    else if (cboAsalkota.Text == "Jogja")
                    {
                        if (cboTujuan.Text == "Surabaya")
                        {
                            hargaPerTiket = 120000;
                        }
                        else if (cboTujuan.Text == "Malang")
                        {
                            hargaPerTiket = 80000;
                        }
                    }
                    else if (cboAsalkota.Text == "Surabaya")
                    {
                        if (cboTujuan.Text == "Malang")
                        {
                            hargaPerTiket = 40000;
                        }
                        else if (cboTujuan.Text == "Jogja")
                        {
                            hargaPerTiket = 120000;
                        }
                    }
                }
                
                totalHarga = jumlahPenumpang * hargaPerTiket;

               

                string iquery = "INSERT INTO loginform.journey (Kota_Asal, Kota_Tujuan, Tanggal_Keberangkatan, Jumlah_Kursi, Bus_Class, Total_Harga) " +
                                "VALUES ('" + cboAsalkota.Text + "','" + cboTujuan.Text + "','" + tgl.Value.ToString("yyyy-MM-dd") + "','" + penumpang.Text + "','" + cbkelas.Text + "','"+ totalHarga +"')";
                Asal = cboAsalkota.Text;
                Tujuan = cboTujuan.Text;
                Tanggal = tgl.Text;
                Kelas = cbkelas.Text;
                Jumlah = penumpang.Text;
                Total = totalHarga.ToString();

                MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                commandDatabase.ExecuteNonQuery();

                MessageBox.Show("Journey information successfully added to the database!");

                if (cbkelas.Text == "Ekonomi")
                {
                    this.Hide();
                    KelasEkonomi frm5 = new KelasEkonomi();
                    frm5.ShowDialog();
                }
                else
                {
                    this.Hide();
                    KelasExecutive frm5 = new KelasExecutive();
                    frm5.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            
        }

        private void cboAsalkota_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
