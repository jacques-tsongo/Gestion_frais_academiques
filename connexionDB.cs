using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestioin_frais_academiques
{
    internal class connexionDB
    {
        private SqlConnection con;

        public SqlConnection GetConnexion()
        {
            string chaine = @"Data Source=.;Initial Catalog=gestion_frais;Integrated Security=True";

            con = new SqlConnection(chaine);

            return con;
        }

    }
}
