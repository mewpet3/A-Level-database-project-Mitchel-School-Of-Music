namespace Mitchell_School_of_Music
{
    partial class frmTimetabledLesson
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
            this.btnReset = new System.Windows.Forms.Button();
            this.cboCollumnTitles = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.ErrP = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.dgvTimetabledLessons = new System.Windows.Forms.DataGridView();
            this.txtStudentData = new System.Windows.Forms.TextBox();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.gbxBookingProperties = new System.Windows.Forms.GroupBox();
            this.lblPeriodLesson = new System.Windows.Forms.Label();
            this.nudLessonPeriod = new System.Windows.Forms.NumericUpDown();
            this.lblLessonDateTime = new System.Windows.Forms.Label();
            this.dtpLessonDateTime = new System.Windows.Forms.DateTimePicker();
            this.txtRoomData = new System.Windows.Forms.TextBox();
            this.cboRoomNo = new System.Windows.Forms.ComboBox();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.cboStudentNo = new System.Windows.Forms.ComboBox();
            this.txtBookingData = new System.Windows.Forms.TextBox();
            this.cboBookingNo = new System.Windows.Forms.ComboBox();
            this.lblBookingNo = new System.Windows.Forms.Label();
            this.txtTutorData = new System.Windows.Forms.TextBox();
            this.cboTutorNo = new System.Windows.Forms.ComboBox();
            this.lblTutorNo = new System.Windows.Forms.Label();
            this.gbxModifiers = new System.Windows.Forms.GroupBox();
            this.txtCancellationReason = new System.Windows.Forms.TextBox();
            this.cbxCancellation = new System.Windows.Forms.CheckBox();
            this.cbxStudentPresent = new System.Windows.Forms.CheckBox();
            this.lblRowsNo = new System.Windows.Forms.Label();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrP)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetabledLessons)).BeginInit();
            this.gbxBookingProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLessonPeriod)).BeginInit();
            this.gbxModifiers.SuspendLayout();
            this.SuspendLayout();
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
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.btnReset);
            this.gbxSearch.Controls.Add(this.cboCollumnTitles);
            this.gbxSearch.Controls.Add(this.txtSearch);
            this.gbxSearch.Controls.Add(this.lblIn);
            this.gbxSearch.Controls.Add(this.lblSearchFor);
            this.gbxSearch.Controls.Add(this.btnSearch);
            this.gbxSearch.Location = new System.Drawing.Point(411, 333);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(334, 111);
            this.gbxSearch.TabIndex = 68;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search";
            // 
            // ErrP
            // 
            this.ErrP.ContainerControl = this;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(6, 19);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(156, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "&Create new lesson set";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 48);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(156, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "&Update selected row";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 77);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "&Delete data row";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImport);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(752, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 136);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(6, 106);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(156, 23);
            this.btnImport.TabIndex = 8;
            this.btnImport.Text = "&Import data from row";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // dgvTimetabledLessons
            // 
            this.dgvTimetabledLessons.AllowUserToAddRows = false;
            this.dgvTimetabledLessons.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvTimetabledLessons.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTimetabledLessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimetabledLessons.Location = new System.Drawing.Point(10, 451);
            this.dgvTimetabledLessons.Name = "dgvTimetabledLessons";
            this.dgvTimetabledLessons.ReadOnly = true;
            this.dgvTimetabledLessons.Size = new System.Drawing.Size(909, 148);
            this.dgvTimetabledLessons.TabIndex = 65;
            this.dgvTimetabledLessons.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimetabledLessons_CellEnter);
            // 
            // txtStudentData
            // 
            this.txtStudentData.Location = new System.Drawing.Point(251, 44);
            this.txtStudentData.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentData.Multiline = true;
            this.txtStudentData.Name = "txtStudentData";
            this.txtStudentData.ReadOnly = true;
            this.txtStudentData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStudentData.Size = new System.Drawing.Size(252, 163);
            this.txtStudentData.TabIndex = 75;
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Location = new System.Drawing.Point(262, 22);
            this.lblStudentNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(61, 13);
            this.lblStudentNo.TabIndex = 71;
            this.lblStudentNo.Text = "StudentNo:";
            // 
            // gbxBookingProperties
            // 
            this.gbxBookingProperties.Controls.Add(this.lblPeriodLesson);
            this.gbxBookingProperties.Controls.Add(this.nudLessonPeriod);
            this.gbxBookingProperties.Controls.Add(this.lblLessonDateTime);
            this.gbxBookingProperties.Controls.Add(this.dtpLessonDateTime);
            this.gbxBookingProperties.Controls.Add(this.txtRoomData);
            this.gbxBookingProperties.Controls.Add(this.cboRoomNo);
            this.gbxBookingProperties.Controls.Add(this.lblRoomNo);
            this.gbxBookingProperties.Controls.Add(this.txtStudentData);
            this.gbxBookingProperties.Controls.Add(this.cboStudentNo);
            this.gbxBookingProperties.Controls.Add(this.lblStudentNo);
            this.gbxBookingProperties.Controls.Add(this.txtBookingData);
            this.gbxBookingProperties.Controls.Add(this.cboBookingNo);
            this.gbxBookingProperties.Controls.Add(this.lblBookingNo);
            this.gbxBookingProperties.Controls.Add(this.txtTutorData);
            this.gbxBookingProperties.Controls.Add(this.cboTutorNo);
            this.gbxBookingProperties.Controls.Add(this.lblTutorNo);
            this.gbxBookingProperties.Location = new System.Drawing.Point(10, 11);
            this.gbxBookingProperties.Name = "gbxBookingProperties";
            this.gbxBookingProperties.Size = new System.Drawing.Size(910, 259);
            this.gbxBookingProperties.TabIndex = 66;
            this.gbxBookingProperties.TabStop = false;
            this.gbxBookingProperties.Text = "Booking properties";
            // 
            // lblPeriodLesson
            // 
            this.lblPeriodLesson.AutoSize = true;
            this.lblPeriodLesson.Location = new System.Drawing.Point(320, 225);
            this.lblPeriodLesson.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeriodLesson.Name = "lblPeriodLesson";
            this.lblPeriodLesson.Size = new System.Drawing.Size(77, 13);
            this.lblPeriodLesson.TabIndex = 88;
            this.lblPeriodLesson.Text = "Lesson Period:";
            // 
            // nudLessonPeriod
            // 
            this.nudLessonPeriod.Location = new System.Drawing.Point(401, 223);
            this.nudLessonPeriod.Margin = new System.Windows.Forms.Padding(2);
            this.nudLessonPeriod.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudLessonPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLessonPeriod.Name = "nudLessonPeriod";
            this.nudLessonPeriod.Size = new System.Drawing.Size(34, 20);
            this.nudLessonPeriod.TabIndex = 87;
            this.nudLessonPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLessonDateTime
            // 
            this.lblLessonDateTime.AutoSize = true;
            this.lblLessonDateTime.Location = new System.Drawing.Point(11, 225);
            this.lblLessonDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLessonDateTime.Name = "lblLessonDateTime";
            this.lblLessonDateTime.Size = new System.Drawing.Size(111, 13);
            this.lblLessonDateTime.TabIndex = 86;
            this.lblLessonDateTime.Text = "Lesson date and time:";
            // 
            // dtpLessonDateTime
            // 
            this.dtpLessonDateTime.Location = new System.Drawing.Point(127, 223);
            this.dtpLessonDateTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpLessonDateTime.Name = "dtpLessonDateTime";
            this.dtpLessonDateTime.Size = new System.Drawing.Size(120, 20);
            this.dtpLessonDateTime.TabIndex = 85;
            this.dtpLessonDateTime.Value = new System.DateTime(2016, 11, 18, 0, 0, 0, 0);
            this.dtpLessonDateTime.ValueChanged += new System.EventHandler(this.dtpLessonDateTime_ValueChanged);
            // 
            // txtRoomData
            // 
            this.txtRoomData.Location = new System.Drawing.Point(763, 44);
            this.txtRoomData.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoomData.Multiline = true;
            this.txtRoomData.Name = "txtRoomData";
            this.txtRoomData.ReadOnly = true;
            this.txtRoomData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRoomData.Size = new System.Drawing.Size(129, 163);
            this.txtRoomData.TabIndex = 81;
            // 
            // cboRoomNo
            // 
            this.cboRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomNo.Enabled = false;
            this.cboRoomNo.FormattingEnabled = true;
            this.cboRoomNo.Location = new System.Drawing.Point(816, 20);
            this.cboRoomNo.Name = "cboRoomNo";
            this.cboRoomNo.Size = new System.Drawing.Size(60, 21);
            this.cboRoomNo.TabIndex = 80;
            this.cboRoomNo.SelectedIndexChanged += new System.EventHandler(this.cboRoomNo_SelectedIndexChanged);
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Location = new System.Drawing.Point(760, 23);
            this.lblRoomNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(52, 13);
            this.lblRoomNo.TabIndex = 79;
            this.lblRoomNo.Text = "RoomNo:";
            // 
            // cboStudentNo
            // 
            this.cboStudentNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStudentNo.Enabled = false;
            this.cboStudentNo.FormattingEnabled = true;
            this.cboStudentNo.Location = new System.Drawing.Point(327, 20);
            this.cboStudentNo.Name = "cboStudentNo";
            this.cboStudentNo.Size = new System.Drawing.Size(76, 21);
            this.cboStudentNo.TabIndex = 72;
            this.cboStudentNo.SelectedIndexChanged += new System.EventHandler(this.cboStudentNo_SelectedIndexChanged);
            // 
            // txtBookingData
            // 
            this.txtBookingData.Location = new System.Drawing.Point(20, 44);
            this.txtBookingData.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookingData.Multiline = true;
            this.txtBookingData.Name = "txtBookingData";
            this.txtBookingData.ReadOnly = true;
            this.txtBookingData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBookingData.Size = new System.Drawing.Size(227, 163);
            this.txtBookingData.TabIndex = 84;
            // 
            // cboBookingNo
            // 
            this.cboBookingNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookingNo.FormattingEnabled = true;
            this.cboBookingNo.Location = new System.Drawing.Point(84, 20);
            this.cboBookingNo.Name = "cboBookingNo";
            this.cboBookingNo.Size = new System.Drawing.Size(76, 21);
            this.cboBookingNo.TabIndex = 83;
            this.cboBookingNo.SelectedIndexChanged += new System.EventHandler(this.cboBookingNo_SelectedIndexChanged);
            // 
            // lblBookingNo
            // 
            this.lblBookingNo.AutoSize = true;
            this.lblBookingNo.Location = new System.Drawing.Point(18, 22);
            this.lblBookingNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookingNo.Name = "lblBookingNo";
            this.lblBookingNo.Size = new System.Drawing.Size(63, 13);
            this.lblBookingNo.TabIndex = 82;
            this.lblBookingNo.Text = "BookingNo:";
            // 
            // txtTutorData
            // 
            this.txtTutorData.Location = new System.Drawing.Point(507, 44);
            this.txtTutorData.Margin = new System.Windows.Forms.Padding(2);
            this.txtTutorData.Multiline = true;
            this.txtTutorData.Name = "txtTutorData";
            this.txtTutorData.ReadOnly = true;
            this.txtTutorData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTutorData.Size = new System.Drawing.Size(252, 163);
            this.txtTutorData.TabIndex = 78;
            // 
            // cboTutorNo
            // 
            this.cboTutorNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTutorNo.Enabled = false;
            this.cboTutorNo.FormattingEnabled = true;
            this.cboTutorNo.Location = new System.Drawing.Point(571, 20);
            this.cboTutorNo.Name = "cboTutorNo";
            this.cboTutorNo.Size = new System.Drawing.Size(76, 21);
            this.cboTutorNo.TabIndex = 77;
            this.cboTutorNo.SelectedIndexChanged += new System.EventHandler(this.cboTutorNo_SelectedIndexChanged);
            // 
            // lblTutorNo
            // 
            this.lblTutorNo.AutoSize = true;
            this.lblTutorNo.Location = new System.Drawing.Point(518, 22);
            this.lblTutorNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTutorNo.Name = "lblTutorNo";
            this.lblTutorNo.Size = new System.Drawing.Size(49, 13);
            this.lblTutorNo.TabIndex = 76;
            this.lblTutorNo.Text = "TutorNo:";
            // 
            // gbxModifiers
            // 
            this.gbxModifiers.Controls.Add(this.txtCancellationReason);
            this.gbxModifiers.Controls.Add(this.cbxCancellation);
            this.gbxModifiers.Controls.Add(this.cbxStudentPresent);
            this.gbxModifiers.Location = new System.Drawing.Point(10, 276);
            this.gbxModifiers.Margin = new System.Windows.Forms.Padding(2);
            this.gbxModifiers.Name = "gbxModifiers";
            this.gbxModifiers.Padding = new System.Windows.Forms.Padding(2);
            this.gbxModifiers.Size = new System.Drawing.Size(396, 169);
            this.gbxModifiers.TabIndex = 69;
            this.gbxModifiers.TabStop = false;
            this.gbxModifiers.Text = "Modifiers";
            this.gbxModifiers.Visible = false;
            // 
            // txtCancellationReason
            // 
            this.txtCancellationReason.Enabled = false;
            this.txtCancellationReason.Location = new System.Drawing.Point(4, 60);
            this.txtCancellationReason.Margin = new System.Windows.Forms.Padding(2);
            this.txtCancellationReason.Multiline = true;
            this.txtCancellationReason.Name = "txtCancellationReason";
            this.txtCancellationReason.Size = new System.Drawing.Size(370, 104);
            this.txtCancellationReason.TabIndex = 87;
            // 
            // cbxCancellation
            // 
            this.cbxCancellation.AutoSize = true;
            this.cbxCancellation.Location = new System.Drawing.Point(4, 39);
            this.cbxCancellation.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCancellation.Name = "cbxCancellation";
            this.cbxCancellation.Size = new System.Drawing.Size(110, 17);
            this.cbxCancellation.TabIndex = 1;
            this.cbxCancellation.Text = "Lesson Cancelled";
            this.cbxCancellation.UseVisualStyleBackColor = true;
            this.cbxCancellation.CheckedChanged += new System.EventHandler(this.cbxCancellation_CheckedChanged);
            // 
            // cbxStudentPresent
            // 
            this.cbxStudentPresent.AutoSize = true;
            this.cbxStudentPresent.Location = new System.Drawing.Point(4, 17);
            this.cbxStudentPresent.Margin = new System.Windows.Forms.Padding(2);
            this.cbxStudentPresent.Name = "cbxStudentPresent";
            this.cbxStudentPresent.Size = new System.Drawing.Size(102, 17);
            this.cbxStudentPresent.TabIndex = 0;
            this.cbxStudentPresent.Text = "Student Present";
            this.cbxStudentPresent.UseVisualStyleBackColor = true;
            // 
            // lblRowsNo
            // 
            this.lblRowsNo.AutoSize = true;
            this.lblRowsNo.Location = new System.Drawing.Point(8, 602);
            this.lblRowsNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRowsNo.Name = "lblRowsNo";
            this.lblRowsNo.Size = new System.Drawing.Size(148, 13);
            this.lblRowsNo.TabIndex = 70;
            this.lblRowsNo.Text = "Number of timetabled lessons:";
            // 
            // frmTimetabledLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 621);
            this.Controls.Add(this.lblRowsNo);
            this.Controls.Add(this.gbxModifiers);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTimetabledLessons);
            this.Controls.Add(this.gbxBookingProperties);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmTimetabledLesson";
            this.Text = "Modify Lessons";
            this.Load += new System.EventHandler(this.TimetabledLesson_Load);
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetabledLessons)).EndInit();
            this.gbxBookingProperties.ResumeLayout(false);
            this.gbxBookingProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLessonPeriod)).EndInit();
            this.gbxModifiers.ResumeLayout(false);
            this.gbxModifiers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cboCollumnTitles;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblSearchFor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.ErrorProvider ErrP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvTimetabledLessons;
        private System.Windows.Forms.GroupBox gbxBookingProperties;
        private System.Windows.Forms.TextBox txtStudentData;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.TextBox txtTutorData;
        private System.Windows.Forms.ComboBox cboTutorNo;
        private System.Windows.Forms.Label lblTutorNo;
        private System.Windows.Forms.TextBox txtRoomData;
        private System.Windows.Forms.ComboBox cboRoomNo;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.TextBox txtBookingData;
        private System.Windows.Forms.ComboBox cboBookingNo;
        private System.Windows.Forms.Label lblBookingNo;
        private System.Windows.Forms.GroupBox gbxModifiers;
        private System.Windows.Forms.TextBox txtCancellationReason;
        private System.Windows.Forms.CheckBox cbxCancellation;
        private System.Windows.Forms.CheckBox cbxStudentPresent;
        private System.Windows.Forms.Label lblLessonDateTime;
        private System.Windows.Forms.DateTimePicker dtpLessonDateTime;
        private System.Windows.Forms.Label lblPeriodLesson;
        private System.Windows.Forms.NumericUpDown nudLessonPeriod;
        private System.Windows.Forms.Label lblRowsNo;
        private System.Windows.Forms.ComboBox cboStudentNo;
        private System.Windows.Forms.Button btnImport;
    }
}