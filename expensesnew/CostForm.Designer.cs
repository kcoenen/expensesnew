namespace expenses
{
    partial class CostForm
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
            this.btnLaatsterecord = new System.Windows.Forms.Button();
            this.btn1steRecord = new System.Windows.Forms.Button();
            this.btnchange = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnPlusId = new System.Windows.Forms.Button();
            this.btnMinId = new System.Windows.Forms.Button();
            this.txtcostid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbladdbewerken = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLaatsterecord
            // 
            this.btnLaatsterecord.Location = new System.Drawing.Point(137, 59);
            this.btnLaatsterecord.Margin = new System.Windows.Forms.Padding(2);
            this.btnLaatsterecord.Name = "btnLaatsterecord";
            this.btnLaatsterecord.Size = new System.Drawing.Size(30, 19);
            this.btnLaatsterecord.TabIndex = 37;
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
            this.btn1steRecord.TabIndex = 36;
            this.btn1steRecord.Text = "<<";
            this.btn1steRecord.UseVisualStyleBackColor = true;
            this.btn1steRecord.Click += new System.EventHandler(this.btn1steRecord_Click);
            // 
            // btnchange
            // 
            this.btnchange.Location = new System.Drawing.Point(85, 137);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(78, 23);
            this.btnchange.TabIndex = 35;
            this.btnchange.Text = "Change";
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(172, 137);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 23);
            this.btnAdd.TabIndex = 34;
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
            this.label1.TabIndex = 31;
            this.label1.Text = "naam";
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Location = new System.Drawing.Point(67, 91);
            this.txtname.Margin = new System.Windows.Forms.Padding(2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(162, 20);
            this.txtname.TabIndex = 30;
            // 
            // btnPlusId
            // 
            this.btnPlusId.Location = new System.Drawing.Point(111, 59);
            this.btnPlusId.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlusId.Name = "btnPlusId";
            this.btnPlusId.Size = new System.Drawing.Size(22, 19);
            this.btnPlusId.TabIndex = 29;
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
            this.btnMinId.TabIndex = 28;
            this.btnMinId.Text = "<";
            this.btnMinId.UseVisualStyleBackColor = true;
            this.btnMinId.Click += new System.EventHandler(this.btnMinId_Click);
            // 
            // txtcostid
            // 
            this.txtcostid.Location = new System.Drawing.Point(67, 59);
            this.txtcostid.Margin = new System.Windows.Forms.Padding(2);
            this.txtcostid.Name = "txtcostid";
            this.txtcostid.Size = new System.Drawing.Size(40, 20);
            this.txtcostid.TabIndex = 27;
            this.txtcostid.TextChanged += new System.EventHandler(this.txtcostid_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 31);
            this.label2.TabIndex = 39;
            this.label2.Text = "Costs";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1, 137);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 23);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbladdbewerken
            // 
            this.lbladdbewerken.AutoSize = true;
            this.lbladdbewerken.Location = new System.Drawing.Point(229, 24);
            this.lbladdbewerken.Name = "lbladdbewerken";
            this.lbladdbewerken.Size = new System.Drawing.Size(0, 13);
            this.lbladdbewerken.TabIndex = 41;
            // 
            // CostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 184);
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
            this.Controls.Add(this.txtcostid);
            this.Name = "CostForm";
            this.Text = "Costs";
            this.Load += new System.EventHandler(this.CostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLaatsterecord;
        private System.Windows.Forms.Button btn1steRecord;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnPlusId;
        private System.Windows.Forms.Button btnMinId;
        private System.Windows.Forms.TextBox txtcostid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbladdbewerken;
    }
}