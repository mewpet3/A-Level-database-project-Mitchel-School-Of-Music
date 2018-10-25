namespace Mitchell_School_of_Music
{
    partial class frmTutor
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
            this.gbxTutorProperties = new System.Windows.Forms.GroupBox();
            this.mtbPostCode = new System.Windows.Forms.MaskedTextBox();
            this.txtNextOfKinName = new System.Windows.Forms.TextBox();
            this.mtbTelNo = new System.Windows.Forms.MaskedTextBox();
            this.lblNextOfKinName = new System.Windows.Forms.Label();
            this.mtbDateLeft = new System.Windows.Forms.MaskedTextBox();
            this.lblDateLeft = new System.Windows.Forms.Label();
            this.mtbDateJoined = new System.Windows.Forms.MaskedTextBox();
            this.txtDateJoined = new System.Windows.Forms.Label();
            this.cbxCurrentTutor = new System.Windows.Forms.CheckBox();
            this.cbxDisability = new System.Windows.Forms.CheckBox();
            this.mtbDOB = new System.Windows.Forms.MaskedTextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gbxTools = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnProficiencies = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvTutor = new System.Windows.Forms.DataGridView();
            this.ErrP = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboCollumnTitles = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbxTutorProperties.SuspendLayout();
            this.gbxTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrP)).BeginInit();
            this.gbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxTutorProperties
            // 
            this.gbxTutorProperties.Controls.Add(this.mtbPostCode);
            this.gbxTutorProperties.Controls.Add(this.txtNextOfKinName);
            this.gbxTutorProperties.Controls.Add(this.mtbTelNo);
            this.gbxTutorProperties.Controls.Add(this.lblNextOfKinName);
            this.gbxTutorProperties.Controls.Add(this.mtbDateLeft);
            this.gbxTutorProperties.Controls.Add(this.lblDateLeft);
            this.gbxTutorProperties.Controls.Add(this.mtbDateJoined);
            this.gbxTutorProperties.Controls.Add(this.txtDateJoined);
            this.gbxTutorProperties.Controls.Add(this.cbxCurrentTutor);
            this.gbxTutorProperties.Controls.Add(this.cbxDisability);
            this.gbxTutorProperties.Controls.Add(this.mtbDOB);
            this.gbxTutorProperties.Controls.Add(this.cboGender);
            this.gbxTutorProperties.Controls.Add(this.lblGender);
            this.gbxTutorProperties.Controls.Add(this.txtSurname);
            this.gbxTutorProperties.Controls.Add(this.lblSurname);
            this.gbxTutorProperties.Controls.Add(this.txtTown);
            this.gbxTutorProperties.Controls.Add(this.lblTown);
            this.gbxTutorProperties.Controls.Add(this.lblDOB);
            this.gbxTutorProperties.Controls.Add(this.txtFirstName);
            this.gbxTutorProperties.Controls.Add(this.lblFirstName);
            this.gbxTutorProperties.Controls.Add(this.lblPostCode);
            this.gbxTutorProperties.Controls.Add(this.lblTelNo);
            this.gbxTutorProperties.Controls.Add(this.txtEmail);
            this.gbxTutorProperties.Controls.Add(this.txtAddress);
            this.gbxTutorProperties.Controls.Add(this.lblAddress);
            this.gbxTutorProperties.Controls.Add(this.lblEmail);
            this.gbxTutorProperties.Location = new System.Drawing.Point(16, 15);
            this.gbxTutorProperties.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTutorProperties.Name = "gbxTutorProperties";
            this.gbxTutorProperties.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTutorProperties.Size = new System.Drawing.Size(569, 422);
            this.gbxTutorProperties.TabIndex = 11;
            this.gbxTutorProperties.TabStop = false;
            this.gbxTutorProperties.Text = "Tutor properties";
            // 
            // mtbPostCode
            // 
            this.mtbPostCode.Location = new System.Drawing.Point(140, 146);
            this.mtbPostCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbPostCode.Mask = "CCCCCCC";
            this.mtbPostCode.Name = "mtbPostCode";
            this.mtbPostCode.Size = new System.Drawing.Size(72, 22);
            this.mtbPostCode.TabIndex = 64;
            // 
            // txtNextOfKinName
            // 
            this.txtNextOfKinName.Location = new System.Drawing.Point(139, 386);
            this.txtNextOfKinName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNextOfKinName.Name = "txtNextOfKinName";
            this.txtNextOfKinName.Size = new System.Drawing.Size(417, 22);
            this.txtNextOfKinName.TabIndex = 61;
            // 
            // mtbTelNo
            // 
            this.mtbTelNo.Location = new System.Drawing.Point(140, 235);
            this.mtbTelNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbTelNo.Mask = "+440000000000";
            this.mtbTelNo.Name = "mtbTelNo";
            this.mtbTelNo.Size = new System.Drawing.Size(140, 22);
            this.mtbTelNo.TabIndex = 63;
            // 
            // lblNextOfKinName
            // 
            this.lblNextOfKinName.AutoSize = true;
            this.lblNextOfKinName.Location = new System.Drawing.Point(11, 390);
            this.lblNextOfKinName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNextOfKinName.Name = "lblNextOfKinName";
            this.lblNextOfKinName.Size = new System.Drawing.Size(117, 17);
            this.lblNextOfKinName.TabIndex = 60;
            this.lblNextOfKinName.Text = "Next of kin name:";
            // 
            // mtbDateLeft
            // 
            this.mtbDateLeft.Enabled = false;
            this.mtbDateLeft.Location = new System.Drawing.Point(381, 354);
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
            this.lblDateLeft.Location = new System.Drawing.Point(303, 358);
            this.lblDateLeft.Name = "lblDateLeft";
            this.lblDateLeft.Size = new System.Drawing.Size(70, 17);
            this.lblDateLeft.TabIndex = 58;
            this.lblDateLeft.Text = "Date Left:";
            // 
            // mtbDateJoined
            // 
            this.mtbDateJoined.Enabled = false;
            this.mtbDateJoined.Location = new System.Drawing.Point(140, 354);
            this.mtbDateJoined.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbDateJoined.Mask = "00/00/0000";
            this.mtbDateJoined.Name = "mtbDateJoined";
            this.mtbDateJoined.Size = new System.Drawing.Size(120, 22);
            this.mtbDateJoined.TabIndex = 57;
            this.mtbDateJoined.ValidatingType = typeof(System.DateTime);
            // 
            // txtDateJoined
            // 
            this.txtDateJoined.AutoSize = true;
            this.txtDateJoined.Location = new System.Drawing.Point(44, 358);
            this.txtDateJoined.Name = "txtDateJoined";
            this.txtDateJoined.Size = new System.Drawing.Size(88, 17);
            this.txtDateJoined.TabIndex = 56;
            this.txtDateJoined.Text = "Date Joined:";
            // 
            // cbxCurrentTutor
            // 
            this.cbxCurrentTutor.AutoSize = true;
            this.cbxCurrentTutor.Location = new System.Drawing.Point(140, 326);
            this.cbxCurrentTutor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCurrentTutor.Name = "cbxCurrentTutor";
            this.cbxCurrentTutor.Size = new System.Drawing.Size(123, 21);
            this.cbxCurrentTutor.TabIndex = 55;
            this.cbxCurrentTutor.Text = "Current Tutor?";
            this.cbxCurrentTutor.UseVisualStyleBackColor = true;
            this.cbxCurrentTutor.CheckedChanged += new System.EventHandler(this.cbxCurrentTutor_CheckedChanged);
            // 
            // cbxDisability
            // 
            this.cbxDisability.AutoSize = true;
            this.cbxDisability.Location = new System.Drawing.Point(140, 298);
            this.cbxDisability.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxDisability.Name = "cbxDisability";
            this.cbxDisability.Size = new System.Drawing.Size(94, 21);
            this.cbxDisability.TabIndex = 54;
            this.cbxDisability.Text = "Disability?";
            this.cbxDisability.UseVisualStyleBackColor = true;
            // 
            // mtbDOB
            // 
            this.mtbDOB.Location = new System.Drawing.Point(140, 204);
            this.mtbDOB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbDOB.Mask = "00/00/0000";
            this.mtbDOB.Name = "mtbDOB";
            this.mtbDOB.Size = new System.Drawing.Size(120, 22);
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
            this.cboGender.Location = new System.Drawing.Point(140, 265);
            this.cboGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(120, 24);
            this.cboGender.TabIndex = 52;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(73, 268);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 17);
            this.lblGender.TabIndex = 51;
            this.lblGender.Text = "Gender:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(140, 55);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(417, 22);
            this.txtSurname.TabIndex = 5;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(63, 59);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(69, 17);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Surname:";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(140, 116);
            this.txtTown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(416, 22);
            this.txtTown.TabIndex = 42;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(85, 119);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(46, 17);
            this.lblTown.TabIndex = 41;
            this.lblTown.Text = "Town:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(91, 208);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(42, 17);
            this.lblDOB.TabIndex = 46;
            this.lblDOB.Text = "DOB:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(140, 23);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(417, 22);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(63, 27);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(78, 17);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First name:";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(56, 149);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(77, 17);
            this.lblPostCode.TabIndex = 43;
            this.lblPostCode.Text = "Post Code:";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(76, 238);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(54, 17);
            this.lblTelNo.TabIndex = 30;
            this.lblTelNo.Text = "Tel No:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(140, 175);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(416, 22);
            this.txtEmail.TabIndex = 37;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(140, 86);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(416, 22);
            this.txtAddress.TabIndex = 40;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(71, 90);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 39;
            this.lblAddress.Text = "Address:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(35, 178);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(101, 17);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Email address:";
            // 
            // gbxTools
            // 
            this.gbxTools.Controls.Add(this.btnClear);
            this.gbxTools.Controls.Add(this.btnProficiencies);
            this.gbxTools.Controls.Add(this.btnCreate);
            this.gbxTools.Controls.Add(this.btnUpdate);
            this.gbxTools.Controls.Add(this.btnDelete);
            this.gbxTools.Location = new System.Drawing.Point(1045, 235);
            this.gbxTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTools.Name = "gbxTools";
            this.gbxTools.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTools.Size = new System.Drawing.Size(224, 202);
            this.gbxTools.TabIndex = 10;
            this.gbxTools.TabStop = false;
            this.gbxTools.Text = "Tools";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(8, 130);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(208, 28);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "&Add new record";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnProficiencies
            // 
            this.btnProficiencies.Location = new System.Drawing.Point(8, 167);
            this.btnProficiencies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProficiencies.Name = "btnProficiencies";
            this.btnProficiencies.Size = new System.Drawing.Size(208, 28);
            this.btnProficiencies.TabIndex = 8;
            this.btnProficiencies.Text = "&Proficiencies";
            this.btnProficiencies.UseVisualStyleBackColor = true;
            this.btnProficiencies.Click += new System.EventHandler(this.btnProficiencies_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(8, 23);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(208, 28);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "&Update";
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
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvTutor
            // 
            this.dgvTutor.AllowUserToAddRows = false;
            this.dgvTutor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvTutor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTutor.Location = new System.Drawing.Point(16, 444);
            this.dgvTutor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTutor.Name = "dgvTutor";
            this.dgvTutor.ReadOnly = true;
            this.dgvTutor.Size = new System.Drawing.Size(1253, 336);
            this.dgvTutor.TabIndex = 9;
            this.dgvTutor.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTutor_CellEnter);
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
            this.gbxSearch.Location = new System.Drawing.Point(593, 298);
            this.gbxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxSearch.Size = new System.Drawing.Size(445, 139);
            this.gbxSearch.TabIndex = 12;
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
            // frmTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 793);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxTutorProperties);
            this.Controls.Add(this.gbxTools);
            this.Controls.Add(this.dgvTutor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTutor";
            this.Text = "Modify Tutors";
            this.Load += new System.EventHandler(this.frmTutor_Load);
            this.gbxTutorProperties.ResumeLayout(false);
            this.gbxTutorProperties.PerformLayout();
            this.gbxTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrP)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTutorProperties;
        private System.Windows.Forms.TextBox txtNextOfKinName;
        private System.Windows.Forms.Label lblNextOfKinName;
        private System.Windows.Forms.MaskedTextBox mtbDateLeft;
        private System.Windows.Forms.Label lblDateLeft;
        private System.Windows.Forms.MaskedTextBox mtbDateJoined;
        private System.Windows.Forms.Label txtDateJoined;
        private System.Windows.Forms.CheckBox cbxCurrentTutor;
        private System.Windows.Forms.CheckBox cbxDisability;
        private System.Windows.Forms.MaskedTextBox mtbDOB;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox gbxTools;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvTutor;
        private System.Windows.Forms.ErrorProvider ErrP;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cboCollumnTitles;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblSearchFor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnProficiencies;
        private System.Windows.Forms.MaskedTextBox mtbPostCode;
        private System.Windows.Forms.MaskedTextBox mtbTelNo;
        private System.Windows.Forms.Button btnClear;
    }
}