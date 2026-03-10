//

using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


namespace AkademikADOApp
{


    public partial class Form1 : Form
    {

        static string connectionString = "Server=localhost;Database=DBAkademikADO;Uid=root;Pwd=;";
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();

                label1.Text = "Status : Database Connected";
                MessageBox.Show("Koneksi ke Database Berhasil!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                //conn.Close();
                //label1.Text = "Status : Database Disconnected";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal : " + ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    label1.Text = "Status : Database Disconnected";
                    MessageBox.Show("Koneksi Database telah diputuskan.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Database memang sedang tidak terhubung.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Disconnect: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
