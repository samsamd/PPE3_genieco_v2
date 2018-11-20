using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace PPE3_genieco_v2
{
   public static class Modele
    {
        private static genico_bdd_gsbEntities maConnexion;

        private static Visiteur visiteurConnecte;
        

        public static Visiteur VisiteurConnecte { get => visiteurConnecte; set => visiteurConnecte = value; }
        

        public static void init()
        {
            maConnexion = new genico_bdd_gsbEntities();

        }

        public static void connexionTest()
        {
            visiteurConnecte = maConnexion.Visiteur.Where(x => x.idVisiteur == "a13").ToList()[0];
        }

        public static List<RAPPORT> rapportParVisiteur(string idVisiteur)
        {
            var LQuery = maConnexion.RAPPORT.ToList().Where(x => x.idVisiteur == idVisiteur);
            return LQuery.ToList() ;
        }

        public static List<Visiteur> ListVisiteur()
        {
            return maConnexion.Visiteur.ToList();
        }

        public static object rapportParId(int unIdRapport)
        {
            var LQuery = maConnexion.RAPPORT.ToList()
                           .Where(x => x.idRapport == unIdRapport);
            return LQuery.ToList();

        }
       
           
            public static List<Visiteur> listeLesVisiteurs()
            {
                return maConnexion.Visiteur.ToList();
            }
            private static string GetMd5Hash(string PasswdSaisi)

            {

                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);

                byte[] hash = (MD5.Create()).ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hash.Length; i++)

                {

                    sb.Append(hash[i].ToString("x2"));

                }

                return sb.ToString();

            }
            public static bool comparerMDP(string id, string mdp)
            {
                bool retour = false;
                List<Visiteur> LesVisiteurs = Modele.listeLesVisiteurs();
                string mdpmd5 = GetMd5Hash(mdp);
                foreach (Visiteur visiteurconnecte in LesVisiteurs)
                {
                    if ((visiteurconnecte.identifiant == id) && (visiteurconnecte.password.Substring(2).Equals(mdpmd5, StringComparison.OrdinalIgnoreCase)))
                    {
                        retour = true;
                        break;
                    }
                }
                return retour;
            }

        
    }
}