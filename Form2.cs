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
                utilisateur u = new utilisateur();

                u.Nom = nom.Text;
                u.Fonction = fonction.Text;
                u.MotDePasse = password.Text;

                utilisateurDOA dao = new utilisateurDOA();
                dao.AjouterUtilisateur(u);

                MessageBox.Show("Compte créé avec succès");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
