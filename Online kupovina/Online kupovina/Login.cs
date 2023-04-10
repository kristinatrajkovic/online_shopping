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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        MySqlConnection conn = new MySqlConnection("server = localhost; database = online_kupovina; username = root; password =; SSL Mode = None");

        private void potvrdiBtn_Click(object sender, EventArgs e)
        {
            string korisnicko_ime, lozinka, ime, prezime;
            int korisnik_ID;

            korisnicko_ime = korisnickoImeTb.Text;
            lozinka = LozinkaTb.Text;

            if (korisnicko_ime == "" || lozinka == "")
            {
                MessageBox.Show("Unesite korisničko ime i lozinku!", "Prijava nije uspela!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (korisnicko_ime != "" & lozinka != "")
            {
                conn.Open();
                string login = "SELECT * FROM korisnik WHERE korisnicko_ime= '" + korisnicko_ime + "' and lozinka= '" + lozinka + "'";
                MySqlCommand cmd = new MySqlCommand(login, conn);

                try
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                       reader.Read();
                        korisnik_ID = Convert.ToInt32(reader[0].ToString());
                        ime= reader[1].ToString();
                        prezime = reader[2].ToString();
                        Form main = new Main(korisnik_ID, ime, prezime);
                        main.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Pogrešno korisničko ime ili lozinka!\nMolimo pokušajte ponovo!", "Prijava nije uspela!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        korisnickoImeTb.Text = "";
                        LozinkaTb.Text = "";
                        cmd.Dispose();
                        reader.Close();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void prikaziSifruCb_CheckedChanged(object sender, EventArgs e)
        {
            if (prikaziSifruCb.Checked)
            {
                LozinkaTb.PasswordChar = '\0';
            }
            else
            {
                LozinkaTb.PasswordChar = '•';
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form register = new Register();
            register.Show();
            this.Hide();
        }

        private void otkaziBtn_Click(object sender, EventArgs e)
        {
            korisnickoImeTb.Text = "";
            LozinkaTb.Text = "";
        }

        private void korisnickoImeTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
