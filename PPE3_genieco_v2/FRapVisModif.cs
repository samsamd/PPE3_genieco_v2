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
    public partial class FRapVisModif : Form
    {
        public FRapVisModif()
        {
            InitializeComponent();
            bsMedecin.DataSource = Modele.ListMedecinparRegion();
            bsMedicament.DataSource = Modele.ListMedicament();
            lbluser.Text = Modele.VisiteurConnecte.nom + " " + Modele.VisiteurConnecte.prenom;
            cboMedecin.DataSource = bsMedecin.DataSource;
            cboMedecin.DisplayMember = "nom";
            cboMedecin.ValueMember = "idMedecin";
            cboMotif.DataSource = Modele.ListMotif();
            cboMotif.DisplayMember = "libMotif";
            cboMotif.ValueMember = "idMotif";
            cboMedicament1.DataSource = bsMedicament.DataSource;
            cboMedicament1.DisplayMember = "nomCommercial";
            cboMedicament1.ValueMember = "idMedicament";
        }

        private void FRapVisModif_Load(object sender, EventArgs e)
        {

        }

        
    }
}
