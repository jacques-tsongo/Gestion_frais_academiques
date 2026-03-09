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
            if (fonction.Text == "caissier")
            {
                MessageBox.Show("c'est le caissier qui es connecte");
            }
            else if( fonction.Text == "comptable")
            {
                MessageBox.Show("c'est l'administrateur qui es connecter");
            }
        }

        private void fonction_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
