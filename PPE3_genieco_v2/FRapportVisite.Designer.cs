namespace PPE3_genieco_v2
{
    partial class FRapportVisite
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
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPracticien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxMotif = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxBilan = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bsRapport = new System.Windows.Forms.BindingSource(this.components);
            this.bsRapport2 = new System.Windows.Forms.BindingSource(this.components);
            this.cboNumRapp = new System.Windows.Forms.ComboBox();
            this.dgvMedicament = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.bsMedicament = new System.Windows.Forms.BindingSource(this.components);
            this.btnModif = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(354, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(35, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Médecin";
            // 
            // txtPracticien
            // 
            this.txtPracticien.Location = new System.Drawing.Point(99, 66);
            this.txtPracticien.Name = "txtPracticien";
            this.txtPracticien.Size = new System.Drawing.Size(142, 20);
            this.txtPracticien.TabIndex = 2;
            this.txtPracticien.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date Rapport";
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Location = new System.Drawing.Point(99, 112);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Motif Visite";
            // 
            // txtBoxMotif
            // 
            this.txtBoxMotif.Location = new System.Drawing.Point(99, 155);
            this.txtBoxMotif.Name = "txtBoxMotif";
            this.txtBoxMotif.Size = new System.Drawing.Size(142, 20);
            this.txtBoxMotif.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "BILAN";
            // 
            // txtBoxBilan
            // 
            this.txtBoxBilan.Location = new System.Drawing.Point(99, 217);
            this.txtBoxBilan.Name = "txtBoxBilan";
            this.txtBoxBilan.Size = new System.Drawing.Size(204, 170);
            this.txtBoxBilan.TabIndex = 8;
            this.txtBoxBilan.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numero Rapport";
            // 
            // bsRapport2
            // 
            this.bsRapport2.CurrentChanged += new System.EventHandler(this.bsRapport2_CurrentChanged);
            // 
            // cboNumRapp
            // 
            this.cboNumRapp.FormattingEnabled = true;
            this.cboNumRapp.Location = new System.Drawing.Point(103, 29);
            this.cboNumRapp.Name = "cboNumRapp";
            this.cboNumRapp.Size = new System.Drawing.Size(121, 21);
            this.cboNumRapp.TabIndex = 10;
            this.cboNumRapp.SelectedIndexChanged += new System.EventHandler(this.cboNumRapp_SelectedIndexChanged);
            // 
            // dgvMedicament
            // 
            this.dgvMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicament.Location = new System.Drawing.Point(466, 217);
            this.dgvMedicament.Name = "dgvMedicament";
            this.dgvMedicament.Size = new System.Drawing.Size(244, 118);
            this.dgvMedicament.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Médicaments offerts";
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(466, 415);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(75, 23);
            this.btnModif.TabIndex = 13;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(357, 415);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 14;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FRapportVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvMedicament);
            this.Controls.Add(this.cboNumRapp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxBilan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxMotif);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPracticien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUser);
            this.Name = "FRapportVisite";
            this.Text = "FRapportVisite";
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPracticien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxMotif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtBoxBilan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bsRapport;
        private System.Windows.Forms.BindingSource bsRapport2;
        private System.Windows.Forms.ComboBox cboNumRapp;
        private System.Windows.Forms.DataGridView dgvMedicament;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bsMedicament;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnAjouter;
    }
}