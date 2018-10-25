namespace Mitchell_School_of_Music
{
    partial class frmExternalExam
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
            this.gbxStudentProperties = new System.Windows.Forms.GroupBox();
            this.cboExamTitle = new System.Windows.Forms.ComboBox();
            this.nudExamFee = new System.Windows.Forms.NumericUpDown();
            this.cboExamBoard = new System.Windows.Forms.ComboBox();
            this.cbxAcceptingEntries = new System.Windows.Forms.CheckBox();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.mtbExamTime = new System.Windows.Forms.MaskedTextBox();
            this.lblExamTime = new System.Windows.Forms.Label();
            this.lblExamFee = new System.Windows.Forms.Label();
            this.mtbExamDate = new System.Windows.Forms.MaskedTextBox();
            this.lblExamTitle = new System.Windows.Forms.Label();
            this.lblExamDate = new System.Windows.Forms.Label();
            this.lblExamBoard = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.gbxTools = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvExternalExam = new System.Windows.Forms.DataGridView();
            this.ErrP = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboCollumnTitles = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbxStudentProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExamFee)).BeginInit();
            this.gbxTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExternalExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrP)).BeginInit();
            this.gbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxStudentProperties
            // 
            this.gbxStudentProperties.Controls.Add(this.cboExamTitle);
            this.gbxStudentProperties.Controls.Add(this.nudExamFee);
            this.gbxStudentProperties.Controls.Add(this.cboExamBoard);
            this.gbxStudentProperties.Controls.Add(this.cbxAcceptingEntries);
            this.gbxStudentProperties.Controls.Add(this.cboGrade);
            this.gbxStudentProperties.Controls.Add(this.mtbExamTime);
            this.gbxStudentProperties.Controls.Add(this.lblExamTime);
            this.gbxStudentProperties.Controls.Add(this.lblExamFee);
            this.gbxStudentProperties.Controls.Add(this.mtbExamDate);
            this.gbxStudentProperties.Controls.Add(this.lblExamTitle);
            this.gbxStudentProperties.Controls.Add(this.lblExamDate);
            this.gbxStudentProperties.Controls.Add(this.lblExamBoard);
            this.gbxStudentProperties.Controls.Add(this.lblGrade);
            this.gbxStudentProperties.Location = new System.Drawing.Point(16, 15);
            this.gbxStudentProperties.Margin = new System.Windows.Forms.Padding(4);
            this.gbxStudentProperties.Name = "gbxStudentProperties";
            this.gbxStudentProperties.Padding = new System.Windows.Forms.Padding(4);
            this.gbxStudentProperties.Size = new System.Drawing.Size(441, 242);
            this.gbxStudentProperties.TabIndex = 11;
            this.gbxStudentProperties.TabStop = false;
            this.gbxStudentProperties.Text = "Modify Exams";
            // 
            // cboExamTitle
            // 
            this.cboExamTitle.FormattingEnabled = true;
            this.cboExamTitle.Location = new System.Drawing.Point(120, 55);
            this.cboExamTitle.Name = "cboExamTitle";
            this.cboExamTitle.Size = new System.Drawing.Size(288, 24);
            this.cboExamTitle.TabIndex = 64;
            // 
            // nudExamFee
            // 
            this.nudExamFee.DecimalPlaces = 2;
            this.nudExamFee.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudExamFee.Location = new System.Drawing.Point(136, 176);
            this.nudExamFee.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudExamFee.Name = "nudExamFee";
            this.nudExamFee.Size = new System.Drawing.Size(105, 22);
            this.nudExamFee.TabIndex = 63;
            // 
            // cboExamBoard
            // 
            this.cboExamBoard.FormattingEnabled = true;
            this.cboExamBoard.Items.AddRange(new object[] {
            "Trinity College London",
            "Royal Schools of Music",
            "London College of Music",
            "Victoria College of Music",
            "National College of Music"});
            this.cboExamBoard.Location = new System.Drawing.Point(120, 23);
            this.cboExamBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboExamBoard.Name = "cboExamBoard";
            this.cboExamBoard.Size = new System.Drawing.Size(288, 24);
            this.cboExamBoard.TabIndex = 62;
            // 
            // cbxAcceptingEntries
            // 
            this.cbxAcceptingEntries.AutoSize = true;
            this.cbxAcceptingEntries.Location = new System.Drawing.Point(120, 204);
            this.cbxAcceptingEntries.Margin = new System.Windows.Forms.Padding(4);
            this.cbxAcceptingEntries.Name = "cbxAcceptingEntries";
            this.cbxAcceptingEntries.Size = new System.Drawing.Size(140, 21);
            this.cbxAcceptingEntries.TabIndex = 61;
            this.cbxAcceptingEntries.Text = "Accepting Entries";
            this.cbxAcceptingEntries.UseVisualStyleBackColor = true;
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Items.AddRange(new object[] {
            "B",
            "I",
            "A",
            "D"});
            this.cboGrade.Location = new System.Drawing.Point(119, 82);
            this.cboGrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(121, 24);
            this.cboGrade.TabIndex = 60;
            // 
            // mtbExamTime
            // 
            this.mtbExamTime.Location = new System.Drawing.Point(121, 144);
            this.mtbExamTime.Margin = new System.Windows.Forms.Padding(4);
            this.mtbExamTime.Mask = "00:00";
            this.mtbExamTime.Name = "mtbExamTime";
            this.mtbExamTime.Size = new System.Drawing.Size(120, 22);
            this.mtbExamTime.TabIndex = 59;
            this.mtbExamTime.ValidatingType = typeof(System.DateTime);
            // 
            // lblExamTime
            // 
            this.lblExamTime.AutoSize = true;
            this.lblExamTime.Location = new System.Drawing.Point(32, 149);
            this.lblExamTime.Name = "lblExamTime";
            this.lblExamTime.Size = new System.Drawing.Size(81, 17);
            this.lblExamTime.TabIndex = 58;
            this.lblExamTime.Text = "Exam Time:";
            // 
            // lblExamFee
            // 
            this.lblExamFee.AutoSize = true;
            this.lblExamFee.Location = new System.Drawing.Point(37, 178);
            this.lblExamFee.Name = "lblExamFee";
            this.lblExamFee.Size = new System.Drawing.Size(102, 17);
            this.lblExamFee.TabIndex = 56;
            this.lblExamFee.Text = "Exam Fee:     £";
            // 
            // mtbExamDate
            // 
            this.mtbExamDate.Location = new System.Drawing.Point(120, 114);
            this.mtbExamDate.Margin = new System.Windows.Forms.Padding(4);
            this.mtbExamDate.Mask = "00/00/0000";
            this.mtbExamDate.Name = "mtbExamDate";
            this.mtbExamDate.Size = new System.Drawing.Size(120, 22);
            this.mtbExamDate.TabIndex = 53;
            this.mtbExamDate.ValidatingType = typeof(System.DateTime);
            // 
            // lblExamTitle
            // 
            this.lblExamTitle.AutoSize = true;
            this.lblExamTitle.Location = new System.Drawing.Point(35, 58);
            this.lblExamTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExamTitle.Name = "lblExamTitle";
            this.lblExamTitle.Size = new System.Drawing.Size(77, 17);
            this.lblExamTitle.TabIndex = 4;
            this.lblExamTitle.Text = "Exam Title:";
            // 
            // lblExamDate
            // 
            this.lblExamDate.AutoSize = true;
            this.lblExamDate.Location = new System.Drawing.Point(35, 117);
            this.lblExamDate.Name = "lblExamDate";
            this.lblExamDate.Size = new System.Drawing.Size(80, 17);
            this.lblExamDate.TabIndex = 46;
            this.lblExamDate.Text = "Exam Date:";
            // 
            // lblExamBoard
            // 
            this.lblExamBoard.AutoSize = true;
            this.lblExamBoard.Location = new System.Drawing.Point(24, 26);
            this.lblExamBoard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExamBoard.Name = "lblExamBoard";
            this.lblExamBoard.Size = new System.Drawing.Size(88, 17);
            this.lblExamBoard.TabIndex = 2;
            this.lblExamBoard.Text = "Exam Board:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(61, 89);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(52, 17);
            this.lblGrade.TabIndex = 39;
            this.lblGrade.Text = "Grade:";
            // 
            // gbxTools
            // 
            this.gbxTools.Controls.Add(this.btnClear);
            this.gbxTools.Controls.Add(this.btnCreate);
            this.gbxTools.Controls.Add(this.btnUpdate);
            this.gbxTools.Controls.Add(this.btnDelete);
            this.gbxTools.Location = new System.Drawing.Point(465, 15);
            this.gbxTools.Margin = new System.Windows.Forms.Padding(4);
            this.gbxTools.Name = "gbxTools";
            this.gbxTools.Padding = new System.Windows.Forms.Padding(4);
            this.gbxTools.Size = new System.Drawing.Size(445, 95);
            this.gbxTools.TabIndex = 10;
            this.gbxTools.TabStop = false;
            this.gbxTools.Text = "Tools";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(224, 59);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(208, 28);
            this.btnClear.TabIndex = 67;
            this.btnClear.Text = "&Add new record";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(8, 23);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(208, 28);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "&Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(8, 59);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(208, 28);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(224, 23);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(208, 28);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvExternalExam
            // 
            this.dgvExternalExam.AllowUserToAddRows = false;
            this.dgvExternalExam.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvExternalExam.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExternalExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExternalExam.Location = new System.Drawing.Point(13, 265);
            this.dgvExternalExam.Margin = new System.Windows.Forms.Padding(4);
            this.dgvExternalExam.Name = "dgvExternalExam";
            this.dgvExternalExam.ReadOnly = true;
            this.dgvExternalExam.Size = new System.Drawing.Size(893, 327);
            this.dgvExternalExam.TabIndex = 9;
            this.dgvExternalExam.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExternalExam_CellEnter);
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
            this.gbxSearch.Location = new System.Drawing.Point(465, 118);
            this.gbxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSearch.Size = new System.Drawing.Size(445, 139);
            this.gbxSearch.TabIndex = 12;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(8, 103);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(208, 28);
            this.btnReset.TabIndex = 65;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cboCollumnTitles
            // 
            this.cboCollumnTitles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCollumnTitles.FormattingEnabled = true;
            this.cboCollumnTitles.Location = new System.Drawing.Point(92, 44);
            this.cboCollumnTitles.Margin = new System.Windows.Forms.Padding(4);
            this.cboCollumnTitles.Name = "cboCollumnTitles";
            this.cboCollumnTitles.Size = new System.Drawing.Size(185, 24);
            this.cboCollumnTitles.TabIndex = 63;
            this.cboCollumnTitles.TabStop = false;
            this.cboCollumnTitles.SelectedIndexChanged += new System.EventHandler(this.cboCollumnTitles_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(92, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(345, 22);
            this.txtSearch.TabIndex = 63;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Location = new System.Drawing.Point(61, 47);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(23, 17);
            this.lblIn.TabIndex = 64;
            this.lblIn.Text = "In:";
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.Location = new System.Drawing.Point(7, 18);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(78, 17);
            this.lblSearchFor.TabIndex = 63;
            this.lblSearchFor.Text = "Search for:";
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(229, 103);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(208, 28);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmExternalExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 604);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxStudentProperties);
            this.Controls.Add(this.gbxTools);
            this.Controls.Add(this.dgvExternalExam);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmExternalExam";
            this.Text = "frmExternalExam";
            this.Load += new System.EventHandler(this.frmExternalExam_Load);
            this.gbxStudentProperties.ResumeLayout(false);
            this.gbxStudentProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExamFee)).EndInit();
            this.gbxTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExternalExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrP)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxStudentProperties;
        private System.Windows.Forms.Label lblExamTime;
        private System.Windows.Forms.Label lblExamFee;
        private System.Windows.Forms.MaskedTextBox mtbExamDate;
        private System.Windows.Forms.Label lblExamTitle;
        private System.Windows.Forms.Label lblExamDate;
        private System.Windows.Forms.Label lblExamBoard;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.GroupBox gbxTools;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvExternalExam;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.ErrorProvider ErrP;
        private System.Windows.Forms.CheckBox cbxAcceptingEntries;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cboCollumnTitles;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblSearchFor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboExamBoard;
        private System.Windows.Forms.NumericUpDown nudExamFee;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MaskedTextBox mtbExamTime;
        private System.Windows.Forms.ComboBox cboExamTitle;
    }
}