using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expenses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void costToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CostForm costfrm = new CostForm();
            costfrm.MdiParent = this;
            costfrm.Show();
        }

        private void partnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartnerForm partfrm = new PartnerForm();
            partfrm.MdiParent = this;
            partfrm.Show();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ordersform ordfrm = new ordersform();
            ordfrm.MdiParent = this;
            ordfrm.Show();
        }
    }
}
