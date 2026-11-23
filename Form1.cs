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

            try
            {
                using MySqlConnection conn = new MySqlConnection(connstr);
                {
                    conn.Open();
                }
                ;

                String query = "select * from tb_bahan_baku";
                using (MySqlCommand cmd = new MySqlCommand(query, conn)) 
                {
                    dataGridView1.Rows.Add("");       
                }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show("terjadi kesalahan" + ex.Message);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
