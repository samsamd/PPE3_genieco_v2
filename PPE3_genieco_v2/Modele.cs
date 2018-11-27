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

        public static void insertionFraisForfait()
        {
            

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
            catch(Exception ex)
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
        
    }
}