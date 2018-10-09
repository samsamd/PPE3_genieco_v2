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
    public partial class FRapportVisite : Form
    {
        public FRapportVisite()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FRapportVisite_Load(object sender, EventArgs e)
        {
            Modele.visiteurC();
            lblutil.Text = Modele.VisiteurConnecte.nom.ToString() + " " + Modele.VisiteurConnecte.prenom.ToString();
            cblisterapp.ValueMember = "idRapport";
            cblisterapp.DisplayMember = "idRapport";
            bsRapport.DataSource = Modele.rapportParVisiteur(Modele.VisiteurConnecte.idVisiteur.ToString());
            cblisterapp.DataSource = bsRapport;
        }

        private void bsRapport_CurrentChanged(object sender, EventArgs e)
        {
            bsMedecin.DataSource = ((RAPPORT)bsRapport.Current).MEDECIN.idMedecin;
            txtboxprac.Text = ((RAPPORT)bsRapport.Current).MEDECIN.nom.ToString();
            txtdaterapp.Text = ((RAPPORT)bsRapport.Current).dateRapport.ToString();


        }
    }
}
