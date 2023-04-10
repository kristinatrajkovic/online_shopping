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
    public partial class Korpa : Form
    {
        int id,suma, proizvod_id;
        string ime, prezime, naziv_proizvoda;
        public Korpa(int id, string ime, string prezime)
        {
            InitializeComponent();
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            korpaTabela.DataSource = load();
            izracunavanjeSume();
        }
        MySqlConnection conn = new MySqlConnection("server = localhost; database = online_kupovina; username = root; password =; SSL Mode = None");

        private void kupi_Click(object sender, EventArgs e)
        {

        }

        private void Korpa_Load(object sender, EventArgs e)
        {
        }


        private void izracunavanjeSume()
        {

            //izracunavanje sume 
            conn.Open();
            string sql1 = "SELECT sum(p.cena* k.kolicina) from korpa as k inner join proizvodi as p where k.id_korisnika = " + id + " and k.id_proizvoda = p.id_proizvoda";
            MySqlCommand cmdd1 = new MySqlCommand(sql1, conn);
            MySqlDataReader dr1 = cmdd1.ExecuteReader();
            dr1.Read();
            if (dr1[0].ToString() != "") suma = Convert.ToInt32(dr1[0].ToString());
            sumaLbl.Text = suma + " DIN";
            dr1.Close();
            conn.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void obrisi_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "DELETE from korpa where id_korisnika = " + id+"";
            MySqlCommand cmdd1 = new MySqlCommand(sql, conn);
            cmdd1.ExecuteNonQuery();
            MessageBox.Show("Izvršeno!");
            conn.Close();
            korpaTabela.DataSource = load();
            suma = 0;
            sumaLbl.Text = suma + " DIN";
        }

        private void korpaTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            proizvod_id = Convert.ToInt32(korpaTabela.SelectedRows[0].Cells[0].Value.ToString());
            naziv_proizvoda = korpaTabela.SelectedRows[0].Cells[1].Value.ToString();

            if (proizvod_id != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Da li želite da obrišete "+naziv_proizvoda+" iz korpe?","Brisanje", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    conn.Open();
                    string sql = "DELETE from korpa where id_korisnika = " + id + " and id_proizvoda="+proizvod_id;
                    MySqlCommand cmdd1 = new MySqlCommand(sql, conn);
                    cmdd1.ExecuteNonQuery();
                    conn.Close();
                    korpaTabela.DataSource = load();
                    izracunavanjeSume();
                    



                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private BindingSource load()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmdd;
            DataSet ds = new DataSet();
            BindingSource bs = new BindingSource();
            string sql = "SELECT k.id_proizvoda, p.naziv_proizvoda, k.kolicina,p.cena*k.kolicina as cena from korpa as k inner join proizvodi as p where k.id_korisnika="+id+" and k.id_proizvoda=p.id_proizvoda";
            cmdd = new MySqlCommand(sql, conn);
            adapter.SelectCommand = cmdd;
            
            adapter.Fill(ds);
           
            bs.DataSource = ds.Tables[0];
            
            return bs;

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
            Form main = new Main(id, ime, prezime);
            main.Show();
        }
    }
}
