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
    public partial class FGestionFrais : Form
    {
        private List<ComboBox> lescombosregions = new List<ComboBox>();
        private List<ComboBox> lescombosfrais = new List<ComboBox>();
        private List<TextBox> lestxtboxQuantite = new List<TextBox>();
        private List<TextBox> lestxtboxMontantUnitaire = new List<TextBox>();
        private List<TextBox> lestxtboxTotal = new List<TextBox>();

        public FGestionFrais()
        {
            InitializeComponent();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FGestionFrais_Load(object sender, EventArgs e)
        {
            cboFrais.ValueMember = "id";
            cboFrais.DisplayMember = "libelle";
            bsFraisForfaitaire.DataSource = Modele.listeFrais();
            cboFrais.DataSource = bsFraisForfaitaire;
            cboChoixRegion.ValueMember = "id";
            cboChoixRegion.DisplayMember = "libRegion";
            bsRegion.DataSource = Modele.listeRegion();
            cboChoixRegion.DataSource = bsRegion;
        }

       

        private void bsFraisForfaitaire_CurrentChanged_1(object sender, EventArgs e)
        {

            txtboxMontantUnite.Text = Convert.ToString(((FraisForfait)bsFraisForfaitaire.Current).montant);
            decimal total;
            total = Convert.ToDecimal(((FraisForfait)bsFraisForfaitaire.Current).montant) * Convert.ToInt32(numQuantite.Value);
            txtboxTotal.Text = Convert.ToString(total);
        }

        private void bsRegion_CurrentChanged(object sender, EventArgs e)
        {
            txtboxMontantUnite.Text = Convert.ToString(((FraisForfait)bsFraisForfaitaire.Current).montant);
        }

        private void numQuantite_ValueChanged(object sender, EventArgs e)
        {
           decimal total;
           total= Convert.ToDecimal(((FraisForfait)bsFraisForfaitaire.Current).montant)*Convert.ToInt32(numQuantite.Value);
           txtboxTotal.Text = Convert.ToString(total); 
        }

       private void btnAddLine_Click(object sender, EventArgs e)
        {
            //CBO REGIONS

            /*  lescombosregions.Add(cboChoixRegion);
              lescombosregions.Add(new System.Windows.Forms.ComboBox());
              lescombosregions[1].Location = new System.Drawing.Point(lescombosregions[0].Location.X, lescombosregions[0].Location.Y + 30);
              lescombosregions[1].Size = lescombosregions[0].Size;
              this.Controls.Add(lescombosregions[1]);
              lescombosregions[1].ValueMember = "id";
              lescombosregions[1].DisplayMember = "libRegion";
              bsRegion.DataSource = Modele.listeRegion();
              lescombosregions[1].DataSource = bsRegion;

          //CBO FRAIS
              lescombosfrais.Add(cboFrais);
              lescombosfrais.Add(new System.Windows.Forms.ComboBox());
              lescombosfrais[1].Location = new System.Drawing.Point(lescombosfrais[0].Location.X, lescombosfrais[0].Location.Y + 30);
              lescombosfrais[1].Size = lescombosfrais[0].Size;
              this.Controls.Add(lescombosfrais[1]);
              lescombosfrais[1].ValueMember = "id";
              lescombosfrais[1].DisplayMember = "libRegion";
              bsFraisForfaitaire.DataSource = Modele.listeRegion();
              lescombosfrais[1].DataSource = bsFraisForfaitaire;
              */

            cboChoixRegion.ResetText();
            cboFrais.ResetText();
            numQuantite.Value = 0;
            
            // Insertion des lignes  de frais forfaits et hors forfaits


      





        }

       
    }   
        
}
