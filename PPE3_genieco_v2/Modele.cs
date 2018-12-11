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

        public static List<Region> listeRegion()
        {
            return maConnexion.Region.ToList();
        }

        public static List<FraisForfait> listeFrais()
        {
            return maConnexion.FraisForfait.ToList();
        }

        public static bool AjoutLigneFraisForfait(string idVisiteur, string mois, int annee, int quantite, string idFraisForfait)
        {
            bool vretour = true;
            try
            {
                LigneFraisForfait lff = new LigneFraisForfait();
                lff.quantite = quantite;
                lff.idVisiteur = idVisiteur;
                lff.mois = mois;
                lff.annee = annee;
                lff.idFraisForfait = idFraisForfait;
                maConnexion.LigneFraisForfait.Add(lff);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                maConnexion.Dispose();
                init();


            }
            return vretour;

        }
        public static bool AjoutLigneFraisHorsForfait(int id, string idVisiteur, string mois, int annee, string libelle, decimal montant)
        {
            bool vretour = true;
            try
            {
                LigneFraisHorsForfait lhf = new LigneFraisHorsForfait();
                lhf.id = id;
                lhf.idVisiteur = idVisiteur;
                lhf.mois = mois;
                lhf.annee = annee;
                lhf.libelle = libelle;
                lhf.montant = montant;
                maConnexion.LigneFraisHorsForfait.Add(lhf);
                maConnexion.SaveChanges();
            }
            catch
            {
                vretour = false;
                maConnexion.Dispose();
                init();

            }
            return vretour;
        }
        /* public static void connexionTest()
         {
             visiteurConnecte = maConnexion.Visiteur.Where(x => x.idVisiteur == "a13").ToList()[0];
         }*/

        public static List<RAPPORT> rapportParVisiteur(string idVisiteur)
        {
            var LQuery = maConnexion.RAPPORT.ToList().Where(x => x.idVisiteur == idVisiteur);
            return LQuery.ToList() ;
        }

        public static List<Visiteur> ListVisiteur()
        {
            return maConnexion.Visiteur.ToList();
        }

        public static List<MOTIF> ListMotif()
        {
            return maConnexion.MOTIF.ToList();
        }
        public static List<MEDICAMENT> ListMedicament()
        {
            return maConnexion.MEDICAMENT.ToList();
        }
        

        public static int secteurVisiteur()
        {
            var LQuery= maConnexion.Region.ToList().Where(x => x.idVisiteur == VisiteurConnecte.idVisiteur);
            return LQuery.ToList()[0].idSecteur;
        }
        public static object rapportParId(int unIdRapport)
        {
            var LQuery = maConnexion.RAPPORT.ToList()
                           .Where(x => x.idRapport == unIdRapport);
            return LQuery.ToList();

        }
        
      public static List<MEDECIN> ListMedecinparRegion()
        {
            var LQuery = maConnexion.MEDECIN.ToList().Where(x => x.departement == secteurVisiteur());
            return LQuery.ToList();
        }

        public static List<Region> listResponsableRegion()
        {
            return maConnexion.Region.ToList();
        }
        public static List<Secteur> listResponsableSecteur()
        {
            return maConnexion.Secteur.ToList();
        }
            

        public static List<OFFRIR> medicamentParRapport(int unIdRapport)
        {
            var LQuery = maConnexion.OFFRIR.ToList().Where(x => x.idRapport == unIdRapport);
            return LQuery.ToList();
          
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
            List<Visiteur> LesVisiteurs = Modele.ListVisiteur();
            string mdpmd5 = GetMd5Hash(mdp);
            var LQuery = maConnexion.Visiteur.Where(x => x.identifiant == id);
            foreach (Visiteur visiteurconnecte in LesVisiteurs)
            {
                if ((visiteurconnecte.identifiant == id) && (visiteurconnecte.password.Substring(2).Equals(mdpmd5, StringComparison.OrdinalIgnoreCase)))
                {
                    visiteurConnecte = LQuery.ToList()[0];
                    retour = true;
                    break;
                }
            }
            return retour;
        }

    }
}