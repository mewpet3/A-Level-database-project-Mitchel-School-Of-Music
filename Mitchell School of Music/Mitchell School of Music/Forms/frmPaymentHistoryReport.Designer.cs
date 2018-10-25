﻿namespace Mitchell_School_of_Music
{
    partial class frmPaymentHistoryReport
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
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mitchellSchoolOfMusicDataSet = new Mitchell_School_of_Music.MitchellSchoolOfMusicDataSet();
            this.rptvPaymentHistory = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbxNewQuery = new System.Windows.Forms.GroupBox();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.cboCollumnTitles = new System.Windows.Forms.ComboBox();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.btnAddQuery = new System.Windows.Forms.Button();
            this.btnNewQuery = new System.Windows.Forms.Button();
            this.paymentTableAdapter = new Mitchell_School_of_Music.MitchellSchoolOfMusicDataSetTableAdapters.PaymentTableAdapter();
            this.btnClearQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellSchoolOfMusicDataSet)).BeginInit();
            this.gbxNewQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.mitchellSchoolOfMusicDataSet;
            // 
            // mitchellSchoolOfMusicDataSet
            // 
            this.mitchellSchoolOfMusicDataSet.DataSetName = "MitchellSchoolOfMusicDataSet";
            this.mitchellSchoolOfMusicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptvPaymentHistory
            // 
            reportDataSource1.Name = "PaymentHistoryDataSet";
            reportDataSource1.Value = this.paymentBindingSource;
            this.rptvPaymentHistory.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvPaymentHistory.LocalReport.ReportEmbeddedResource = "Mitchell_School_of_Music.Entities.rptPaymentHistory.rdlc";
            this.rptvPaymentHistory.Location = new System.Drawing.Point(12, 122);
            this.rptvPaymentHistory.Name = "rptvPaymentHistory";
            this.rptvPaymentHistory.Size = new System.Drawing.Size(685, 299);
            this.rptvPaymentHistory.TabIndex = 0;
            // 
            // gbxNewQuery
            // 
            this.gbxNewQuery.Controls.Add(this.cboSearch);
            this.gbxNewQuery.Controls.Add(this.cboCollumnTitles);
            this.gbxNewQuery.Controls.Add(this.lblIn);
            this.gbxNewQuery.Controls.Add(this.lblSearchFor);
            this.gbxNewQuery.Controls.Add(this.btnAddQuery);
            this.gbxNewQuery.Location = new System.Drawing.Point(10, 11);
            this.gbxNewQuery.Name = "gbxNewQuery";
            this.gbxNewQuery.Size = new System.Drawing.Size(334, 73);
            this.gbxNewQuery.TabIndex = 14;
            this.gbxNewQuery.TabStop = false;
            this.gbxNewQuery.Text = "Query";
            this.gbxNewQuery.Visible = false;
            // 
            // cboSearch
            // 
            this.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Location = new System.Drawing.Point(73, 39);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(157, 21);
            this.cboSearch.TabIndex = 65;
            this.cboSearch.SelectedIndexChanged += new System.EventHandler(this.cboSearch_TextChanged);
            // 
            // cboCollumnTitles
            // 
            this.cboCollumnTitles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCollumnTitles.FormattingEnabled = true;
            this.cboCollumnTitles.Location = new System.Drawing.Point(73, 12);
            this.cboCollumnTitles.Name = "cboCollumnTitles";
            this.cboCollumnTitles.Size = new System.Drawing.Size(255, 21);
            this.cboCollumnTitles.TabIndex = 66;
            this.cboCollumnTitles.TabStop = false;
            this.cboCollumnTitles.SelectedIndexChanged += new System.EventHandler(this.cboCollumnTitles_SelectedIndexChanged);
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Location = new System.Drawing.Point(23, 16);
            this.lblIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(45, 13);
            this.lblIn.TabIndex = 68;
            this.lblIn.Text = "Column:";
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.Location = new System.Drawing.Point(30, 42);
            this.lblSearchFor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(38, 13);
            this.lblSearchFor.TabIndex = 67;
            this.lblSearchFor.Text = "Query:";
            // 
            // btnAddQuery
            // 
            this.btnAddQuery.Enabled = false;
            this.btnAddQuery.Location = new System.Drawing.Point(237, 38);
            this.btnAddQuery.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddQuery.Name = "btnAddQuery";
            this.btnAddQuery.Size = new System.Drawing.Size(92, 28);
            this.btnAddQuery.TabIndex = 14;
            this.btnAddQuery.Text = "Add Query";
            this.btnAddQuery.UseVisualStyleBackColor = true;
            this.btnAddQuery.Click += new System.EventHandler(this.btnAddQuery_Click);
            // 
            // btnNewQuery
            // 
            this.btnNewQuery.Location = new System.Drawing.Point(8, 23);
            this.btnNewQuery.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewQuery.Name = "btnNewQuery";
            this.btnNewQuery.Size = new System.Drawing.Size(92, 28);
            this.btnNewQuery.TabIndex = 15;
            this.btnNewQuery.Text = "New Query";
            this.btnNewQuery.UseVisualStyleBackColor = true;
            this.btnNewQuery.Click += new System.EventHandler(this.btnNewQuery_Click);
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // btnClearQuery
            // 
            this.btnClearQuery.Location = new System.Drawing.Point(11, 89);
            this.btnClearQuery.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearQuery.Name = "btnClearQuery";
            this.btnClearQuery.Size = new System.Drawing.Size(92, 28);
            this.btnClearQuery.TabIndex = 18;
            this.btnClearQuery.Text = "Clear Query";
            this.btnClearQuery.UseVisualStyleBackColor = true;
            this.btnClearQuery.Click += new System.EventHandler(this.btnClearQuery_Click);
            // 
            // frmPaymentHistoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 433);
            this.Controls.Add(this.btnClearQuery);
            this.Controls.Add(this.gbxNewQuery);
            this.Controls.Add(this.btnNewQuery);
            this.Controls.Add(this.rptvPaymentHistory);
            this.Name = "frmPaymentHistoryReport";
            this.Text = "Payment Reports";
            this.Load += new System.EventHandler(this.frmPaymentHistoryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellSchoolOfMusicDataSet)).EndInit();
            this.gbxNewQuery.ResumeLayout(false);
            this.gbxNewQuery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvPaymentHistory;
        private System.Windows.Forms.GroupBox gbxNewQuery;
        private System.Windows.Forms.Button btnAddQuery;
        private System.Windows.Forms.Button btnNewQuery;
        private MitchellSchoolOfMusicDataSet mitchellSchoolOfMusicDataSet;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private MitchellSchoolOfMusicDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.ComboBox cboCollumnTitles;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblSearchFor;
        private System.Windows.Forms.Button btnClearQuery;
    }
}