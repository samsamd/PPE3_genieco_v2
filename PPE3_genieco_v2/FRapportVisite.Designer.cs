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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdaterapp = new System.Windows.Forms.TextBox();
            this.txtmotif = new System.Windows.Forms.TextBox();
            this.rtxtbilan = new System.Windows.Forms.RichTextBox();
            this.cblisterapp = new System.Windows.Forms.ComboBox();
            this.txtboxprac = new System.Windows.Forms.TextBox();
            this.lblutil = new System.Windows.Forms.Label();
            this.bsRapport = new System.Windows.Forms.BindingSource(this.components);
            this.bsMedecin = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro Rapport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Practicien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Rapport";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Motif Visite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "BILAN";
            // 
            // txtdaterapp
            // 
            this.txtdaterapp.Location = new System.Drawing.Point(112, 156);
            this.txtdaterapp.Name = "txtdaterapp";
            this.txtdaterapp.Size = new System.Drawing.Size(100, 20);
            this.txtdaterapp.TabIndex = 6;
            // 
            // txtmotif
            // 
            this.txtmotif.Location = new System.Drawing.Point(112, 208);
            this.txtmotif.Name = "txtmotif";
            this.txtmotif.Size = new System.Drawing.Size(144, 20);
            this.txtmotif.TabIndex = 7;
            // 
            // rtxtbilan
            // 
            this.rtxtbilan.Location = new System.Drawing.Point(112, 259);
            this.rtxtbilan.Name = "rtxtbilan";
            this.rtxtbilan.Size = new System.Drawing.Size(181, 140);
            this.rtxtbilan.TabIndex = 8;
            this.rtxtbilan.Text = "";
            // 
            // cblisterapp
            // 
            this.cblisterapp.FormattingEnabled = true;
            this.cblisterapp.Location = new System.Drawing.Point(112, 71);
            this.cblisterapp.Name = "cblisterapp";
            this.cblisterapp.Size = new System.Drawing.Size(121, 21);
            this.cblisterapp.TabIndex = 10;
            // 
            // txtboxprac
            // 
            this.txtboxprac.Location = new System.Drawing.Point(112, 115);
            this.txtboxprac.Name = "txtboxprac";
            this.txtboxprac.Size = new System.Drawing.Size(100, 20);
            this.txtboxprac.TabIndex = 12;
            // 
            // lblutil
            // 
            this.lblutil.AutoSize = true;
            this.lblutil.Location = new System.Drawing.Point(349, 33);
            this.lblutil.Name = "lblutil";
            this.lblutil.Size = new System.Drawing.Size(101, 13);
            this.lblutil.TabIndex = 13;
            this.lblutil.Text = "Utilisateur connecté";
            // 
            // bsRapport
            // 
            this.bsRapport.CurrentChanged += new System.EventHandler(this.bsRapport_CurrentChanged);
            // 
            // FRapportVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblutil);
            this.Controls.Add(this.txtboxprac);
            this.Controls.Add(this.cblisterapp);
            this.Controls.Add(this.rtxtbilan);
            this.Controls.Add(this.txtmotif);
            this.Controls.Add(this.txtdaterapp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRapportVisite";
            this.Text = "Rapport de Visite";
            this.Load += new System.EventHandler(this.FRapportVisite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdaterapp;
        private System.Windows.Forms.TextBox txtmotif;
        private System.Windows.Forms.RichTextBox rtxtbilan;
        private System.Windows.Forms.ComboBox cblisterapp;
        private System.Windows.Forms.TextBox txtboxprac;
        private System.Windows.Forms.Label lblutil;
        private System.Windows.Forms.BindingSource bsRapport;
        private System.Windows.Forms.BindingSource bsMedecin;
    }
}