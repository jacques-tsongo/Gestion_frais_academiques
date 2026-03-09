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
        // création de l'objet connexion
        connexionDB db = new connexionDB();

        // Méthode qui vérifie si l'utilisateur existe déjà
        public bool UtilisateurExiste(string fonction)
        {
            // récupérer la connexion
            SqlConnection con = db.GetConnexion();

            // requête SQL pour vérifier l'existence
            string req = "SELECT COUNT(*) FROM utilisateurs WHERE fonction=@fonction";

            // création de la commande SQL
            SqlCommand cmd = new SqlCommand(req, con);

            // ajout du paramètre pour éviter l'injection SQL
            cmd.Parameters.AddWithValue("@fonction", fonction);

            // ouvrir la connexion
            con.Open();

            // exécuter la requête et récupérer le résultat
            int count = (int)cmd.ExecuteScalar();

            // fermer la connexion
            con.Close();

            // si count > 0 alors l'utilisateur existe
            return count > 0;
        }

        // Méthode pour ajouter un nouvel utilisateur
        public void AjouterUtilisateur(utilisateur u)
        {
            // récupérer la connexion
            SqlConnection con = db.GetConnexion();

            string req = "INSERT INTO utilisateurs(nom,fonction,mot_de_passe,role) VALUES(@nom,@fonction,@mdp,@role)";

            SqlCommand cmd = new SqlCommand(req, con);

            cmd.Parameters.AddWithValue("@nom", u.Nom);
            cmd.Parameters.AddWithValue("@fonction", u.Fonction);
            cmd.Parameters.AddWithValue("@mdp", u.MotDePasse);
            cmd.Parameters.AddWithValue("@role", u.Role);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        // méthode qui vérifie si les informations de connexion sont correctes
    public string AuthentifierUtilisateur(string nom, string fonction, string motdepasse)
        {
            SqlConnection con = db.GetConnexion();

            // requête pour récupérer le rôle
            string req = "SELECT role FROM utilisateurs WHERE nom=@nom AND fonction=@fonction AND mot_de_passe=@mdp";

            SqlCommand cmd = new SqlCommand(req, con);

            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@fonction", fonction);
            cmd.Parameters.AddWithValue("@mdp", motdepasse);

            con.Open();

            // récupérer le rôle
            object result = cmd.ExecuteScalar();

            con.Close();

            if (result != null)
            {
                return result.ToString();
            }

            return null;
        }
    }
}
