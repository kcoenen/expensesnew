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
    public partial class PartnerForm : Form
    {
        private List<Citys> citylist;
        public PartnerForm()
        {
            InitializeComponent();
        }

        private void PartnerForm_Load(object sender, EventArgs e)
        {
            txtpartnerid.Text = "1";
        }


        private void txtpartnerid_TextChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtpartnerid.Text);
            Partners p = partnersDB.getpartner(id);
            txtname.Text = p.mname;
            Citys c = citysDB.getcity(p.mcity_id);
            LoadComboBoxes();
            cmbcity.SelectedValue = c.mcity_id;
            txtstreet.Text = p.mstreet;
            txtemail.Text = p.memail;
            txtcallname.Text = p.mcallname;
        }

        private void LoadComboBoxes()
        {
            try
            {
                citylist = citysDB.GetcitysList();
                cmbcity.DataSource = citylist;
                cmbcity.DisplayMember = "returnname";
                cmbcity.ValueMember = "mcity_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnMinId_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtpartnerid.Text) > 1)
            {
                int i = Convert.ToInt32(txtpartnerid.Text);
                i--;
                txtpartnerid.Text = i.ToString();
            }
        }

        private void btnPlusId_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtpartnerid.Text) < partnersDB.countpartner())
            {
                int i = Convert.ToInt32(txtpartnerid.Text);
                i++;
                txtpartnerid.Text = i.ToString();
            }
        }

        private void btnLaatsterecord_Click(object sender, EventArgs e)
        {
            txtpartnerid.Text = partnersDB.countpartner().ToString();
        }

        private void btn1steRecord_Click(object sender, EventArgs e)
        {
            txtpartnerid.Text = "1";
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            txtpartnerid.Enabled = false;
            txtname.Enabled = true;
            txtstreet.Enabled = true;
            cmbcity.Enabled = true;
            txtemail.Enabled = true;
            txtcallname.Enabled = true;
            btnSave.Visible = true;
            lbladdbewerken.Text = "Change";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtname.Enabled = true;
            txtstreet.Enabled = true;
            cmbcity.Enabled = true;
            txtemail.Enabled = true;
            txtcallname.Enabled = true;
            txtname.Text = "";
            txtstreet.Text = "";
            cmbcity.SelectedValue = 1;
            txtemail.Text = "";
            txtcallname.Text = "";
            btnSave.Visible = true;
            lbladdbewerken.Text = "Add";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Partners p = new Partners();
            if (lbladdbewerken.Text == "Change")
            {
                p.mpartner_id = Convert.ToInt32(txtpartnerid.Text);
                p.mname = txtname.Text;
                p.mstreet = txtstreet.Text;
                p.mcity_id = (int)cmbcity.SelectedValue;
                p.memail = txtemail.Text;
                p.mcallname = txtcallname.Text;
                partnersDB.updatepartner(p);
                btnSave.Visible = false;
                lbladdbewerken.Text = "";
            }
            else
            {
                p.mpartner_id = Convert.ToInt32(txtpartnerid.Text);
                p.mname = txtname.Text;
                p.mstreet = txtstreet.Text;
                p.mcity_id = (int)cmbcity.SelectedValue;
                p.memail = txtemail.Text;
                p.mcallname = txtcallname.Text;
                partnersDB.Addpartner(p);
                btnSave.Visible = false;
                lbladdbewerken.Text = "";
                txtpartnerid.Text = partnersDB.countpartner().ToString();
            }
        }
    }
}
