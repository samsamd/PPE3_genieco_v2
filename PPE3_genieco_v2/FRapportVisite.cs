using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PPE3_genieco_v2
{
    public partial class FRapportVisite : Form
    {
        public FRapportVisite()
        {
            InitializeComponent();
           
            bsRapport.DataSource = Modele.rapportParVisiteur(Modele.VisiteurConnecte.idVisiteur);
            lblUser.Text = Modele.VisiteurConnecte.nom + " " + Modele.VisiteurConnecte.prenom;
            cboNumRapp.DataSource = bsRapport.DataSource;
            cboNumRapp.DisplayMember = "idRapport";
            cboNumRapp.ValueMember = "idRapport";
            txtPracticien.Text = ((RAPPORT)bsRapport.Current).MEDECIN.nom.ToString();
            txtBoxMotif.Text = ((RAPPORT)bsRapport.Current).MOTIF.libMotif.ToString();
            txtBoxDate.Text = ((RAPPORT)bsRapport.Current).dateRapport.ToString();
            txtBoxBilan.Text = ((RAPPORT)bsRapport.Current).bilan.ToString();
        }
        private void FRapportVisite_Load(object sender, EventArgs e)
        {

        }
        private void cboNumRapp_SelectedIndexChanged(object sender, EventArgs e)
        {
            bsRapport2.DataSource = Modele.rapportParId(int.Parse(cboNumRapp.SelectedValue.ToString()));
            txtPracticien.Text = ((RAPPORT)bsRapport2.Current).MEDECIN.nom.ToString() ;
            txtBoxMotif.Text = ((RAPPORT)bsRapport2.Current).MOTIF.libMotif.ToString();
            txtBoxDate.Text = ((RAPPORT)bsRapport2.Current).dateRapport.ToString();
            txtBoxBilan.Text = ((RAPPORT)bsRapport2.Current).bilan.ToString();

        }

       private void bsRapport2_CurrentChanged(object sender, EventArgs e)
        {
            bsMedicament.DataSource = Modele.medicamentParRapport(int.Parse(cboNumRapp.SelectedValue.ToString()));
            dgvMedicament.DataSource = bsMedicament;
            dgvMedicament.Columns[0].Visible= false;
            dgvMedicament.Columns[1].HeaderText = "Médicament";
            dgvMedicament.Columns[2].HeaderText = "Quantité";
            dgvMedicament.Columns[3].Visible = false;
            dgvMedicament.Columns[4].Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
