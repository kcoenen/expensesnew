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
    public partial class frmAddorderLines : Form
    {
        private List<Cost> costlist;
        public frmAddorderLines()
        {
            InitializeComponent();
        }

        private void frmAddorderLines_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            try
            {
                
                costlist = costDB.GetcostList();
                cmbcosts.DataSource = costlist;
                cmbcosts.DisplayMember = "returnname";
                cmbcosts.ValueMember = "mcost_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Order_lines ol = new Order_lines();
            ol.morder_id = ordersform.orderid;
            ol.mcost_id = (int)cmbcosts.SelectedValue;
            ol.mprice = Convert.ToDouble(txtprice.Text);
            ol.mdate = dtpDate.Value;
            order_linesDB.Addorderline(ol);
            this.Close();
        }
    }
}