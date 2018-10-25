namespace Mitchell_School_of_Music
{
    partial class frmExamEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtbDateEntry = new System.Windows.Forms.MaskedTextBox();
            this.lblDateEntry = new System.Windows.Forms.Label();
            this.gbxStudentProperties = new System.Windows.Forms.GroupBox();
            this.txtExamData = new System.Windows.Forms.TextBox();
            this.txtStudentData = new System.Windows.Forms.TextBox();
            this.cboExamNo = new System.Windows.Forms.ComboBox();
            this.lblExamNo = new System.Windows.Forms.Label();
            this.cboStudentNo = new System.Windows.Forms.ComboBox();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.mtbDatePaid = new System.Windows.Forms.MaskedTextBox();
            this.lblDatePaid = new System.Windows.Forms.Label();
            this.cbxPaid = new System.Windows.Forms.CheckBox();
            this.gbxTools = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvExamEntry = new System.Windows.Forms.DataGridView();
            this.ErrP = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboCollumnTitles = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbxStudentProperties.SuspendLayout();
            this.gbxTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrP)).BeginInit();
            this.gbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtbDateEntry
            // 
            this.mtbDateEntry.Enabled = false;
            this.mtbDateEntry.Location = new System.Drawing.Point(478, 153);
            this.mtbDateEntry.Mask = "00/00/0000";
            this.mtbDateEntry.Name = "mtbDateEntry";
            this.mtbDateEntry.Size = new System.Drawing.Size(73, 20);
            this.mtbDateEntry.TabIndex = 59;
            this.mtbDateEntry.ValidatingType = typeof(System.DateTime);
            // 
            // lblDateEntry
            // 
            this.lblDateEntry.AutoSize = true;
            this.lblDateEntry.Location = new System.Drawing.Point(414, 155);
            this.lblDateEntry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateEntry.Name = "lblDateEntry";
            this.lblDateEntry.Size = new System.Drawing.Size(59, 13);
            this.lblDateEntry.TabIndex = 58;
            this.lblDateEntry.Text = "Date entry:";
            // 
            // gbxStudentProperties
            // 
            this.gbxStudentProperties.Controls.Add(this.txtExamData);
            this.gbxStudentProperties.Controls.Add(this.txtStudentData);
            this.gbxStudentProperties.Controls.Add(this.cboExamNo);
            this.gbxStudentProperties.Controls.Add(this.lblExamNo);
            this.gbxStudentProperties.Controls.Add(this.cboStudentNo);
            this.gbxStudentProperties.Controls.Add(this.lblStudentNo);
            this.gbxStudentProperties.Controls.Add(this.mtbDatePaid);
            this.gbxStudentProperties.Controls.Add(this.lblDatePaid);
            this.gbxStudentProperties.Controls.Add(this.cbxPaid);
            this.gbxStudentProperties.Controls.Add(this.mtbDateEntry);
            this.gbxStudentProperties.Controls.Add(this.lblDateEntry);
            this.gbxStudentProperties.Location = new System.Drawing.Point(12, 12);
            this.gbxStudentProperties.Name = "gbxStudentProperties";
            this.gbxStudentProperties.Size = new System.Drawing.Size(557, 235);
            this.gbxStudentProperties.TabIndex = 60;
            this.gbxStudentProperties.TabStop = false;
            this.gbxStudentProperties.Text = "Exam entry properties";
            // 
            // txtExamData
            // 
            this.txtExamData.Location = new System.Drawing.Point(7, 54);
            this.txtExamData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExamData.Multiline = true;
            this.txtExamData.Name = "txtExamData";
            this.txtExamData.ReadOnly = true;
            this.txtExamData.Size = new System.Drawing.Size(185, 174);
            this.txtExamData.TabIndex = 70;
            // 
            // txtStudentData
            // 
            this.txtStudentData.Location = new System.Drawing.Point(229, 54);
            this.txtStudentData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStudentData.Multiline = true;
            this.txtStudentData.Name = "txtStudentData";
            this.txtStudentData.ReadOnly = true;
            this.txtStudentData.Size = new System.Drawing.Size(185, 174);
            this.txtStudentData.TabIndex = 69;
            // 
            // cboExamNo
            // 
            this.cboExamNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExamNo.FormattingEnabled = true;
            this.cboExamNo.Location = new System.Drawing.Point(60, 22);
            this.cboExamNo.Name = "cboExamNo";
            this.cboExamNo.Size = new System.Drawing.Size(121, 21);
            this.cboExamNo.TabIndex = 67;
            this.cboExamNo.SelectedIndexChanged += new System.EventHandler(this.cboExamNo_SelectedIndexChanged);
            // 
            // lblExamNo
            // 
            this.lblExamNo.AutoSize = true;
            this.lblExamNo.Location = new System.Drawing.Point(5, 25);
            this.lblExamNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExamNo.Name = "lblExamNo";
            this.lblExamNo.Size = new System.Drawing.Size(50, 13);
            this.lblExamNo.TabIndex = 66;
            this.lblExamNo.Text = "ExamNo:";
            // 
            // cboStudentNo
            // 
            this.cboStudentNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStudentNo.FormattingEnabled = true;
            this.cboStudentNo.Location = new System.Drawing.Point(293, 22);
            this.cboStudentNo.Name = "cboStudentNo";
            this.cboStudentNo.Size = new System.Drawing.Size(121, 21);
            this.cboStudentNo.TabIndex = 65;
            this.cboStudentNo.SelectedIndexChanged += new System.EventHandler(this.cboStudentNo_SelectedIndexChanged);
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Location = new System.Drawing.Point(227, 25);
            this.lblStudentNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(61, 13);
            this.lblStudentNo.TabIndex = 64;
            this.lblStudentNo.Text = "StudentNo:";
            // 
            // mtbDatePaid
            // 
            this.mtbDatePaid.Enabled = false;
            this.mtbDatePaid.Location = new System.Drawing.Point(478, 200);
            this.mtbDatePaid.Mask = "00/00/0000";
            this.mtbDatePaid.Name = "mtbDatePaid";
            this.mtbDatePaid.Size = new System.Drawing.Size(73, 20);
            this.mtbDatePaid.TabIndex = 63;
            this.mtbDatePaid.ValidatingType = typeof(System.DateTime);
            // 
            // lblDatePaid
            // 
            this.lblDatePaid.AutoSize = true;
            this.lblDatePaid.Location = new System.Drawing.Point(418, 202);
            this.lblDatePaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatePaid.Name = "lblDatePaid";
            this.lblDatePaid.Size = new System.Drawing.Size(57, 13);
            this.lblDatePaid.TabIndex = 62;
            this.lblDatePaid.Text = "Date Paid:";
            // 
            // cbxPaid
            // 
            this.cbxPaid.AutoSize = true;
            this.cbxPaid.Location = new System.Drawing.Point(460, 177);
            this.cbxPaid.Name = "cbxPaid";
            this.cbxPaid.Size = new System.Drawing.Size(53, 17);
            this.cbxPaid.TabIndex = 54;
            this.cbxPaid.Text = "Paid?";
            this.cbxPaid.UseVisualStyleBackColor = true;
            this.cbxPaid.CheckedChanged += new System.EventHandler(this.cbxPaid_CheckedChanged);
            // 
            // gbxTools
            // 
            this.gbxTools.Controls.Add(this.btnClear);
            this.gbxTools.Controls.Add(this.btnPay);
            this.gbxTools.Controls.Add(this.btnCreate);
            this.gbxTools.Controls.Add(this.btnUpdate);
            this.gbxTools.Controls.Add(this.btnDelete);
            this.gbxTools.Location = new System.Drawing.Point(575, 130);
            this.gbxTools.Name = "gbxTools";
            this.gbxTools.Size = new System.Drawing.Size(334, 117);
            this.gbxTools.TabIndex = 62;
            this.gbxTools.TabStop = false;
            this.gbxTools.Text = "Tools";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(172, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 23);
            this.btnClear.TabIndex = 66;
            this.btnClear.Text = "&Add new record";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPay
            // 
            this.btnPay.Enabled = false;
            this.btnPay.Location = new System.Drawing.Point(172, 48);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(156, 23);
            this.btnPay.TabIndex = 8;
            this.btnPay.Text = "&Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(6, 19);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(156, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "&Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 48);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(156, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(88, 77);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvExamEntry
            // 
            this.dgvExamEntry.AllowUserToAddRows = false;
            this.dgvExamEntry.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvExamEntry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExamEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamEntry.Location = new System.Drawing.Point(10, 254);
            this.dgvExamEntry.Name = "dgvExamEntry";
            this.dgvExamEntry.ReadOnly = true;
            this.dgvExamEntry.Size = new System.Drawing.Size(899, 280);
            this.dgvExamEntry.TabIndex = 61;
            this.dgvExamEntry.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExamEntry_CellEnter);
            // 
            // ErrP
            // 
            this.ErrP.ContainerControl = this;
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.btnReset);
            this.gbxSearch.Controls.Add(this.cboCollumnTitles);
            this.gbxSearch.Controls.Add(this.txtSearch);
            this.gbxSearch.Controls.Add(this.lblIn);
            this.gbxSearch.Controls.Add(this.lblSearchFor);
            this.gbxSearch.Controls.Add(this.btnSearch);
            this.gbxSearch.Location = new System.Drawing.Point(575, 12);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(334, 111);
            this.gbxSearch.TabIndex = 65;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(6, 84);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(156, 23);
            this.btnReset.TabIndex = 65;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cboCollumnTitles
            // 
            this.cboCollumnTitles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCollumnTitles.FormattingEnabled = true;
            this.cboCollumnTitles.Location = new System.Drawing.Point(69, 36);
            this.cboCollumnTitles.Name = "cboCollumnTitles";
            this.cboCollumnTitles.Size = new System.Drawing.Size(140, 21);
            this.cboCollumnTitles.TabIndex = 63;
            this.cboCollumnTitles.TabStop = false;
            this.cboCollumnTitles.SelectedIndexChanged += new System.EventHandler(this.cboCollumnTitles_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(69, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 20);
            this.txtSearch.TabIndex = 63;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Location = new System.Drawing.Point(46, 38);
            this.lblIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(19, 13);
            this.lblIn.TabIndex = 64;
            this.lblIn.Text = "In:";
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.Location = new System.Drawing.Point(5, 15);
            this.lblSearchFor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(59, 13);
            this.lblSearchFor.TabIndex = 63;
            this.lblSearchFor.Text = "Search for:";
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(172, 84);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(156, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmExamEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 543);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxTools);
            this.Controls.Add(this.dgvExamEntry);
            this.Controls.Add(this.gbxStudentProperties);
            this.Name = "frmExamEntry";
            this.Text = "Modify Exam Entries";
            this.Load += new System.EventHandler(this.frmExamEntry_Load);
            this.gbxStudentProperties.ResumeLayout(false);
            this.gbxStudentProperties.PerformLayout();
            this.gbxTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrP)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbDateEntry;
        private System.Windows.Forms.Label lblDateEntry;
        private System.Windows.Forms.GroupBox gbxStudentProperties;
        private System.Windows.Forms.CheckBox cbxPaid;
        private System.Windows.Forms.MaskedTextBox mtbDatePaid;
        private System.Windows.Forms.Label lblDatePaid;
        private System.Windows.Forms.ComboBox cboStudentNo;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.GroupBox gbxTools;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvExamEntry;
        private System.Windows.Forms.ComboBox cboExamNo;
        private System.Windows.Forms.Label lblExamNo;
        private System.Windows.Forms.TextBox txtExamData;
        private System.Windows.Forms.TextBox txtStudentData;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ErrorProvider ErrP;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cboCollumnTitles;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblSearchFor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
    }
}