namespace Mitchell_School_of_Music
{
    partial class frmStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.gbxTools = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxStudentProperties = new System.Windows.Forms.GroupBox();
            this.mtbPostCode = new System.Windows.Forms.MaskedTextBox();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.lblParentName = new System.Windows.Forms.Label();
            this.mtbDateLeft = new System.Windows.Forms.MaskedTextBox();
            this.lblDateLeft = new System.Windows.Forms.Label();
            this.mtbDateJoined = new System.Windows.Forms.MaskedTextBox();
            this.lblDateJoined = new System.Windows.Forms.Label();
            this.cbxCurrentStudent = new System.Windows.Forms.CheckBox();
            this.cbxDisability = new System.Windows.Forms.CheckBox();
            this.mtbDOB = new System.Windows.Forms.MaskedTextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.mtbTelNo = new System.Windows.Forms.MaskedTextBox();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.ErrP = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboCollumnTitles = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.gbxTools.SuspendLayout();
            this.gbxStudentProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrP)).BeginInit();
            this.gbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(16, 446);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.Size = new System.Drawing.Size(1203, 332);
            this.dgvStudent.TabIndex = 1;
            this.dgvStudent.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellEnter);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(43, 27);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(78, 17);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(120, 23);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(361, 22);
            this.txtFirstName.TabIndex = 3;
            // 
            // gbxTools
            // 
            this.gbxTools.Controls.Add(this.btnClear);
            this.gbxTools.Controls.Add(this.btnCreate);
            this.gbxTools.Controls.Add(this.btnUpdate);
            this.gbxTools.Controls.Add(this.btnDelete);
            this.gbxTools.Location = new System.Drawing.Point(540, 161);
            this.gbxTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTools.Name = "gbxTools";
            this.gbxTools.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTools.Size = new System.Drawing.Size(223, 174);
            this.gbxTools.TabIndex = 4;
            this.gbxTools.TabStop = false;
            this.gbxTools.Text = "Tools";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(8, 130);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(208, 28);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "&Add new record";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(8, 23);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(208, 28);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "&Create new student record";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(8, 59);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(208, 28);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "&Update student record";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(8, 95);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(208, 28);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "&Delete student record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxStudentProperties
            // 
            this.gbxStudentProperties.Controls.Add(this.mtbPostCode);
            this.gbxStudentProperties.Controls.Add(this.txtParentName);
            this.gbxStudentProperties.Controls.Add(this.lblParentName);
            this.gbxStudentProperties.Controls.Add(this.mtbDateLeft);
            this.gbxStudentProperties.Controls.Add(this.lblDateLeft);
            this.gbxStudentProperties.Controls.Add(this.mtbDateJoined);
            this.gbxStudentProperties.Controls.Add(this.lblDateJoined);
            this.gbxStudentProperties.Controls.Add(this.cbxCurrentStudent);
            this.gbxStudentProperties.Controls.Add(this.cbxDisability);
            this.gbxStudentProperties.Controls.Add(this.mtbDOB);
            this.gbxStudentProperties.Controls.Add(this.cboGender);
            this.gbxStudentProperties.Controls.Add(this.lblGender);
            this.gbxStudentProperties.Controls.Add(this.txtSurname);
            this.gbxStudentProperties.Controls.Add(this.lblSurname);
            this.gbxStudentProperties.Controls.Add(this.txtTown);
            this.gbxStudentProperties.Controls.Add(this.lblTown);
            this.gbxStudentProperties.Controls.Add(this.lblDOB);
            this.gbxStudentProperties.Controls.Add(this.txtFirstName);
            this.gbxStudentProperties.Controls.Add(this.lblFirstName);
            this.gbxStudentProperties.Controls.Add(this.mtbTelNo);
            this.gbxStudentProperties.Controls.Add(this.lblPostCode);
            this.gbxStudentProperties.Controls.Add(this.lblTelNo);
            this.gbxStudentProperties.Controls.Add(this.txtEmail);
            this.gbxStudentProperties.Controls.Add(this.txtAddress);
            this.gbxStudentProperties.Controls.Add(this.lblAddress);
            this.gbxStudentProperties.Controls.Add(this.lblEmail);
            this.gbxStudentProperties.Location = new System.Drawing.Point(16, 15);
            this.gbxStudentProperties.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxStudentProperties.Name = "gbxStudentProperties";
            this.gbxStudentProperties.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxStudentProperties.Size = new System.Drawing.Size(516, 422);
            this.gbxStudentProperties.TabIndex = 8;
            this.gbxStudentProperties.TabStop = false;
            this.gbxStudentProperties.Text = "Student properties";
            // 
            // mtbPostCode
            // 
            this.mtbPostCode.Location = new System.Drawing.Point(119, 146);
            this.mtbPostCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbPostCode.Mask = "CCCCCCC";
            this.mtbPostCode.Name = "mtbPostCode";
            this.mtbPostCode.Size = new System.Drawing.Size(72, 22);
            this.mtbPostCode.TabIndex = 62;
            // 
            // txtParentName
            // 
            this.txtParentName.Location = new System.Drawing.Point(119, 386);
            this.txtParentName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(361, 22);
            this.txtParentName.TabIndex = 61;
            // 
            // lblParentName
            // 
            this.lblParentName.AutoSize = true;
            this.lblParentName.Location = new System.Drawing.Point(17, 390);
            this.lblParentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(93, 17);
            this.lblParentName.TabIndex = 60;
            this.lblParentName.Text = "Parent name:";
            // 
            // mtbDateLeft
            // 
            this.mtbDateLeft.Enabled = false;
            this.mtbDateLeft.Location = new System.Drawing.Point(361, 354);
            this.mtbDateLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbDateLeft.Mask = "00/00/0000";
            this.mtbDateLeft.Name = "mtbDateLeft";
            this.mtbDateLeft.Size = new System.Drawing.Size(120, 22);
            this.mtbDateLeft.TabIndex = 59;
            this.mtbDateLeft.ValidatingType = typeof(System.DateTime);
            // 
            // lblDateLeft
            // 
            this.lblDateLeft.AutoSize = true;
            this.lblDateLeft.Location = new System.Drawing.Point(283, 358);
            this.lblDateLeft.Name = "lblDateLeft";
            this.lblDateLeft.Size = new System.Drawing.Size(70, 17);
            this.lblDateLeft.TabIndex = 58;
            this.lblDateLeft.Text = "Date Left:";
            // 
            // mtbDateJoined
            // 
            this.mtbDateJoined.Enabled = false;
            this.mtbDateJoined.Location = new System.Drawing.Point(120, 354);
            this.mtbDateJoined.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbDateJoined.Mask = "00/00/0000";
            this.mtbDateJoined.Name = "mtbDateJoined";
            this.mtbDateJoined.Size = new System.Drawing.Size(140, 22);
            this.mtbDateJoined.TabIndex = 57;
            this.mtbDateJoined.ValidatingType = typeof(System.DateTime);
            // 
            // lblDateJoined
            // 
            this.lblDateJoined.AutoSize = true;
            this.lblDateJoined.Location = new System.Drawing.Point(24, 358);
            this.lblDateJoined.Name = "lblDateJoined";
            this.lblDateJoined.Size = new System.Drawing.Size(88, 17);
            this.lblDateJoined.TabIndex = 56;
            this.lblDateJoined.Text = "Date Joined:";
            // 
            // cbxCurrentStudent
            // 
            this.cbxCurrentStudent.AutoSize = true;
            this.cbxCurrentStudent.Checked = true;
            this.cbxCurrentStudent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxCurrentStudent.Location = new System.Drawing.Point(120, 326);
            this.cbxCurrentStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCurrentStudent.Name = "cbxCurrentStudent";
            this.cbxCurrentStudent.Size = new System.Drawing.Size(138, 21);
            this.cbxCurrentStudent.TabIndex = 55;
            this.cbxCurrentStudent.Text = "Current Student?";
            this.cbxCurrentStudent.UseVisualStyleBackColor = true;
            this.cbxCurrentStudent.CheckedChanged += new System.EventHandler(this.cbxCurrentStudent_CheckedChanged);
            // 
            // cbxDisability
            // 
            this.cbxDisability.AutoSize = true;
            this.cbxDisability.Location = new System.Drawing.Point(120, 298);
            this.cbxDisability.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxDisability.Name = "cbxDisability";
            this.cbxDisability.Size = new System.Drawing.Size(94, 21);
            this.cbxDisability.TabIndex = 54;
            this.cbxDisability.Text = "Disability?";
            this.cbxDisability.UseVisualStyleBackColor = true;
            // 
            // mtbDOB
            // 
            this.mtbDOB.Location = new System.Drawing.Point(120, 204);
            this.mtbDOB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbDOB.Mask = "00/00/0000";
            this.mtbDOB.Name = "mtbDOB";
            this.mtbDOB.Size = new System.Drawing.Size(140, 22);
            this.mtbDOB.TabIndex = 53;
            this.mtbDOB.ValidatingType = typeof(System.DateTime);
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(120, 265);
            this.cboGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(140, 24);
            this.cboGender.TabIndex = 52;
            this.cboGender.TabStop = false;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(53, 268);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 17);
            this.lblGender.TabIndex = 51;
            this.lblGender.Text = "Gender:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(120, 55);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(361, 22);
            this.txtSurname.TabIndex = 5;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(43, 59);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(69, 17);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Surname:";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(120, 116);
            this.txtTown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(361, 22);
            this.txtTown.TabIndex = 42;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(65, 119);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(46, 17);
            this.lblTown.TabIndex = 41;
            this.lblTown.Text = "Town:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(71, 208);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(42, 17);
            this.lblDOB.TabIndex = 46;
            this.lblDOB.Text = "DOB:";
            // 
            // mtbTelNo
            // 
            this.mtbTelNo.Location = new System.Drawing.Point(120, 234);
            this.mtbTelNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbTelNo.Mask = "+440000000000";
            this.mtbTelNo.Name = "mtbTelNo";
            this.mtbTelNo.Size = new System.Drawing.Size(140, 22);
            this.mtbTelNo.TabIndex = 49;
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(36, 149);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(77, 17);
            this.lblPostCode.TabIndex = 43;
            this.lblPostCode.Text = "Post Code:";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(56, 238);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(54, 17);
            this.lblTelNo.TabIndex = 30;
            this.lblTelNo.Text = "Tel No:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 175);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(361, 22);
            this.txtEmail.TabIndex = 37;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 86);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(361, 22);
            this.txtAddress.TabIndex = 40;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(51, 90);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 39;
            this.lblAddress.Text = "Address:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 178);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(101, 17);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Email address:";
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
            this.gbxSearch.Location = new System.Drawing.Point(540, 15);
            this.gbxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxSearch.Size = new System.Drawing.Size(445, 139);
            this.gbxSearch.TabIndex = 8;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(8, 103);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.cboCollumnTitles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCollumnTitles.Name = "cboCollumnTitles";
            this.cboCollumnTitles.Size = new System.Drawing.Size(185, 24);
            this.cboCollumnTitles.TabIndex = 63;
            this.cboCollumnTitles.TabStop = false;
            this.cboCollumnTitles.SelectedIndexChanged += new System.EventHandler(this.cboCollumnTitles_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(92, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(208, 28);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 790);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxStudentProperties);
            this.Controls.Add(this.gbxTools);
            this.Controls.Add(this.dgvStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Students";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.gbxTools.ResumeLayout(false);
            this.gbxStudentProperties.ResumeLayout(false);
            this.gbxStudentProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrP)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox gbxTools;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxStudentProperties;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.MaskedTextBox mtbTelNo;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mtbDOB;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.MaskedTextBox mtbDateLeft;
        private System.Windows.Forms.Label lblDateLeft;
        private System.Windows.Forms.MaskedTextBox mtbDateJoined;
        private System.Windows.Forms.Label lblDateJoined;
        private System.Windows.Forms.CheckBox cbxCurrentStudent;
        private System.Windows.Forms.CheckBox cbxDisability;
        private System.Windows.Forms.ErrorProvider ErrP;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Label lblParentName;
        private System.Windows.Forms.MaskedTextBox mtbPostCode;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblSearchFor;
        private System.Windows.Forms.ComboBox cboCollumnTitles;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClear;
    }
}