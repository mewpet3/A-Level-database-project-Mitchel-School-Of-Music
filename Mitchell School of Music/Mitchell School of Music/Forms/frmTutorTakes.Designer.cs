namespace Mitchell_School_of_Music
{
    partial class frmTutorTakes
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
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboCollumnTitles = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbxTutorProperties = new System.Windows.Forms.GroupBox();
            this.txtTutorNo = new System.Windows.Forms.TextBox();
            this.cboTeachUpTo = new System.Windows.Forms.ComboBox();
            this.lblTeachUpTo = new System.Windows.Forms.Label();
            this.cboTuition = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtTutorData = new System.Windows.Forms.TextBox();
            this.lblTutorNo = new System.Windows.Forms.Label();
            this.gbxTools = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvTutorTakes = new System.Windows.Forms.DataGridView();
            this.ErrP = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxSearch.SuspendLayout();
            this.gbxTutorProperties.SuspendLayout();
            this.gbxTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorTakes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrP)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.btnReset);
            this.gbxSearch.Controls.Add(this.cboCollumnTitles);
            this.gbxSearch.Controls.Add(this.txtSearch);
            this.gbxSearch.Controls.Add(this.lblIn);
            this.gbxSearch.Controls.Add(this.lblSearchFor);
            this.gbxSearch.Controls.Add(this.btnSearch);
            this.gbxSearch.Location = new System.Drawing.Point(593, 15);
            this.gbxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxSearch.Size = new System.Drawing.Size(445, 139);
            this.gbxSearch.TabIndex = 16;
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
            // gbxTutorProperties
            // 
            this.gbxTutorProperties.Controls.Add(this.txtTutorNo);
            this.gbxTutorProperties.Controls.Add(this.cboTeachUpTo);
            this.gbxTutorProperties.Controls.Add(this.lblTeachUpTo);
            this.gbxTutorProperties.Controls.Add(this.cboTuition);
            this.gbxTutorProperties.Controls.Add(this.lblSubject);
            this.gbxTutorProperties.Controls.Add(this.txtTutorData);
            this.gbxTutorProperties.Controls.Add(this.lblTutorNo);
            this.gbxTutorProperties.Location = new System.Drawing.Point(16, 15);
            this.gbxTutorProperties.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTutorProperties.Name = "gbxTutorProperties";
            this.gbxTutorProperties.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTutorProperties.Size = new System.Drawing.Size(569, 286);
            this.gbxTutorProperties.TabIndex = 15;
            this.gbxTutorProperties.TabStop = false;
            this.gbxTutorProperties.Text = "Tutor properties";
            // 
            // txtTutorNo
            // 
            this.txtTutorNo.Enabled = false;
            this.txtTutorNo.Location = new System.Drawing.Point(77, 25);
            this.txtTutorNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTutorNo.Name = "txtTutorNo";
            this.txtTutorNo.Size = new System.Drawing.Size(185, 22);
            this.txtTutorNo.TabIndex = 88;
            this.txtTutorNo.TextChanged += new System.EventHandler(this.txtTutorNo_TextChanged);
            // 
            // cboTeachUpTo
            // 
            this.cboTeachUpTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeachUpTo.FormattingEnabled = true;
            this.cboTeachUpTo.Items.AddRange(new object[] {
            "B",
            "I",
            "A",
            "D"});
            this.cboTeachUpTo.Location = new System.Drawing.Point(369, 23);
            this.cboTeachUpTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTeachUpTo.Name = "cboTeachUpTo";
            this.cboTeachUpTo.Size = new System.Drawing.Size(67, 24);
            this.cboTeachUpTo.TabIndex = 87;
            // 
            // lblTeachUpTo
            // 
            this.lblTeachUpTo.AutoSize = true;
            this.lblTeachUpTo.Location = new System.Drawing.Point(280, 27);
            this.lblTeachUpTo.Name = "lblTeachUpTo";
            this.lblTeachUpTo.Size = new System.Drawing.Size(82, 17);
            this.lblTeachUpTo.TabIndex = 86;
            this.lblTeachUpTo.Text = "Ability level:";
            // 
            // cboTuition
            // 
            this.cboTuition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTuition.FormattingEnabled = true;
            this.cboTuition.Location = new System.Drawing.Point(369, 55);
            this.cboTuition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTuition.Name = "cboTuition";
            this.cboTuition.Size = new System.Drawing.Size(191, 24);
            this.cboTuition.TabIndex = 84;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(303, 59);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(59, 17);
            this.lblSubject.TabIndex = 83;
            this.lblSubject.Text = "Subject:";
            // 
            // txtTutorData
            // 
            this.txtTutorData.Location = new System.Drawing.Point(11, 55);
            this.txtTutorData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTutorData.Multiline = true;
            this.txtTutorData.Name = "txtTutorData";
            this.txtTutorData.ReadOnly = true;
            this.txtTutorData.Size = new System.Drawing.Size(252, 224);
            this.txtTutorData.TabIndex = 81;
            // 
            // lblTutorNo
            // 
            this.lblTutorNo.AutoSize = true;
            this.lblTutorNo.Location = new System.Drawing.Point(7, 28);
            this.lblTutorNo.Name = "lblTutorNo";
            this.lblTutorNo.Size = new System.Drawing.Size(64, 17);
            this.lblTutorNo.TabIndex = 79;
            this.lblTutorNo.Text = "TutorNo:";
            // 
            // gbxTools
            // 
            this.gbxTools.Controls.Add(this.btnCreate);
            this.gbxTools.Controls.Add(this.btnUpdate);
            this.gbxTools.Controls.Add(this.btnDelete);
            this.gbxTools.Location = new System.Drawing.Point(593, 162);
            this.gbxTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTools.Name = "gbxTools";
            this.gbxTools.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTools.Size = new System.Drawing.Size(224, 138);
            this.gbxTools.TabIndex = 14;
            this.gbxTools.TabStop = false;
            this.gbxTools.Text = "Tools";
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
            this.btnUpdate.Enabled = false;
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
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(8, 95);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(208, 28);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvTutorTakes
            // 
            this.dgvTutorTakes.AllowUserToAddRows = false;
            this.dgvTutorTakes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvTutorTakes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTutorTakes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTutorTakes.Location = new System.Drawing.Point(13, 308);
            this.dgvTutorTakes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTutorTakes.Name = "dgvTutorTakes";
            this.dgvTutorTakes.ReadOnly = true;
            this.dgvTutorTakes.Size = new System.Drawing.Size(1025, 242);
            this.dgvTutorTakes.TabIndex = 13;
            this.dgvTutorTakes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTutorTakes_CellEnter);
            // 
            // ErrP
            // 
            this.ErrP.ContainerControl = this;
            // 
            // frmTutorTakes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 561);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxTutorProperties);
            this.Controls.Add(this.gbxTools);
            this.Controls.Add(this.dgvTutorTakes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTutorTakes";
            this.Text = "Modify Tutor Proficiencies";
            this.Load += new System.EventHandler(this.frmTutorTakes_Load);
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxTutorProperties.ResumeLayout(false);
            this.gbxTutorProperties.PerformLayout();
            this.gbxTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorTakes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cboCollumnTitles;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblSearchFor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbxTutorProperties;
        private System.Windows.Forms.GroupBox gbxTools;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvTutorTakes;
        private System.Windows.Forms.TextBox txtTutorData;
        private System.Windows.Forms.Label lblTutorNo;
        private System.Windows.Forms.ComboBox cboTeachUpTo;
        private System.Windows.Forms.Label lblTeachUpTo;
        private System.Windows.Forms.ComboBox cboTuition;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ErrorProvider ErrP;
        private System.Windows.Forms.TextBox txtTutorNo;
    }
}