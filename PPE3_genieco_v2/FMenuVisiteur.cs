﻿using System;
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

        private void FMenuVisiteur_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            FRapportVisite FRapportVisite = new FRapportVisite();
            FRapportVisite.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FGestionFrais FGestionFrais = new FGestionFrais();
            FGestionFrais.Show();
        }
    }
}
