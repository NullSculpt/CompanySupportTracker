namespace Company_Support_Program
{
    partial class Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.tblCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companySupportDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companySupportDataSet = new Company_Support_Program.CompanySupportDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tblCompanyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_CompanyTableAdapter = new Company_Support_Program.CompanySupportDataSetTableAdapters.tbl_CompanyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companySupportDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companySupportDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompanyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCompanyBindingSource
            // 
            this.tblCompanyBindingSource.DataMember = "tbl_Company";
            this.tblCompanyBindingSource.DataSource = this.companySupportDataSetBindingSource;
            // 
            // companySupportDataSetBindingSource
            // 
            this.companySupportDataSetBindingSource.DataSource = this.companySupportDataSet;
            this.companySupportDataSetBindingSource.Position = 0;
            // 
            // companySupportDataSet
            // 
            this.companySupportDataSet.DataSetName = "CompanySupportDataSet";
            this.companySupportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.BackColor = System.Drawing.Color.Silver;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblCompanyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Company_Support_Program.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 99);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 351);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btnShowAll);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.endDate);
            this.groupBox1.Controls.Add(this.startdate);
            this.groupBox1.Controls.Add(this.cmbCompany);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShowAll.Location = new System.Drawing.Point(637, 19);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 64);
            this.btnShowAll.TabIndex = 8;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShow.Location = new System.Drawing.Point(718, 19);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 64);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show";
            this.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(341, 48);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 20);
            this.endDate.TabIndex = 6;
            // 
            // startdate
            // 
            this.startdate.Location = new System.Drawing.Point(341, 22);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(200, 20);
            this.startdate.TabIndex = 5;
            // 
            // cmbCompany
            // 
            this.cmbCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(94, 26);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(114, 21);
            this.cmbCompany.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company Name:";
            // 
            // tblCompanyBindingSource1
            // 
            this.tblCompanyBindingSource1.DataMember = "tbl_Company";
            this.tblCompanyBindingSource1.DataSource = this.companySupportDataSetBindingSource;
            // 
            // tbl_CompanyTableAdapter
            // 
            this.tbl_CompanyTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companySupportDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companySupportDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompanyBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource companySupportDataSetBindingSource;
        private CompanySupportDataSet companySupportDataSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource tblCompanyBindingSource;
        private CompanySupportDataSetTableAdapters.tbl_CompanyTableAdapter tbl_CompanyTableAdapter;
        private System.Windows.Forms.DateTimePicker startdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tblCompanyBindingSource1;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnShowAll;
    }
}