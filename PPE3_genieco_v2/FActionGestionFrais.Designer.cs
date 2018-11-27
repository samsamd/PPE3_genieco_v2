namespace PPE3_genieco_v2
{
    partial class FActionGestionFrais
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvModifFicheFrais = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCreerFicheFrais = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifFicheFrais)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modifier une fiche de frais :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ajouter fiche de frais :";
            // 
            // dgvModifFicheFrais
            // 
            this.dgvModifFicheFrais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModifFicheFrais.Location = new System.Drawing.Point(12, 81);
            this.dgvModifFicheFrais.Name = "dgvModifFicheFrais";
            this.dgvModifFicheFrais.Size = new System.Drawing.Size(408, 226);
            this.dgvModifFicheFrais.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(578, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btnCreerFicheFrais
            // 
            this.btnCreerFicheFrais.Location = new System.Drawing.Point(639, 130);
            this.btnCreerFicheFrais.Name = "btnCreerFicheFrais";
            this.btnCreerFicheFrais.Size = new System.Drawing.Size(75, 23);
            this.btnCreerFicheFrais.TabIndex = 4;
            this.btnCreerFicheFrais.Text = "Créer";
            this.btnCreerFicheFrais.UseVisualStyleBackColor = true;
            // 
            // FActionGestionFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(this.btnCreerFicheFrais);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvModifFicheFrais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FActionGestionFrais";
            this.Text = "Gerer/Ajouter fiche de frais";
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifFicheFrais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvModifFicheFrais;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCreerFicheFrais;
    }
}