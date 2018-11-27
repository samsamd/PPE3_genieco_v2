namespace PPE3_genieco_v2
{
    partial class FMenuResponsableLabo1
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
            this.btest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btest
            // 
            this.btest.Location = new System.Drawing.Point(506, 103);
            this.btest.Name = "btest";
            this.btest.Size = new System.Drawing.Size(261, 163);
            this.btest.TabIndex = 3;
            this.btest.Text = "ON TEST LA";
            this.btest.UseVisualStyleBackColor = true;
            // 
            // FMenuResponsableLabo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btest);
            this.Name = "FMenuResponsableLabo1";
            this.Text = "FMenuResponsableLabo1";
            this.Controls.SetChildIndex(this.btest, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btest;
    }
}