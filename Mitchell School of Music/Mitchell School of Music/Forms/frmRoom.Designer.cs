namespace Mitchell_School_of_Music
{
    partial class frmRoom
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
            this.gbxStudentProperties = new System.Windows.Forms.GroupBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.cbxInUse = new System.Windows.Forms.CheckBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.gbxTools = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboCollumnTitles = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ErrP = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxStudentProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            this.gbxTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrP)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxStudentProperties
            // 
            this.gbxStudentProperties.Controls.Add(this.lblCapacity);
            this.gbxStudentProperties.Controls.Add(this.nudCapacity);
            this.gbxStudentProperties.Controls.Add(this.cbxInUse);
            this.gbxStudentProperties.Controls.Add(this.txtRoomType);
            this.gbxStudentProperties.Controls.Add(this.lblRoomType);
            this.gbxStudentProperties.Location = new System.Drawing.Point(16, 15);
            this.gbxStudentProperties.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxStudentProperties.Name = "gbxStudentProperties";
            this.gbxStudentProperties.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxStudentProperties.Size = new System.Drawing.Size(447, 87);
            this.gbxStudentProperties.TabIndex = 14;
            this.gbxStudentProperties.TabStop = false;
            this.gbxStudentProperties.Text = "Exam entry properties";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(44, 59);
            this.lblCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(66, 17);
            this.lblCapacity.TabIndex = 57;
            this.lblCapacity.Text = "Capacity:";
            // 
            // nudCapacity
            // 
            this.nudCapacity.Location = new System.Drawing.Point(120, 57);
            this.nudCapacity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudCapacity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCapacity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(160, 22);
            this.nudCapacity.TabIndex = 56;
            this.nudCapacity.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // cbxInUse
            // 
            this.cbxInUse.AutoSize = true;
            this.cbxInUse.Location = new System.Drawing.Point(307, 59);
            this.cbxInUse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxInUse.Name = "cbxInUse";
            this.cbxInUse.Size = new System.Drawing.Size(68, 21);
            this.cbxInUse.TabIndex = 55;
            this.cbxInUse.Text = "In use";
            this.cbxInUse.UseVisualStyleBackColor = true;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(120, 23);
            this.txtRoomType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(255, 22);
            this.txtRoomType.TabIndex = 3;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(29, 27);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(81, 17);
            this.lblRoomType.TabIndex = 2;
            this.lblRoomType.Text = "RoomType:";
            // 
            // gbxTools
            // 
            this.gbxTools.Controls.Add(this.btnClear);
            this.gbxTools.Controls.Add(this.btnCreate);
            this.gbxTools.Controls.Add(this.btnUpdate);
            this.gbxTools.Controls.Add(this.btnDelete);
            this.gbxTools.Location = new System.Drawing.Point(469, 71);
            this.gbxTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTools.Name = "gbxTools";
            this.gbxTools.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTools.Size = new System.Drawing.Size(224, 169);
            this.gbxTools.TabIndex = 13;
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
            // 
            // dgvRoom
            // 
            this.dgvRoom.AllowUserToAddRows = false;
            this.dgvRoom.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Location = new System.Drawing.Point(16, 242);
            this.dgvRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.ReadOnly = true;
            this.dgvRoom.Size = new System.Drawing.Size(677, 293);
            this.dgvRoom.TabIndex = 12;
            this.dgvRoom.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellEnter);
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.btnReset);
            this.gbxSearch.Controls.Add(this.cboCollumnTitles);
            this.gbxSearch.Controls.Add(this.txtSearch);
            this.gbxSearch.Controls.Add(this.lblIn);
            this.gbxSearch.Controls.Add(this.lblSearchFor);
            this.gbxSearch.Controls.Add(this.btnSearch);
            this.gbxSearch.Location = new System.Drawing.Point(17, 103);
            this.gbxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxSearch.Size = new System.Drawing.Size(445, 137);
            this.gbxSearch.TabIndex = 15;
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
            // ErrP
            // 
            this.ErrP.ContainerControl = this;
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 548);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxStudentProperties);
            this.Controls.Add(this.gbxTools);
            this.Controls.Add(this.dgvRoom);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRoom";
            this.Text = "Modify Rooms";
            this.Load += new System.EventHandler(this.frmRoom_Load);
            this.gbxStudentProperties.ResumeLayout(false);
            this.gbxStudentProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            this.gbxTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxStudentProperties;
        private System.Windows.Forms.GroupBox gbxTools;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.CheckBox cbxInUse;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cboCollumnTitles;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblSearchFor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ErrorProvider ErrP;
        private System.Windows.Forms.Button btnClear;
    }
}