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
            // créer un objet utilisateur
            utilisateur u = new utilisateur();

            // récupérer les valeurs des champs du formulaire
            u.Nom = nom.Text;
            u.Fonction = fonction.Text;
            u.MotDePasse = password.Text;
            u.Role = cmbRole.Text;

            // créer l'objet DAO
            utilisateurDOA dao = new utilisateurDOA();

            // vérifier si l'utilisateur existe déjà
            if (dao.UtilisateurExiste(u.Fonction))
            {
                // message si le compte existe déjà
                MessageBox.Show("Ce compte existe déjà !");
                return;
            }

            // ajouter l'utilisateur dans la base
            dao.AjouterUtilisateur(u);

            // message de succès
            MessageBox.Show("Compte créé avec succès");

            // ouvrir la page principale
            addPaiement accueil = new addPaiement();

            accueil.Show();

            // cacher la page inscription
            this.Close();
        }

        private void inscription_Load(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
            // ajouter les roles dans le combobox
            cmbRole.Items.Add("admin");
            cmbRole.Items.Add("caissier");
        }
    }

}
