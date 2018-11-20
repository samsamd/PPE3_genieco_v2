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

        public static List<OFFRIR> medicamentParRapport(int unIdRapport)
        {
            var LQuery = maConnexion.OFFRIR.ToList().Where(x => x.idRapport == unIdRapport);
            return LQuery.ToList();

        }

    }
}