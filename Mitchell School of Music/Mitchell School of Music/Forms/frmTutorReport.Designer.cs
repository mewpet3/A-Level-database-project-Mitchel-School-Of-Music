namespace Mitchell_School_of_Music
{
    partial class frmTutorReport
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
            this.tutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mitchellSchoolOfMusicDataSet = new Mitchell_School_of_Music.MitchellSchoolOfMusicDataSet();
            this.rptvTutor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbxNewQuery = new System.Windows.Forms.GroupBox();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.btnAddQuery = new System.Windows.Forms.Button();
            this.cboCollumnTitles = new System.Windows.Forms.ComboBox();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.btnClearQuery = new System.Windows.Forms.Button();
            this.btnNewQuery = new System.Windows.Forms.Button();
            this.tutorTableAdapter = new Mitchell_School_of_Music.MitchellSchoolOfMusicDataSetTableAdapters.TutorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tutorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellSchoolOfMusicDataSet)).BeginInit();
            this.gbxNewQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // tutorBindingSource
            // 
            this.tutorBindingSource.DataMember = "Tutor";
            this.tutorBindingSource.DataSource = this.mitchellSchoolOfMusicDataSet;
            // 
            // mitchellSchoolOfMusicDataSet
            // 
            this.mitchellSchoolOfMusicDataSet.DataSetName = "MitchellSchoolOfMusicDataSet";
            this.mitchellSchoolOfMusicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptvTutor
            // 
            reportDataSource1.Name = "DataSetTutor";
            reportDataSource1.Value = this.tutorBindingSource;
            this.rptvTutor.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvTutor.LocalReport.ReportEmbeddedResource = "Mitchell_School_of_Music.Entities.rptTutor.rdlc";
            this.rptvTutor.Location = new System.Drawing.Point(9, 121);
            this.rptvTutor.Name = "rptvTutor";
            this.rptvTutor.Size = new System.Drawing.Size(726, 249);
            this.rptvTutor.TabIndex = 12;
            // 
            // gbxNewQuery
            // 
            this.gbxNewQuery.Controls.Add(this.cboSearch);
            this.gbxNewQuery.Controls.Add(this.btnAddQuery);
            this.gbxNewQuery.Controls.Add(this.cboCollumnTitles);
            this.gbxNewQuery.Controls.Add(this.lblIn);
            this.gbxNewQuery.Controls.Add(this.lblSearchFor);
            this.gbxNewQuery.Location = new System.Drawing.Point(10, 11);
            this.gbxNewQuery.Name = "gbxNewQuery";
            this.gbxNewQuery.Size = new System.Drawing.Size(334, 73);
            this.gbxNewQuery.TabIndex = 18;
            this.gbxNewQuery.TabStop = false;
            this.gbxNewQuery.Text = "Query";
            this.gbxNewQuery.Visible = false;
            // 
            // cboSearch
            // 
            this.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Location = new System.Drawing.Point(75, 43);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(157, 21);
            this.cboSearch.TabIndex = 16;
            this.cboSearch.SelectedIndexChanged += new System.EventHandler(this.cboSearch_TextChanged);
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
            // cboCollumnTitles
            // 
            this.cboCollumnTitles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCollumnTitles.FormattingEnabled = true;
            this.cboCollumnTitles.Location = new System.Drawing.Point(75, 16);
            this.cboCollumnTitles.Name = "cboCollumnTitles";
            this.cboCollumnTitles.Size = new System.Drawing.Size(253, 21);
            this.cboCollumnTitles.TabIndex = 63;
            this.cboCollumnTitles.TabStop = false;
            this.cboCollumnTitles.SelectedIndexChanged += new System.EventHandler(this.cboCollumnTitles_SelectedIndexChanged);
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Location = new System.Drawing.Point(25, 20);
            this.lblIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(45, 13);
            this.lblIn.TabIndex = 64;
            this.lblIn.Text = "Column:";
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.Location = new System.Drawing.Point(32, 46);
            this.lblSearchFor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(38, 13);
            this.lblSearchFor.TabIndex = 63;
            this.lblSearchFor.Text = "Query:";
            // 
            // btnClearQuery
            // 
            this.btnClearQuery.Location = new System.Drawing.Point(9, 89);
            this.btnClearQuery.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearQuery.Name = "btnClearQuery";
            this.btnClearQuery.Size = new System.Drawing.Size(92, 28);
            this.btnClearQuery.TabIndex = 20;
            this.btnClearQuery.Text = "Clear Query";
            this.btnClearQuery.UseVisualStyleBackColor = true;
            this.btnClearQuery.Click += new System.EventHandler(this.btnClearQuery_Click);
            // 
            // btnNewQuery
            // 
            this.btnNewQuery.Location = new System.Drawing.Point(8, 23);
            this.btnNewQuery.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewQuery.Name = "btnNewQuery";
            this.btnNewQuery.Size = new System.Drawing.Size(92, 28);
            this.btnNewQuery.TabIndex = 19;
            this.btnNewQuery.Text = "New Query";
            this.btnNewQuery.UseVisualStyleBackColor = true;
            this.btnNewQuery.Click += new System.EventHandler(this.btnNewQuery_Click);
            // 
            // tutorTableAdapter
            // 
            this.tutorTableAdapter.ClearBeforeFill = true;
            // 
            // frmTutorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 382);
            this.Controls.Add(this.gbxNewQuery);
            this.Controls.Add(this.btnClearQuery);
            this.Controls.Add(this.btnNewQuery);
            this.Controls.Add(this.rptvTutor);
            this.Name = "frmTutorReport";
            this.Text = "Tutor Reports";
            this.Load += new System.EventHandler(this.frmTutorReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tutorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellSchoolOfMusicDataSet)).EndInit();
            this.gbxNewQuery.ResumeLayout(false);
            this.gbxNewQuery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rptvTutor;
        private System.Windows.Forms.GroupBox gbxNewQuery;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.Button btnAddQuery;
        private System.Windows.Forms.ComboBox cboCollumnTitles;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblSearchFor;
        private System.Windows.Forms.Button btnClearQuery;
        private System.Windows.Forms.Button btnNewQuery;
        private MitchellSchoolOfMusicDataSet mitchellSchoolOfMusicDataSet;
        private System.Windows.Forms.BindingSource tutorBindingSource;
        private MitchellSchoolOfMusicDataSetTableAdapters.TutorTableAdapter tutorTableAdapter;
    }
}