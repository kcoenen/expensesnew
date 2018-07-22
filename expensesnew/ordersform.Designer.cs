namespace expenses
{
    partial class ordersform
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
            this.cmbpartner = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbladdbewerken = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLaatsterecord = new System.Windows.Forms.Button();
            this.btn1steRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnPlusId = new System.Windows.Forms.Button();
            this.btnMinId = new System.Windows.Forms.Button();
            this.txtorderid = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvOrderLines = new System.Windows.Forms.DataGridView();
            this.btnAddline = new System.Windows.Forms.Button();
            this.btmnewOrder = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnCreateExcel = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSendMail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderLines)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbpartner
            // 
            this.cmbpartner.Enabled = false;
            this.cmbpartner.FormattingEnabled = true;
            this.cmbpartner.Location = new System.Drawing.Point(80, 121);
            this.cmbpartner.Name = "cmbpartner";
            this.cmbpartner.Size = new System.Drawing.Size(162, 21);
            this.cmbpartner.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(282, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "Date";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Enabled = false;
            this.lbl4.Location = new System.Drawing.Point(7, 129);
            this.lbl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(41, 13);
            this.lbl4.TabIndex = 77;
            this.lbl4.Text = "Partner";
            // 
            // lbladdbewerken
            // 
            this.lbladdbewerken.AutoSize = true;
            this.lbladdbewerken.Location = new System.Drawing.Point(593, 24);
            this.lbladdbewerken.Name = "lbladdbewerken";
            this.lbladdbewerken.Size = new System.Drawing.Size(0, 13);
            this.lbladdbewerken.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 31);
            this.label2.TabIndex = 72;
            this.label2.Text = "Orders";
            // 
            // btnLaatsterecord
            // 
            this.btnLaatsterecord.Location = new System.Drawing.Point(137, 59);
            this.btnLaatsterecord.Margin = new System.Windows.Forms.Padding(2);
            this.btnLaatsterecord.Name = "btnLaatsterecord";
            this.btnLaatsterecord.Size = new System.Drawing.Size(30, 19);
            this.btnLaatsterecord.TabIndex = 71;
            this.btnLaatsterecord.Text = ">>";
            this.btnLaatsterecord.UseVisualStyleBackColor = true;
            this.btnLaatsterecord.Click += new System.EventHandler(this.btnLaatsterecord_Click);
            // 
            // btn1steRecord
            // 
            this.btn1steRecord.Location = new System.Drawing.Point(11, 59);
            this.btn1steRecord.Margin = new System.Windows.Forms.Padding(2);
            this.btn1steRecord.Name = "btn1steRecord";
            this.btn1steRecord.Size = new System.Drawing.Size(28, 19);
            this.btn1steRecord.TabIndex = 70;
            this.btn1steRecord.Text = "<<";
            this.btn1steRecord.UseVisualStyleBackColor = true;
            this.btn1steRecord.Click += new System.EventHandler(this.btn1steRecord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(7, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "naam";
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Location = new System.Drawing.Point(79, 91);
            this.txtname.Margin = new System.Windows.Forms.Padding(2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(162, 20);
            this.txtname.TabIndex = 66;
            // 
            // btnPlusId
            // 
            this.btnPlusId.Location = new System.Drawing.Point(111, 59);
            this.btnPlusId.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlusId.Name = "btnPlusId";
            this.btnPlusId.Size = new System.Drawing.Size(22, 19);
            this.btnPlusId.TabIndex = 65;
            this.btnPlusId.Text = ">";
            this.btnPlusId.UseVisualStyleBackColor = true;
            this.btnPlusId.Click += new System.EventHandler(this.btnPlusId_Click);
            // 
            // btnMinId
            // 
            this.btnMinId.Location = new System.Drawing.Point(43, 59);
            this.btnMinId.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinId.Name = "btnMinId";
            this.btnMinId.Size = new System.Drawing.Size(20, 19);
            this.btnMinId.TabIndex = 64;
            this.btnMinId.Text = "<";
            this.btnMinId.UseVisualStyleBackColor = true;
            this.btnMinId.Click += new System.EventHandler(this.btnMinId_Click);
            // 
            // txtorderid
            // 
            this.txtorderid.Location = new System.Drawing.Point(67, 59);
            this.txtorderid.Margin = new System.Windows.Forms.Padding(2);
            this.txtorderid.Name = "txtorderid";
            this.txtorderid.Size = new System.Drawing.Size(40, 20);
            this.txtorderid.TabIndex = 63;
            this.txtorderid.TextChanged += new System.EventHandler(this.txtorderid_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(326, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 83;
            // 
            // dgvOrderLines
            // 
            this.dgvOrderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderLines.Location = new System.Drawing.Point(10, 165);
            this.dgvOrderLines.Name = "dgvOrderLines";
            this.dgvOrderLines.Size = new System.Drawing.Size(698, 275);
            this.dgvOrderLines.TabIndex = 84;
            // 
            // btnAddline
            // 
            this.btnAddline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddline.Location = new System.Drawing.Point(180, 12);
            this.btnAddline.Name = "btnAddline";
            this.btnAddline.Size = new System.Drawing.Size(75, 23);
            this.btnAddline.TabIndex = 85;
            this.btnAddline.Text = "Add line";
            this.btnAddline.UseVisualStyleBackColor = true;
            this.btnAddline.Click += new System.EventHandler(this.btnAddline_Click);
            // 
            // btmnewOrder
            // 
            this.btmnewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmnewOrder.Location = new System.Drawing.Point(261, 12);
            this.btmnewOrder.Name = "btmnewOrder";
            this.btmnewOrder.Size = new System.Drawing.Size(75, 23);
            this.btmnewOrder.TabIndex = 86;
            this.btmnewOrder.Text = "New order";
            this.btmnewOrder.UseVisualStyleBackColor = true;
            this.btmnewOrder.Click += new System.EventHandler(this.btmnewOrder_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(614, 9);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(94, 23);
            this.btnsave.TabIndex = 87;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Visible = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnCreateExcel
            // 
            this.btnCreateExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateExcel.Location = new System.Drawing.Point(614, 38);
            this.btnCreateExcel.Name = "btnCreateExcel";
            this.btnCreateExcel.Size = new System.Drawing.Size(94, 23);
            this.btnCreateExcel.TabIndex = 88;
            this.btnCreateExcel.Text = "Create Excel";
            this.btnCreateExcel.UseVisualStyleBackColor = true;
            this.btnCreateExcel.Click += new System.EventHandler(this.btnCreateExcel_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(364, 129);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(162, 20);
            this.txtTotal.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(279, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 90;
            this.label4.Text = "Totaal";
            // 
            // btnSendMail
            // 
            this.btnSendMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMail.Location = new System.Drawing.Point(614, 67);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(94, 23);
            this.btnSendMail.TabIndex = 91;
            this.btnSendMail.Text = "Send mail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // ordersform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 452);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCreateExcel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btmnewOrder);
            this.Controls.Add(this.btnAddline);
            this.Controls.Add(this.dgvOrderLines);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbpartner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbladdbewerken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLaatsterecord);
            this.Controls.Add(this.btn1steRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnPlusId);
            this.Controls.Add(this.btnMinId);
            this.Controls.Add(this.txtorderid);
            this.Name = "ordersform";
            this.Text = "ordersform";
            this.Load += new System.EventHandler(this.ordersform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbpartner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbladdbewerken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLaatsterecord;
        private System.Windows.Forms.Button btn1steRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnPlusId;
        private System.Windows.Forms.Button btnMinId;
        private System.Windows.Forms.TextBox txtorderid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvOrderLines;
        private System.Windows.Forms.Button btnAddline;
        private System.Windows.Forms.Button btmnewOrder;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnCreateExcel;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSendMail;
    }
}