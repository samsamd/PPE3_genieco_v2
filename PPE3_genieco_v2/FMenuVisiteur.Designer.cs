namespace PPE3_genieco_v2
{
    partial class FMenuVisiteur
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoPersoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsabilitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierLeMdpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.budgetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parSecteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parRegionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.visiteurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "rapport visite";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "gestion visiteur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoPersoToolStripMenuItem,
            this.responsabilitéToolStripMenuItem,
            this.modifierLeMdpToolStripMenuItem,
            this.budgetToolStripMenuItem});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.informationToolStripMenuItem.Text = "information";
            // 
            // infoPersoToolStripMenuItem
            // 
            this.infoPersoToolStripMenuItem.Name = "infoPersoToolStripMenuItem";
            this.infoPersoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoPersoToolStripMenuItem.Text = "info perso";
            // 
            // responsabilitéToolStripMenuItem
            // 
            this.responsabilitéToolStripMenuItem.Name = "responsabilitéToolStripMenuItem";
            this.responsabilitéToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.responsabilitéToolStripMenuItem.Text = "responsabilité";
            // 
            // modifierLeMdpToolStripMenuItem
            // 
            this.modifierLeMdpToolStripMenuItem.Name = "modifierLeMdpToolStripMenuItem";
            this.modifierLeMdpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifierLeMdpToolStripMenuItem.Text = "modifier le mdp";
            // 
            // budgetToolStripMenuItem
            // 
            this.budgetToolStripMenuItem.Name = "budgetToolStripMenuItem";
            this.budgetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.budgetToolStripMenuItem.Text = "budget";
            // 
            // visiteurToolStripMenuItem
            // 
            this.visiteurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parSecteurToolStripMenuItem,
            this.parRegionToolStripMenuItem,
            this.globalToolStripMenuItem});
            this.visiteurToolStripMenuItem.Name = "visiteurToolStripMenuItem";
            this.visiteurToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.visiteurToolStripMenuItem.Text = "visiteur";
            // 
            // parSecteurToolStripMenuItem
            // 
            this.parSecteurToolStripMenuItem.Name = "parSecteurToolStripMenuItem";
            this.parSecteurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.parSecteurToolStripMenuItem.Text = "par secteur";
            // 
            // parRegionToolStripMenuItem
            // 
            this.parRegionToolStripMenuItem.Name = "parRegionToolStripMenuItem";
            this.parRegionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.parRegionToolStripMenuItem.Text = "par region";
            // 
            // globalToolStripMenuItem
            // 
            this.globalToolStripMenuItem.Name = "globalToolStripMenuItem";
            this.globalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.globalToolStripMenuItem.Text = "global";
            // 
            // FMenuVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMenuVisiteur";
            this.Text = "FMenuVisiteur";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoPersoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsabilitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierLeMdpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem budgetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visiteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parSecteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parRegionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem globalToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}