using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Online_kupovina
{
    public partial class Kupi : Form
    {
        int proizvod_id, id;
        string naziv_proizvoda;
        public Kupi(int id,int proizvod_id, string naziv_proizvoda)
        {
            InitializeComponent();
            this.proizvod_id = proizvod_id;
            this.naziv_proizvoda = naziv_proizvoda;
            this.id = id;
            proizvodLbl.Text = naziv_proizvoda + "";
        }
        MySqlConnection conn = new MySqlConnection("server = localhost; database = online_kupovina; username = root; password =; SSL Mode = None");


        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kupi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kolicina = (int)numericUpDown1.Value;
            conn.Open();
            
            string query = "Select * from korpa where id_proizvoda=" + proizvod_id+" and id_korisnika="+id;
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                conn.Close();
                conn.Open();
                string query1 = "UPDATE korpa set kolicina=kolicina+"+kolicina+" where id_proizvoda="+proizvod_id + " and id_korisnika=" + id;
                MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                cmd1.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Dodata nova količina");
                this.Close();
            }
            else
            {
                conn.Close();
                conn.Open();
                string query1 = "INSERT INTO korpa (id_korisnika, id_proizvoda,kolicina) values('" + id + "' ,'" + proizvod_id + "' ,'" + kolicina + "')";
                MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                cmd1.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Dodat novi proizvod!");
                this.Close();
            }
           
                   
        }
    }
}
