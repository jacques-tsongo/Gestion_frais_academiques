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
    public partial class paiement : Form
    {
        public paiement()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void paiement_Load(object sender, EventArgs e)
        {
            // ajout des items dans le combobox devise
            devise.Items.Add("fc");
            devise.Items.Add("$");
        }
    }
}
