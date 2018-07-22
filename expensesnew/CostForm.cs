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
    public partial class CostForm : Form
    {
        public CostForm()
        {
            InitializeComponent();
        }

        private void CostForm_Load(object sender, EventArgs e)
        {
            txtcostid.Text = "1";

        }

        private void txtcostid_TextChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtcostid.Text);
            Cost c = costDB.getcost(id);
            txtname.Text = c.mname;
        }

        private void btnPlusId_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtcostid.Text) < costDB.countCost())
            {
                int i = Convert.ToInt32(txtcostid.Text);
                i++;
                txtcostid.Text = i.ToString();
            }
        }

        private void btnMinId_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(txtcostid.Text) > 1)
            {
                int i = Convert.ToInt32(txtcostid.Text);
                i--;
                txtcostid.Text = i.ToString();
            }
        }

        private void btnLaatsterecord_Click(object sender, EventArgs e)
        {
            txtcostid.Text = costDB.countCost().ToString();
        }

        private void btn1steRecord_Click(object sender, EventArgs e)
        {
            txtcostid.Text = 1.ToString();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtname.Enabled = true;
            txtname.Text = "";
            btnSave.Visible = true;
            lbladdbewerken.Text = "Add";
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            txtname.Enabled = true;
            btnSave.Visible = true;
            lbladdbewerken.Text = "Change";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Cost c = new Cost();
            if (lbladdbewerken.Text == "Change")
            {
                c.mcost_id = Convert.ToInt32(txtcostid.Text);
                c.mname = txtname.Text;
                costDB.updatecost(c);
                btnSave.Visible = false;
                lbladdbewerken.Text = "";
            }
            else
            {
                c.mname = txtname.Text;
                txtcostid.Text = costDB.Addcost(c).ToString();
                btnSave.Visible = false;
                lbladdbewerken.Text = "";
            }

            
        }
    }
}
