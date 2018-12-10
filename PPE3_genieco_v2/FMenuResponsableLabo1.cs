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
    public partial class FMenuResponsableLabo1 : FMenuVisiteur
    {
        public FMenuResponsableLabo1()
        {
            InitializeComponent();
        }
        public partial class FMenuAdmin : FMenuResponsableLabo1
        {
            public FMenuAdmin()
            {
                InitializeComponent();

                var item = new System.Windows.Forms.ToolStripMenuItem()
                {
                    Name = "Test",
                    Text = "Test"
                };
                this.parametreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            item});
                item.Click += new System.EventHandler(this.toto);

            }
            private void toto(object sender, EventArgs e)
            {
                MessageBox.Show("ok");
            }


        }
    }
}
