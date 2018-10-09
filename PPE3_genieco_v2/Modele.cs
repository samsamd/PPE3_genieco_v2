using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

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

        public static void visiteurC()
        {
            var LQuery = maConnexion.Visiteur.ToList()
                .Where(x => x.idVisiteur == "a13");
            visiteurConnecte = LQuery.ToList()[0];
                
        }
        public static List<MEDECIN> listemedecin()
        {
            return maConnexion.MEDECIN.ToList();
        }
        public static Object rapportParVisiteur(string idVisiteur)
        {
            var LQuery = maConnexion.RAPPORT.ToList()
                .Where(x => x.idVisiteur == idVisiteur)
                .Select(x => new { x.idRapport,x.dateRapport, x.idMotif, x.bilan})
                .OrderBy(x => x.idRapport);
            return LQuery.ToList();
        }
    }
}