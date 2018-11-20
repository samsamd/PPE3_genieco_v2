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

        private void FConnex_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string mdp = textBox2.Text;
            if (Modele.comparerMDP(id, mdp) == true)
            {
                FMenuVisiteur FMenuVisiteur = new FMenuVisiteur();
                FMenuVisiteur.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erreur de mdp ou d'identifiant veuillez reessayer");
            }
        }
    }
}

