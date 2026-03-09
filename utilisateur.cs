using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestioin_frais_academiques
{
    internal class utilisateur
    {
        // Propriété pour l'identifiant de l'utilisateur
        public int IdUser { get; set; }

        // Propriété pour le nom
        public string Nom { get; set; }

        // Propriété pour la fonction (admin, caissier...)
        public string Fonction { get; set; }

        // Propriété pour le mot de passe
        public string MotDePasse { get; set; }

        // rôle de l'utilisateur (admin ou caissier)
        public string Role { get; set; }
    }
}
