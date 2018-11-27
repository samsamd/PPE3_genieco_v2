using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_genieco_v2
{
    public partial class FConnex : Form
    {
        public FConnex()
        {
            InitializeComponent();
        }

        public static void threadProcMR()
        {
            Application.Run(new FMenuResponsableLabo1());
        }
        public static void threadProcMS()
        {
            Application.Run(new FResponsableSecteur());
        }
        public static void threadProcM()
        {
            Application.Run(new FMenuVisiteur());
        }

        private void FConnex_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string mdp = textBox2.Text;
            int i = 0;
            bool ouvert = false;
            if (Modele.comparerMDP(id, mdp) == true)
            {
                List<Region> malr = Modele.listResponsableRegion();
                while ( i  < Modele.listResponsableRegion().Count)
                    {
                    if (Modele.listResponsableRegion()[i].idVisiteur == Modele.VisiteurConnecte.idVisiteur)
                    {
                        System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(threadProcMR));
                        t.Start();
                        this.Close();
                        ouvert = true;
                        break;
                    }
                    i = i + 1;
                }
                i = 0;
                while (i < Modele.listResponsableSecteur().Count)
                {
                    if (Modele.listResponsableSecteur()[i].idVisiteur == Modele.VisiteurConnecte.idVisiteur)
                    {
                        System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(threadProcMS));
                        t.Start();
                        this.Close();
                        ouvert = true;
                        break;
                    }
                    i = i + 1;
                }
                if(ouvert == false)
                {
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(threadProcM));
                    t.Start();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Erreur de mdp ou d'identifiant veuillez reessayer");
            }
        }
    }
}

