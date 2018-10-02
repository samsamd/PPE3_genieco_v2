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
    }
}