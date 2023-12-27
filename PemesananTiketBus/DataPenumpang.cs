using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Text;

namespace PemesananTiketBus
{
    
    public partial class Form1 : Form
    {
        public static string Nama = "";

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboGender.Items.Add("Female");
            cboGender.Items.Add("Male");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nama = txtName.Text;
            try
            {
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(PhoneNumber.Text) || string.IsNullOrEmpty(cboGender.Text))
                {
                    MessageBox.Show("Please fill out all information!", "Error");
                    return;
                }

                connection.Open();

                // Perhatikan bahwa terdapat kesalahan pada if condition yang telah diperbaiki.
                string iquery = "INSERT INTO loginform.penumpang(`ID_Penumpang`,`Nama_Penumpang`,`Phone_Number`,`Gender_Penumpang`,`Tgl_Lahir_Penumpang`) " +
                                "VALUES (NULL, @Nama_Penumpang, @Phone_Number, @Gender_Penumpang, @Tgl_Lahir_Penumpang)";

                MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);

                // Menggunakan parameter untuk mencegah SQL Injection
                commandDatabase.Parameters.AddWithValue("@Nama_Penumpang", txtName.Text);
                commandDatabase.Parameters.AddWithValue("@Phone_Number", PhoneNumber.Text);
                commandDatabase.Parameters.AddWithValue("@Gender_Penumpang", cboGender.Text);
                commandDatabase.Parameters.AddWithValue("@Tgl_Lahir_Penumpang", dateTimePicker1.Value.Date);

                commandDatabase.ExecuteNonQuery();
                MessageBox.Show("Successfully Booking!");
            }
            catch (Exception ex)
            {
                // Menampilkan pesan kesalahan.
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            this.Hide();
            
            DetailPembayaran form = new DetailPembayaran();
            form.ShowDialog();
            
        }
        
        

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
