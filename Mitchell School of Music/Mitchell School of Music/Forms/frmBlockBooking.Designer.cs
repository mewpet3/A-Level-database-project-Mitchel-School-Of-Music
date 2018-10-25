namespace Mitchell_School_of_Music
{
    partial class frmBlockBooking
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
            this.gbxBookingProperties = new System.Windows.Forms.GroupBox();
            this.lblConcessionaryDiscount = new System.Windows.Forms.Label();
            this.cboAbilityLevel = new System.Windows.Forms.ComboBox();
            this.lblAbilityLevel = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblNoLessons = new System.Windows.Forms.Label();
            this.cboTuitionChoice = new System.Windows.Forms.ComboBox();
            this.nudNoLessons = new System.Windows.Forms.NumericUpDown();
            this.lblTuitionChoice = new System.Windows.Forms.Label();
            this.txtStudentData = new System.Windows.Forms.TextBox();
            this.cboStudentNo = new System.Windows.Forms.ComboBox();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.dgvBlockBooking = new System.Windows.Forms.DataGridView();
            this.gbxTools = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ErrP = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboCollumnTitles = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbxPaymentDetails = new System.Windows.Forms.GroupBox();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.lblDiscountRate = new System.Windows.Forms.Label();
            this.lblPricePerLesson = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.gbxBookingProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoLessons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlockBooking)).BeginInit();
            this.gbxTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrP)).BeginInit();
            this.gbxSearch.SuspendLayout();
            this.gbxPaymentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBookingProperties
            // 
            this.gbxBookingProperties.Controls.Add(this.lblConcessionaryDiscount);
            this.gbxBookingProperties.Controls.Add(this.cboAbilityLevel);
            this.gbxBookingProperties.Controls.Add(this.lblAbilityLevel);
            this.gbxBookingProperties.Controls.Add(this.lblAvailable);
            this.gbxBookingProperties.Controls.Add(this.lblNoLessons);
            this.gbxBookingProperties.Controls.Add(this.cboTuitionChoice);
            this.gbxBookingProperties.Controls.Add(this.nudNoLessons);
            this.gbxBookingProperties.Controls.Add(this.lblTuitionChoice);
            this.gbxBookingProperties.Controls.Add(this.txtStudentData);
            this.gbxBookingProperties.Controls.Add(this.cboStudentNo);
            this.gbxBookingProperties.Controls.Add(this.lblStudentNo);
            this.gbxBookingProperties.Location = new System.Drawing.Point(16, 15);
            this.gbxBookingProperties.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxBookingProperties.Name = "gbxBookingProperties";
            this.gbxBookingProperties.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxBookingProperties.Size = new System.Drawing.Size(555, 290);
            this.gbxBookingProperties.TabIndex = 11;
            this.gbxBookingProperties.TabStop = false;
            this.gbxBookingProperties.Text = "Booking properties";
            // 
            // lblConcessionaryDiscount
            // 
            this.lblConcessionaryDiscount.AutoSize = true;
            this.lblConcessionaryDiscount.Location = new System.Drawing.Point(277, 27);
            this.lblConcessionaryDiscount.Name = "lblConcessionaryDiscount";
            this.lblConcessionaryDiscount.Size = new System.Drawing.Size(166, 17);
            this.lblConcessionaryDiscount.TabIndex = 83;
            this.lblConcessionaryDiscount.Text = "Concessionary discount: ";
            // 
            // cboAbilityLevel
            // 
            this.cboAbilityLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAbilityLevel.FormattingEnabled = true;
            this.cboAbilityLevel.Items.AddRange(new object[] {
            "B",
            "I",
            "A",
            "D"});
            this.cboAbilityLevel.Location = new System.Drawing.Point(356, 204);
            this.cboAbilityLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboAbilityLevel.Name = "cboAbilityLevel";
            this.cboAbilityLevel.Size = new System.Drawing.Size(67, 24);
            this.cboAbilityLevel.TabIndex = 82;
            this.cboAbilityLevel.SelectedIndexChanged += new System.EventHandler(this.cboAbilityLevel_SelectedIndexChanged);
            // 
            // lblAbilityLevel
            // 
            this.lblAbilityLevel.AutoSize = true;
            this.lblAbilityLevel.Location = new System.Drawing.Point(277, 207);
            this.lblAbilityLevel.Name = "lblAbilityLevel";
            this.lblAbilityLevel.Size = new System.Drawing.Size(82, 17);
            this.lblAbilityLevel.TabIndex = 81;
            this.lblAbilityLevel.Text = "Ability level:";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(257, 263);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(119, 17);
            this.lblAvailable.TabIndex = 80;
            this.lblAvailable.Text = "Choice available: ";
            // 
            // lblNoLessons
            // 
            this.lblNoLessons.AutoSize = true;
            this.lblNoLessons.Location = new System.Drawing.Point(353, 58);
            this.lblNoLessons.Name = "lblNoLessons";
            this.lblNoLessons.Size = new System.Drawing.Size(130, 17);
            this.lblNoLessons.TabIndex = 77;
            this.lblNoLessons.Text = "Number of lessons:";
            // 
            // cboTuitionChoice
            // 
            this.cboTuitionChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTuitionChoice.FormattingEnabled = true;
            this.cboTuitionChoice.Location = new System.Drawing.Point(356, 236);
            this.cboTuitionChoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTuitionChoice.Name = "cboTuitionChoice";
            this.cboTuitionChoice.Size = new System.Drawing.Size(191, 24);
            this.cboTuitionChoice.TabIndex = 79;
            this.cboTuitionChoice.SelectedIndexChanged += new System.EventHandler(this.cboTuitionChoice_SelectedIndexChanged);
            // 
            // nudNoLessons
            // 
            this.nudNoLessons.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNoLessons.Location = new System.Drawing.Point(489, 57);
            this.nudNoLessons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudNoLessons.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudNoLessons.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNoLessons.Name = "nudNoLessons";
            this.nudNoLessons.Size = new System.Drawing.Size(57, 22);
            this.nudNoLessons.TabIndex = 76;
            this.nudNoLessons.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNoLessons.ValueChanged += new System.EventHandler(this.nudNoLessons_ValueChanged);
            // 
            // lblTuitionChoice
            // 
            this.lblTuitionChoice.AutoSize = true;
            this.lblTuitionChoice.Location = new System.Drawing.Point(257, 240);
            this.lblTuitionChoice.Name = "lblTuitionChoice";
            this.lblTuitionChoice.Size = new System.Drawing.Size(102, 17);
            this.lblTuitionChoice.TabIndex = 78;
            this.lblTuitionChoice.Text = "Tuition Choice:";
            // 
            // txtStudentData
            // 
            this.txtStudentData.Location = new System.Drawing.Point(7, 63);
            this.txtStudentData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentData.Multiline = true;
            this.txtStudentData.Name = "txtStudentData";
            this.txtStudentData.ReadOnly = true;
            this.txtStudentData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStudentData.Size = new System.Drawing.Size(245, 213);
            this.txtStudentData.TabIndex = 75;
            // 
            // cboStudentNo
            // 
            this.cboStudentNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStudentNo.FormattingEnabled = true;
            this.cboStudentNo.Location = new System.Drawing.Point(92, 23);
            this.cboStudentNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboStudentNo.Name = "cboStudentNo";
            this.cboStudentNo.Size = new System.Drawing.Size(160, 24);
            this.cboStudentNo.TabIndex = 72;
            this.cboStudentNo.SelectedIndexChanged += new System.EventHandler(this.cboStudentNo_SelectedIndexChanged);
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Location = new System.Drawing.Point(4, 27);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(79, 17);
            this.lblStudentNo.TabIndex = 71;
            this.lblStudentNo.Text = "StudentNo:";
            // 
            // dgvBlockBooking
            // 
            this.dgvBlockBooking.AllowUserToAddRows = false;
            this.dgvBlockBooking.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvBlockBooking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBlockBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlockBooking.Location = new System.Drawing.Point(13, 313);
            this.dgvBlockBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBlockBooking.Name = "dgvBlockBooking";
            this.dgvBlockBooking.ReadOnly = true;
            this.dgvBlockBooking.Size = new System.Drawing.Size(1243, 336);
            this.dgvBlockBooking.TabIndex = 9;
            this.dgvBlockBooking.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBlockBooking_CellEnter);
            // 
            // gbxTools
            // 
            this.gbxTools.Controls.Add(this.btnClear);
            this.gbxTools.Controls.Add(this.btnPay);
            this.gbxTools.Controls.Add(this.btnCreate);
            this.gbxTools.Controls.Add(this.btnUpdate);
            this.gbxTools.Controls.Add(this.btnDelete);
            this.gbxTools.Location = new System.Drawing.Point(1031, 15);
            this.gbxTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTools.Name = "gbxTools";
            this.gbxTools.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTools.Size = new System.Drawing.Size(224, 204);
            this.gbxTools.TabIndex = 63;
            this.gbxTools.TabStop = false;
            this.gbxTools.Text = "Tools";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(8, 130);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(208, 28);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "&Add new record";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPay
            // 
            this.btnPay.Enabled = false;
            this.btnPay.Location = new System.Drawing.Point(8, 166);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(208, 28);
            this.btnPay.TabIndex = 8;
            this.btnPay.Text = "&Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
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
            this.gbxSearch.Location = new System.Drawing.Point(579, 15);
            this.gbxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxSearch.Size = new System.Drawing.Size(445, 137);
            this.gbxSearch.TabIndex = 64;
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
            // gbxPaymentDetails
            // 
            this.gbxPaymentDetails.Controls.Add(this.lblFinalPrice);
            this.gbxPaymentDetails.Controls.Add(this.lblDiscountRate);
            this.gbxPaymentDetails.Controls.Add(this.lblPricePerLesson);
            this.gbxPaymentDetails.Controls.Add(this.lblTotalPrice);
            this.gbxPaymentDetails.Location = new System.Drawing.Point(579, 160);
            this.gbxPaymentDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxPaymentDetails.Name = "gbxPaymentDetails";
            this.gbxPaymentDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxPaymentDetails.Size = new System.Drawing.Size(445, 145);
            this.gbxPaymentDetails.TabIndex = 83;
            this.gbxPaymentDetails.TabStop = false;
            this.gbxPaymentDetails.Text = "Payment details";
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Location = new System.Drawing.Point(7, 98);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(77, 17);
            this.lblFinalPrice.TabIndex = 86;
            this.lblFinalPrice.Text = "Final price:";
            // 
            // lblDiscountRate
            // 
            this.lblDiscountRate.AutoSize = true;
            this.lblDiscountRate.Location = new System.Drawing.Point(7, 25);
            this.lblDiscountRate.Name = "lblDiscountRate";
            this.lblDiscountRate.Size = new System.Drawing.Size(96, 17);
            this.lblDiscountRate.TabIndex = 85;
            this.lblDiscountRate.Text = "Discount rate:";
            // 
            // lblPricePerLesson
            // 
            this.lblPricePerLesson.AutoSize = true;
            this.lblPricePerLesson.Location = new System.Drawing.Point(7, 42);
            this.lblPricePerLesson.Name = "lblPricePerLesson";
            this.lblPricePerLesson.Size = new System.Drawing.Size(114, 17);
            this.lblPricePerLesson.TabIndex = 84;
            this.lblPricePerLesson.Text = "Price per lesson:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(7, 59);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(79, 17);
            this.lblTotalPrice.TabIndex = 83;
            this.lblTotalPrice.Text = "Total price:";
            // 
            // frmBlockBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 661);
            this.Controls.Add(this.gbxPaymentDetails);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxTools);
            this.Controls.Add(this.gbxBookingProperties);
            this.Controls.Add(this.dgvBlockBooking);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBlockBooking";
            this.Text = "Modify Bookings";
            this.Load += new System.EventHandler(this.frmBlockBooking_Load);
            this.gbxBookingProperties.ResumeLayout(false);
            this.gbxBookingProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoLessons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlockBooking)).EndInit();
            this.gbxTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrP)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxPaymentDetails.ResumeLayout(false);
            this.gbxPaymentDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBookingProperties;
        private System.Windows.Forms.DataGridView dgvBlockBooking;
        private System.Windows.Forms.TextBox txtStudentData;
        private System.Windows.Forms.ComboBox cboStudentNo;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.Label lblNoLessons;
        private System.Windows.Forms.NumericUpDown nudNoLessons;
        private System.Windows.Forms.GroupBox gbxTools;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ErrorProvider ErrP;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cboCollumnTitles;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblSearchFor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.ComboBox cboTuitionChoice;
        private System.Windows.Forms.Label lblTuitionChoice;
        private System.Windows.Forms.ComboBox cboAbilityLevel;
        private System.Windows.Forms.Label lblAbilityLevel;
        private System.Windows.Forms.GroupBox gbxPaymentDetails;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.Label lblDiscountRate;
        private System.Windows.Forms.Label lblPricePerLesson;
        private System.Windows.Forms.Label lblConcessionaryDiscount;
        private System.Windows.Forms.Button btnClear;
    }
}