using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using OfficeOpenXml;

namespace expenses
{
    public partial class ordersform : Form
    {
        private List<Partners> partnerlist;
        public static Int32 orderid;
        public static String folder = @"c:\users\kris\google drive\documenten\rekening papa";
        public String bestand = "";
        public double total;
        public ordersform()
        {
            InitializeComponent();
        }

        private void ordersform_Load(object sender, EventArgs e)
        {
            txtorderid.Text = orderDB.countorder().ToString();
        }

        private void txtorderid_TextChanged(object sender, EventArgs e)
        {
            orderid = Convert.ToInt32(txtorderid.Text);
            Order o = orderDB.getorder(orderid);
            txtname.Text = o.mname;
            dateTimePicker1.Value = o.mdate;
            LoadComboBoxes();
            cmbpartner.SelectedValue = o.mpartner_id;
            getlines();
            txtTotal.Text = calculate_total().ToString();
            total = 0;
        }

        public double calculate_total()
        {
            
            for (Int32 i = 0; i <= dgvOrderLines.RowCount - 1; i++)
            {
                DataGridViewCell price = dgvOrderLines[5, i];
                total += Convert.ToDouble(price.Value);
            }
            return total;
        }

        private void getlines()
        {
            dgvOrderLines.DataSource = order_linesDB.GetorderlinesList(Convert.ToInt32(txtorderid.Text));
            dgvOrderLines.AutoGenerateColumns = false;
            dgvOrderLines.Columns[0].Visible = false;
            dgvOrderLines.Columns[1].Visible = false;
            dgvOrderLines.Columns[2].Visible = false;
            dgvOrderLines.Columns[3].HeaderText = "date";
            dgvOrderLines.Columns[4].HeaderText = "cost";
            dgvOrderLines.Columns[5].HeaderText = "price";
        }

        private void LoadComboBoxes()
        {
            try
            {
                partnerlist = partnersDB.GetpartnerList();
                cmbpartner.DataSource = partnerlist;
                cmbpartner.DisplayMember = "returnname";
                cmbpartner.ValueMember = "mpartner_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnPlusId_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(orderid) < orderDB.countorder())
            {
                int i = Convert.ToInt32(txtorderid.Text);
                i++;
                txtorderid.Text = i.ToString();
            }
        }

        private void btnMinId_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(orderid) > 1)
            {
                int i = Convert.ToInt32(txtorderid.Text);
                i--;
                txtorderid.Text = i.ToString();
            }
        }

        private void btn1steRecord_Click(object sender, EventArgs e)
        {
            txtorderid.Text = "1";
        }

        private void btnLaatsterecord_Click(object sender, EventArgs e)
        {
            txtorderid.Text = orderDB.countorder().ToString();
        }

        private void btnAddline_Click(object sender, EventArgs e)
        {
            frmAddorderLines aol = new frmAddorderLines();
            aol.Show();
            getlines();

        }

        private void btmnewOrder_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtname.Enabled = true;
            cmbpartner.SelectedValue = 1;
            cmbpartner.Enabled = true;
            btnsave.Visible = true;
            dgvOrderLines.DataSource = null;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.mname = txtname.Text;
            o.mpartner_id = Convert.ToInt32(cmbpartner.SelectedValue);
            o.mdate = dateTimePicker1.Value;
            orderDB.Addorder(o);
            txtorderid.Text = orderDB.countorder().ToString();
            btnsave.Visible = false;
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        public void export_order()
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet sheet = package.Workbook.Worksheets.Add("MySheet");
                sheet.Cells["A1"].Value = "Datum";
                sheet.Cells["B1"].Value = "Naam";
                sheet.Cells["C1"].Value = "Prijs";

                for (Int32 i = 0; i <= dgvOrderLines.RowCount - 1; i++)
                {
                    String istr = (i + 2).ToString();
                    DataGridViewCell name = dgvOrderLines[4, i];
                    DataGridViewCell price = dgvOrderLines[5, i];
                    DataGridViewCell date = dgvOrderLines[3, i];
                    sheet.Cells["A" + istr].Style.Numberformat.Format = "dd-mm-yyyy";
                    sheet.Cells["A"+ istr ].Value = date.Value;
                    sheet.Cells["B" + istr].Value = name.Value;
                    sheet.Cells["C" + istr].Style.Numberformat.Format = "#,##0.00";
                    sheet.Cells["C" + istr].Value = price.Value;
                    total += Convert.ToDouble(price.Value);
                }

                sheet.Cells["C23"].Value = total.ToString();

                sheet.Cells["A24"].Value = "rekening";
                sheet.Cells["B24"].Value = "BE91 7350 0468 4276";

                sheet.Cells.AutoFitColumns();
                bestand = folder + @"\" + txtname.Text + ".xls";
                FileInfo excelFile = new FileInfo(bestand);
                package.SaveAs(excelFile);
            }
            MessageBox.Show("Excel file created");

        }

        private void btnCreateExcel_Click(object sender, EventArgs e)
        {
            export_order();
        }

        public void email_send()
        {

            string body = "Papa" + Environment.NewLine +
                Environment.NewLine +
                "Hier is de rekening voor " + txtname.Text + ". Hier zijn de gegevens:" + Environment.NewLine +
                "Bedrag :" + txtTotal.Text.ToString() + " EUR" + Environment.NewLine +
                "Rekening: BE91 7350 0468 4276" + Environment.NewLine +
                Environment.NewLine +
                "Met vriendelijke groeten" + Environment.NewLine +
                Environment.NewLine +
                "Kris Coenen";
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("coenenkris@gmail.com");
            Partners p = partnersDB.getpartner(cmbpartner.SelectedIndex);
            mail.To.Add("coenen.dominique@gmail.com");
            mail.Subject = "rekening " + txtname.Text;
            mail.Body = body;

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(bestand);
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("coenenkris@gmail.com", "zgtlzvbccmxnsytg");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            email_send();
        }
    }

}
