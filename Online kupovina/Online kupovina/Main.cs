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
    public partial class Main : Form
    {
        int id, proizvod_id;
        string ime, prezime, naziv_proizvoda;
        public Main(int id, string ime, string prezime)
        {
            InitializeComponent();
            proizvodiTabela.DataSource = load();
            this.id = id ;
            this.ime=ime;
            this.prezime=prezime;
            ImeKorisnikaLbl.Text = ime + " " + prezime;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void odjaviSe_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
        MySqlConnection conn = new MySqlConnection("server = localhost; database = online_kupovina; username = root; password =; SSL Mode = None");

        private void Main_Load(object sender, EventArgs e)
        {

        }


        private void pretrazi_Click(object sender, EventArgs e)
        {
            proizvodiTabela.DataSource = load();
        }

        private void otkazi_Click(object sender, EventArgs e)
        {
            proizvodLbl.Text = "";
            minCenaLbl.Text = "";
            vrstaCmb.Text= "";
            proizvodiTabela.DataSource = load();

        }

        private void korpa_Click(object sender, EventArgs e)
        {
            Korpa korpa = new Korpa(id, ime, prezime);
            korpa.Show();
            this.Hide();
        }

//dupli klik za kupovinu proizvoda
        private void proizvodiTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            proizvod_id = Convert.ToInt32(proizvodiTabela.SelectedRows[0].Cells[0].Value.ToString());
            naziv_proizvoda = proizvodiTabela.SelectedRows[0].Cells[1].Value.ToString();
             
            if (proizvod_id != 0)
            {
                conn.Open();
                string query = "Select * from korpa where id_proizvoda=" + proizvod_id+" and id_korisnika="+id;
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DialogResult dialogResult = MessageBox.Show("Proizvod već postoji. Da li želite da dodate još?", "Dodavanje", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        conn.Close();
                        Kupi kupi = new Kupi(id, proizvod_id, naziv_proizvoda);
                        kupi.Show();

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close();
                    }
                }
                else
                {
                    conn.Close();
                    Kupi kupi = new Kupi(id, proizvod_id, naziv_proizvoda);
                    kupi.Show();
                }
            }
        }

        private BindingSource load()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmdd;
            DataSet ds = new DataSet();
            BindingSource bs = new BindingSource();
            string sql = "SELECT id_proizvoda as id, naziv_proizvoda as naziv, vrsta, tezina, cena from proizvodi where 1=1";

            //za pretragu (ukoliko je nepopunjeno svakako stampa sve)
            if (!(proizvodLbl.Text.Trim().Equals("")))
            {
                sql += " AND naziv_proizvoda LIKE '%" + proizvodLbl.Text.Trim() + "%'";
            }

            if (!(minCenaLbl.Text.Trim().Equals("")))
            {
                sql += " AND cena>='" + minCenaLbl.Text.Trim() + "'";
            }
            if (vrstaCmb.SelectedItem != null)
            {
                sql += " AND vrsta='" + vrstaCmb.SelectedItem.ToString() + "'";
            }

  

            cmdd = new MySqlCommand(sql, conn);

            adapter.SelectCommand = cmdd;
            adapter.Fill(ds);

            bs.DataSource = ds.Tables[0];
            return bs;

        }



    }
}
