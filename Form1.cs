using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace praktikumsenincrud
{
    public partial class Form1 : Form
    {
        string connstr = "server=localhost;userid=root;pwd=;database=db_kopi_gudang";

        public Form1()
        {
            InitializeComponent();
        }

        private void ambildata()
        {
            string KodeBahan = textKode.Text;
            string NamaBahan = textNamaBahan.Text;


            using MySqlConnection conn = new MySqlConnection(connstr);
            {
                conn.Open();

                String query = "select * from tb_bahan_baku";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                 MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    dataGridView1.Rows.Add(reader["kode_bahan"].ToString(), reader["nama_bahan"].ToString(), reader["kategori"].ToString(), reader["stok"].ToString(), reader["satuan"].ToString(), reader["harga_satuan"].ToString(), reader["batas_minimum"].ToString());

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ambildata();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string KodeBahan = textKode.Text;
            string NamaBahan = textNamaBahan.Text;
            string Kategori = cmbKategori.Text;
            string Stok = numericStok.Text;
            string satuan = textSatuan.Text;
            string hargasatuan = numericHarsatuan.Text;
            string batasminimum = numericBatasMin.Text;

            using (MySqlConnection conn = new MySqlConnection())
            {
                conn.Open();
                
                string query = "insert into tb_bahan_baku (kode_bahan,nama_bahan,kategori,stok,satuan,harga_satuan,batasminimum) values (@kode_bahan,@nama_bahan,@kategori,@stok,@satuan,@harga_satuan,@batas_minimum)";
                
                using(MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@kode_bahan", KodeBahan);
                    command.Parameters.AddWithValue("@nama_bahan", NamaBahan);       
                }
            }
        }
    }
}