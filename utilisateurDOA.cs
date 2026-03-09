using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestioin_frais_academiques
{
    internal class utilisateurDOA
    {
        connexionDB db = new connexionDB();

        public void AjouterUtilisateur(utilisateur u)
        {
            SqlConnection con = db.GetConnexion();

            string req = "INSERT INTO utilisateurs(nom,fonction,mot_de_passe) VALUES(@nom,@fonction,@mdp)";

            SqlCommand cmd = new SqlCommand(req, con);

            cmd.Parameters.AddWithValue("@nom", u.Nom);
            cmd.Parameters.AddWithValue("@fonction", u.Fonction);
            cmd.Parameters.AddWithValue("@mdp", u.MotDePasse);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
