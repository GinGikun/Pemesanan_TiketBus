using MySql.Data.MySqlClient;
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
    public partial class KelasEkonomi : Form
    {
        public static string JamBerangkat;
        public static string JamTiba;
        
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

        public KelasEkonomi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Lakukan operasi INSERT ke database loginform.bus
                string iquery = "INSERT INTO loginform.bus (Bus_Class, Jam) VALUES ('Ekonomi', '9:00')";
                MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                commandDatabase.ExecuteNonQuery();

                MessageBox.Show("Data berhasil ditambahkan ke database!");

                // Tambahkan logika lain yang diinginkan setelah operasi insert

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
            this.Hide();
            button1.Text = "09:00" ;
            JamTiba = "14:30";
            JamBerangkat = button1.Text;
            Form1 frm6 = new Form1();
            frm6.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Lakukan operasi INSERT ke database loginform.bus
                string iquery = "INSERT INTO loginform.bus (Bus_Class, Jam) VALUES ('Ekonomi', '15:00')";
                MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                commandDatabase.ExecuteNonQuery();

                MessageBox.Show("Data berhasil ditambahkan ke database!");

                // Tambahkan logika lain yang diinginkan setelah operasi insert

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
            this.Hide();
            button2.Text = "15:00";
            JamTiba = "20:30";
            JamBerangkat = button2.Text;
            Form1 frm6 = new Form1();
            frm6.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Lakukan operasi INSERT ke database loginform.bus
                string iquery = "INSERT INTO loginform.bus (Bus_Class, Jam) VALUES ('Ekonomi', '20:00')";
                MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                commandDatabase.ExecuteNonQuery();

                MessageBox.Show("Data berhasil ditambahkan ke database!");

                // Tambahkan logika lain yang diinginkan setelah operasi insert

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
            this.Hide();
            button3.Text = "20:00";
            JamTiba = "01:30";
            JamBerangkat = button3.Text;
            Form1 frm6 = new Form1();
            frm6.ShowDialog();
        }

        private void KelasEkonomi_Load(object sender, EventArgs e)
        {

        }
    }
}
