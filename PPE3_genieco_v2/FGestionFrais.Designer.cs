namespace PPE3_genieco_v2
{
    partial class FGestionFrais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblFraisForfaitaire = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblQte = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMontantUnitaire = new System.Windows.Forms.Label();
            this.cboFrais = new System.Windows.Forms.ComboBox();
            this.txtboxMontantUnite = new System.Windows.Forms.TextBox();
            this.cboChoixRegion = new System.Windows.Forms.ComboBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtboxTotal = new System.Windows.Forms.TextBox();
            this.bsFraisForfaitaire = new System.Windows.Forms.BindingSource(this.components);
            this.bsRegion = new System.Windows.Forms.BindingSource(this.components);
            this.numQuantite = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxLibelle = new System.Windows.Forms.TextBox();
            this.btnAddFraisForfait = new System.Windows.Forms.Button();
            this.dgvFraisForfait = new System.Windows.Forms.DataGridView();
            this.numUpDownMontantHF = new System.Windows.Forms.NumericUpDown();
            this.btnAddHorsForfait = new System.Windows.Forms.Button();
            this.dgvFraisHorsForafait = new System.Windows.Forms.DataGridView();
            this.lblHelp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsFraisForfaitaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMontantHF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisHorsForafait)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFraisForfaitaire
            // 
            this.lblFraisForfaitaire.AutoSize = true;
            this.lblFraisForfaitaire.Location = new System.Drawing.Point(247, 72);
            this.lblFraisForfaitaire.Name = "lblFraisForfaitaire";
            this.lblFraisForfaitaire.Size = new System.Drawing.Size(80, 13);
            this.lblFraisForfaitaire.TabIndex = 0;
            this.lblFraisForfaitaire.Text = "Frais forfaitaires";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(127, 30);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(73, 36);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date :";
            // 
            // lblQte
            // 
            this.lblQte.AutoSize = true;
            this.lblQte.Location = new System.Drawing.Point(388, 72);
            this.lblQte.Name = "lblQte";
            this.lblQte.Size = new System.Drawing.Size(47, 13);
            this.lblQte.TabIndex = 5;
            this.lblQte.Text = "Quantité";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(651, 72);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";
            this.lblTotal.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblMontantUnitaire
            // 
            this.lblMontantUnitaire.AutoSize = true;
            this.lblMontantUnitaire.Location = new System.Drawing.Point(506, 72);
            this.lblMontantUnitaire.Name = "lblMontantUnitaire";
            this.lblMontantUnitaire.Size = new System.Drawing.Size(83, 13);
            this.lblMontantUnitaire.TabIndex = 7;
            this.lblMontantUnitaire.Text = "Montant unitaire";
            // 
            // cboFrais
            // 
            this.cboFrais.FormattingEnabled = true;
            this.cboFrais.Location = new System.Drawing.Point(227, 93);
            this.cboFrais.Name = "cboFrais";
            this.cboFrais.Size = new System.Drawing.Size(117, 21);
            this.cboFrais.TabIndex = 8;
            this.cboFrais.SelectedIndexChanged += new System.EventHandler(this.bsFraisForfaitaire_CurrentChanged_1);
            // 
            // txtboxMontantUnite
            // 
            this.txtboxMontantUnite.Location = new System.Drawing.Point(509, 94);
            this.txtboxMontantUnite.Name = "txtboxMontantUnite";
            this.txtboxMontantUnite.ReadOnly = true;
            this.txtboxMontantUnite.Size = new System.Drawing.Size(67, 20);
            this.txtboxMontantUnite.TabIndex = 9;
            // 
            // cboChoixRegion
            // 
            this.cboChoixRegion.FormattingEnabled = true;
            this.cboChoixRegion.Location = new System.Drawing.Point(76, 93);
            this.cboChoixRegion.Name = "cboChoixRegion";
            this.cboChoixRegion.Size = new System.Drawing.Size(127, 21);
            this.cboChoixRegion.TabIndex = 10;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(118, 72);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(47, 13);
            this.lblRegion.TabIndex = 11;
            this.lblRegion.Text = "Région :";
            // 
            // txtboxTotal
            // 
            this.txtboxTotal.Location = new System.Drawing.Point(635, 94);
            this.txtboxTotal.Name = "txtboxTotal";
            this.txtboxTotal.ReadOnly = true;
            this.txtboxTotal.Size = new System.Drawing.Size(60, 20);
            this.txtboxTotal.TabIndex = 13;
            // 
            // bsFraisForfaitaire
            // 
            this.bsFraisForfaitaire.CurrentChanged += new System.EventHandler(this.bsFraisForfaitaire_CurrentChanged_1);
            // 
            // bsRegion
            // 
            this.bsRegion.CurrentChanged += new System.EventHandler(this.bsRegion_CurrentChanged);
            // 
            // numQuantite
            // 
            this.numQuantite.Location = new System.Drawing.Point(381, 93);
            this.numQuantite.Name = "numQuantite";
            this.numQuantite.Size = new System.Drawing.Size(59, 20);
            this.numQuantite.TabIndex = 15;
            this.numQuantite.ValueChanged += new System.EventHandler(this.numQuantite_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "FRAIS HORS FORFAIT";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 208);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Libellé";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Montant";
            // 
            // txtboxLibelle
            // 
            this.txtboxLibelle.Location = new System.Drawing.Point(349, 208);
            this.txtboxLibelle.Name = "txtboxLibelle";
            this.txtboxLibelle.Size = new System.Drawing.Size(121, 20);
            this.txtboxLibelle.TabIndex = 21;
            // 
            // btnAddFraisForfait
            // 
            this.btnAddFraisForfait.Location = new System.Drawing.Point(740, 93);
            this.btnAddFraisForfait.Name = "btnAddFraisForfait";
            this.btnAddFraisForfait.Size = new System.Drawing.Size(75, 23);
            this.btnAddFraisForfait.TabIndex = 23;
            this.btnAddFraisForfait.Text = "Ajouter";
            this.btnAddFraisForfait.UseVisualStyleBackColor = true;
            this.btnAddFraisForfait.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // dgvFraisForfait
            // 
            this.dgvFraisForfait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFraisForfait.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvFraisForfait.Location = new System.Drawing.Point(121, 251);
            this.dgvFraisForfait.Name = "dgvFraisForfait";
            this.dgvFraisForfait.Size = new System.Drawing.Size(634, 135);
            this.dgvFraisForfait.TabIndex = 24;
            // 
            // numUpDownMontantHF
            // 
            this.numUpDownMontantHF.Location = new System.Drawing.Point(509, 208);
            this.numUpDownMontantHF.Name = "numUpDownMontantHF";
            this.numUpDownMontantHF.Size = new System.Drawing.Size(120, 20);
            this.numUpDownMontantHF.TabIndex = 25;
            // 
            // btnAddHorsForfait
            // 
            this.btnAddHorsForfait.Location = new System.Drawing.Point(740, 206);
            this.btnAddHorsForfait.Name = "btnAddHorsForfait";
            this.btnAddHorsForfait.Size = new System.Drawing.Size(75, 23);
            this.btnAddHorsForfait.TabIndex = 26;
            this.btnAddHorsForfait.Text = "Ajouter";
            this.btnAddHorsForfait.UseVisualStyleBackColor = true;
            // 
            // dgvFraisHorsForafait
            // 
            this.dgvFraisHorsForafait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFraisHorsForafait.Location = new System.Drawing.Point(121, 392);
            this.dgvFraisHorsForafait.Name = "dgvFraisHorsForafait";
            this.dgvFraisHorsForafait.Size = new System.Drawing.Size(634, 137);
            this.dgvFraisHorsForafait.TabIndex = 27;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Location = new System.Drawing.Point(378, 30);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(197, 13);
            this.lblHelp.TabIndex = 28;
            this.lblHelp.Text = "Une fiche de frais correspond à un mois.";
            // 
            // FGestionFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(852, 541);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.dgvFraisHorsForafait);
            this.Controls.Add(this.btnAddHorsForfait);
            this.Controls.Add(this.numUpDownMontantHF);
            this.Controls.Add(this.dgvFraisForfait);
            this.Controls.Add(this.btnAddFraisForfait);
            this.Controls.Add(this.txtboxLibelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numQuantite);
            this.Controls.Add(this.txtboxTotal);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.cboChoixRegion);
            this.Controls.Add(this.txtboxMontantUnite);
            this.Controls.Add(this.cboFrais);
            this.Controls.Add(this.lblMontantUnitaire);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblQte);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblFraisForfaitaire);
            this.DoubleBuffered = true;
            this.Name = "FGestionFrais";
            this.Text = "Gestion des frais";
            this.Load += new System.EventHandler(this.FGestionFrais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsFraisForfaitaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMontantHF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisHorsForafait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFraisForfaitaire;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblQte;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMontantUnitaire;
        private System.Windows.Forms.ComboBox cboFrais;
        private System.Windows.Forms.TextBox txtboxMontantUnite;
        private System.Windows.Forms.ComboBox cboChoixRegion;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtboxTotal;
        private System.Windows.Forms.BindingSource bsFraisForfaitaire;
        private System.Windows.Forms.BindingSource bsRegion;
        private System.Windows.Forms.NumericUpDown numQuantite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxLibelle;
        private System.Windows.Forms.Button btnAddFraisForfait;
        private System.Windows.Forms.DataGridView dgvFraisForfait;
        private System.Windows.Forms.NumericUpDown numUpDownMontantHF;
        private System.Windows.Forms.Button btnAddHorsForfait;
        private System.Windows.Forms.DataGridView dgvFraisHorsForafait;
        private System.Windows.Forms.Label lblHelp;
    }
}