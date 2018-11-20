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
    public partial class FMenuVisiteur : Form
    {
        public FMenuVisiteur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form FRapportVisite = new Form();
            FRapportVisite.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form FGestionFrais = new Form();
            FGestionFrais.Show();
        }
    }
}
