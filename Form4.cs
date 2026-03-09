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
    public partial class addPaiement : Form
    {
        public addPaiement()
        {
            InitializeComponent();
        }
        // fonction qui permet d'afficher un formulaire dans le panel
        public void LoadForm(object Form)
        {
            // vérifier si le panel contient déjà un formulaire
            if (this.main_contents.Controls.Count > 0)
                // supprimer le formulaire existant
                this.main_contents.Controls.RemoveAt(0);

            // convertir l'objet en formulaire
            Form f = Form as Form;

            // indiquer que le formulaire n'est pas une fenêtre indépendante
            f.TopLevel = false;

            // enlever les bordures du formulaire
            f.FormBorderStyle = FormBorderStyle.None;

            // faire occuper tout l'espace du panel
            f.Dock = DockStyle.Fill;

            // ajouter le formulaire dans le panel
            this.main_contents.Controls.Add(f);

            // mémoriser le formulaire
            this.main_contents.Tag = f;

            // afficher le formulaire
            f.Show();
        }
        private void addPaiement_Load(object sender, EventArgs e)
        {
            // afficher automatiquement le formulaire paiement
            LoadForm(new paiement());

        }

        private void ajouterUnPaiementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // charger le formulaire AjouterPaiement dans le panel
            LoadForm(new paiement());
    }

        private void voirLhistoriqueDesPaiementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // charger le formulaire HistoriquePaiement dans le panel
            LoadForm(new historique());
    }
    }
}
