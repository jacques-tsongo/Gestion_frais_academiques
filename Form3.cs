using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestioin_frais_academiques
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            inscription inscr = new inscription(); // on instacie comme d'habitude
            inscr.Show(); // on affiche le formulaire d'inscription
            this.Close(); // et on ferme le form d connexion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // récupérer les valeurs des champs du formulaire
            string Nom = nom.Text;
            string Fonction = fonction.Text;
            string Password = password.Text;

            utilisateurDOA dao = new utilisateurDOA();

            // récupérer le rôle
            string role = dao.AuthentifierUtilisateur(Nom, Fonction, Password);

            if (role == "admin")
            {
                MessageBox.Show("Bienvenue Administrateur");
            }

            else if (role == "caissier")  // si la personne connectee est caissier alors on ouvre le formulaire a rapport avec le caissier
            {
                //MessageBox.Show("Bienvenue Caissier");
                addPaiement addpaie = new addPaiement();
                addpaie.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Informations incorrectes !");
            }
        }

        private void fonction_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }
    }
}
