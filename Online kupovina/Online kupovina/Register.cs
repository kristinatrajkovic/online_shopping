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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        MySqlConnection conn = new MySqlConnection("server = localhost; database = online_kupovina; username = root; password =; SSL Mode = None");

        private void potvrdiBtn_Click(object sender, EventArgs e)
        {
            if (imeTb.Text == "" || prezimeTb.Text == "" || korisnickoImeTb.Text == "" || LozinkaTb.Text == "" || potLozinkaTb.Text == "")
            {
                MessageBox.Show("Popunite sva prazna polja!", "Registracija nije uspela!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (LozinkaTb.Text != potLozinkaTb.Text)
            {
                MessageBox.Show("Potvrdna lozinka se ne poklapa sa unetom lozinkom!", "Registracija nije uspela!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LozinkaTb.Text = "";
                potLozinkaTb.Text = "";
            }
            else
            {
                conn.Open();
                string korisnicko_ime, lozinka, ime, prezime;
                korisnicko_ime = korisnickoImeTb.Text;
                lozinka = LozinkaTb.Text;
                ime = imeTb.Text;
                prezime = prezimeTb.Text;
                string login = "SELECT * FROM korisnik WHERE korisnicko_ime= '" + korisnicko_ime+"'";
                MySqlCommand cmd = new MySqlCommand(login, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) MessageBox.Show("Korisničko ime već postoji!");
                else
                {
                    conn.Close();
                    conn.Open();
                    string register = "INSERT INTO korisnik(korisnicko_ime, lozinka, ime, prezime) VALUES ('" + korisnicko_ime + "', '" + lozinka + "', '" + ime + "', '" + prezime + "')";
                    MySqlCommand cmd1 = new MySqlCommand(register, conn);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Uspešno ste se registrovali!", "Uspešna registracija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                korisnickoImeTb.Text="";
                LozinkaTb.Text="";
                imeTb.Text="";
                prezimeTb.Text="";
                potLozinkaTb.Text = "";
                conn.Close();
            }

        }

        private void prikaziSifruCb_CheckedChanged(object sender, EventArgs e)
        {
            if (prikaziSifruCb.Checked)
            {
                LozinkaTb.PasswordChar = '\0';
                potLozinkaTb.PasswordChar = '\0';
            }
            else
            {
                LozinkaTb.PasswordChar = '•';
                potLozinkaTb.PasswordChar = '•';
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            login.Show();
            this.Hide();
        }

        private void otkaziBtn_Click(object sender, EventArgs e)
        {
            imeTb.Text = "";
            prezimeTb.Text = "";
            korisnickoImeTb.Text = "";
            LozinkaTb.Text = "";
            potLozinkaTb.Text = "";
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
