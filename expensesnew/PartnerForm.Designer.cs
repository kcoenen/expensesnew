namespace expenses
{
    partial class PartnerForm
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
            this.lbladdbewerken = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLaatsterecord = new System.Windows.Forms.Button();
            this.btn1steRecord = new System.Windows.Forms.Button();
            this.btnchange = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnPlusId = new System.Windows.Forms.Button();
            this.btnMinId = new System.Windows.Forms.Button();
            this.txtpartnerid = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcallname = new System.Windows.Forms.TextBox();
            this.cmbcity = new System.Windows.Forms.ComboBox();
            this.txtstreet = new System.Windows.Forms.TextBox();
            this.lblstreet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbladdbewerken
            // 
            this.lbladdbewerken.AutoSize = true;
            this.lbladdbewerken.Location = new System.Drawing.Point(229, 24);
            this.lbladdbewerken.Name = "lbladdbewerken";
            this.lbladdbewerken.Size = new System.Drawing.Size(0, 13);
            this.lbladdbewerken.TabIndex = 53;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 23);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 31);
            this.label2.TabIndex = 51;
            this.label2.Text = "Partners";
            // 
            // btnLaatsterecord
            // 
            this.btnLaatsterecord.Location = new System.Drawing.Point(137, 59);
            this.btnLaatsterecord.Margin = new System.Windows.Forms.Padding(2);
            this.btnLaatsterecord.Name = "btnLaatsterecord";
            this.btnLaatsterecord.Size = new System.Drawing.Size(30, 19);
            this.btnLaatsterecord.TabIndex = 50;
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
            this.btn1steRecord.TabIndex = 49;
            this.btn1steRecord.Text = "<<";
            this.btn1steRecord.UseVisualStyleBackColor = true;
            this.btn1steRecord.Click += new System.EventHandler(this.btn1steRecord_Click);
            // 
            // btnchange
            // 
            this.btnchange.Location = new System.Drawing.Point(94, 290);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(78, 23);
            this.btnchange.TabIndex = 48;
            this.btnchange.Text = "Change";
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(181, 290);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 23);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(7, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "naam";
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Location = new System.Drawing.Point(79, 91);
            this.txtname.Margin = new System.Windows.Forms.Padding(2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(162, 20);
            this.txtname.TabIndex = 45;
            // 
            // btnPlusId
            // 
            this.btnPlusId.Location = new System.Drawing.Point(111, 59);
            this.btnPlusId.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlusId.Name = "btnPlusId";
            this.btnPlusId.Size = new System.Drawing.Size(22, 19);
            this.btnPlusId.TabIndex = 44;
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
            this.btnMinId.TabIndex = 43;
            this.btnMinId.Text = "<";
            this.btnMinId.UseVisualStyleBackColor = true;
            this.btnMinId.Click += new System.EventHandler(this.btnMinId_Click);
            // 
            // txtpartnerid
            // 
            this.txtpartnerid.Location = new System.Drawing.Point(67, 59);
            this.txtpartnerid.Margin = new System.Windows.Forms.Padding(2);
            this.txtpartnerid.Name = "txtpartnerid";
            this.txtpartnerid.Size = new System.Drawing.Size(40, 20);
            this.txtpartnerid.TabIndex = 42;
            this.txtpartnerid.TextChanged += new System.EventHandler(this.txtpartnerid_TextChanged);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Enabled = false;
            this.lbl4.Location = new System.Drawing.Point(7, 175);
            this.lbl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(23, 13);
            this.lbl4.TabIndex = 57;
            this.lbl4.Text = "city";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(7, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "E-mail";
            // 
            // txtemail
            // 
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(79, 207);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(162, 20);
            this.txtemail.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(7, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Callname";
            // 
            // txtcallname
            // 
            this.txtcallname.Enabled = false;
            this.txtcallname.Location = new System.Drawing.Point(79, 244);
            this.txtcallname.Margin = new System.Windows.Forms.Padding(2);
            this.txtcallname.Name = "txtcallname";
            this.txtcallname.Size = new System.Drawing.Size(162, 20);
            this.txtcallname.TabIndex = 60;
            // 
            // cmbcity
            // 
            this.cmbcity.Enabled = false;
            this.cmbcity.FormattingEnabled = true;
            this.cmbcity.Location = new System.Drawing.Point(76, 167);
            this.cmbcity.Name = "cmbcity";
            this.cmbcity.Size = new System.Drawing.Size(162, 21);
            this.cmbcity.TabIndex = 62;
            // 
            // txtstreet
            // 
            this.txtstreet.Enabled = false;
            this.txtstreet.Location = new System.Drawing.Point(79, 130);
            this.txtstreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtstreet.Name = "txtstreet";
            this.txtstreet.Size = new System.Drawing.Size(162, 20);
            this.txtstreet.TabIndex = 54;
            // 
            // lblstreet
            // 
            this.lblstreet.AutoSize = true;
            this.lblstreet.Enabled = false;
            this.lblstreet.Location = new System.Drawing.Point(7, 133);
            this.lblstreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstreet.Name = "lblstreet";
            this.lblstreet.Size = new System.Drawing.Size(68, 13);
            this.lblstreet.TabIndex = 55;
            this.lblstreet.Text = "Street and nr";
            // 
            // PartnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 385);
            this.Controls.Add(this.cmbcity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcallname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lblstreet);
            this.Controls.Add(this.txtstreet);
            this.Controls.Add(this.lbladdbewerken);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLaatsterecord);
            this.Controls.Add(this.btn1steRecord);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnPlusId);
            this.Controls.Add(this.btnMinId);
            this.Controls.Add(this.txtpartnerid);
            this.Name = "PartnerForm";
            this.Text = "PartnerForm";
            this.Load += new System.EventHandler(this.PartnerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbladdbewerken;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLaatsterecord;
        private System.Windows.Forms.Button btn1steRecord;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnPlusId;
        private System.Windows.Forms.Button btnMinId;
        private System.Windows.Forms.TextBox txtpartnerid;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcallname;
        private System.Windows.Forms.ComboBox cmbcity;
        private System.Windows.Forms.TextBox txtstreet;
        private System.Windows.Forms.Label lblstreet;
    }
}