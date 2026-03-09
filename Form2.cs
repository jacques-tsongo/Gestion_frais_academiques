using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestioin_frais_academiques
{
    public partial class inscription : Form
    {
        public inscription()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        connexionDB db = new connexionDB(); // instanciation de la classe de connexion à la base de données
        SqlConnection con; // déclaration de la variable de connexion

        private void create_account_Click(object sender, EventArgs e)
        {
            try
            {
                con = db.GetConnexion();

                con.Open();

                SqlCommand cmd = new SqlCommand(
                "INSERT INTO utilisateurs(nom,fonction,mot_de_passe) VALUES(@nom,@fonction,@password)", con);

                cmd.Parameters.AddWithValue("@nom", nom.Text);
                cmd.Parameters.AddWithValue("@fonction", fonction.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Compte créé avec succès !");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
