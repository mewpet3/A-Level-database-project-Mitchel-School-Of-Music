namespace Mitchell_School_of_Music
{
    partial class frmPayment
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
            this.cboPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.gbxPayment = new System.Windows.Forms.GroupBox();
            this.gbxPaymentMethodDetails = new System.Windows.Forms.GroupBox();
            this.lblFee = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRefNo = new System.Windows.Forms.Label();
            this.gbxPaymentDetails = new System.Windows.Forms.GroupBox();
            this.lblDescriptionDisplay = new System.Windows.Forms.Label();
            this.lblFeeDisplay = new System.Windows.Forms.Label();
            this.lblRefNoDisplay = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ErrP = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxPayment.SuspendLayout();
            this.gbxPaymentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrP)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPaymentMethod
            // 
            this.cboPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentMethod.FormattingEnabled = true;
            this.cboPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Debit Card",
            "Sponsership"});
            this.cboPaymentMethod.Location = new System.Drawing.Point(102, 25);
            this.cboPaymentMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboPaymentMethod.Name = "cboPaymentMethod";
            this.cboPaymentMethod.Size = new System.Drawing.Size(92, 21);
            this.cboPaymentMethod.TabIndex = 0;
            this.cboPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cboPaymentMethod_SelectedIndexChanged);
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(9, 28);
            this.lblPaymentMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(89, 13);
            this.lblPaymentMethod.TabIndex = 1;
            this.lblPaymentMethod.Text = "Payment method:";
            // 
            // gbxPayment
            // 
            this.gbxPayment.Controls.Add(this.gbxPaymentMethodDetails);
            this.gbxPayment.Controls.Add(this.lblPaymentMethod);
            this.gbxPayment.Controls.Add(this.cboPaymentMethod);
            this.gbxPayment.Location = new System.Drawing.Point(346, 11);
            this.gbxPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxPayment.Name = "gbxPayment";
            this.gbxPayment.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxPayment.Size = new System.Drawing.Size(272, 276);
            this.gbxPayment.TabIndex = 2;
            this.gbxPayment.TabStop = false;
            this.gbxPayment.Text = "Payment";
            // 
            // gbxPaymentMethodDetails
            // 
            this.gbxPaymentMethodDetails.Location = new System.Drawing.Point(11, 61);
            this.gbxPaymentMethodDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxPaymentMethodDetails.Name = "gbxPaymentMethodDetails";
            this.gbxPaymentMethodDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxPaymentMethodDetails.Size = new System.Drawing.Size(257, 211);
            this.gbxPaymentMethodDetails.TabIndex = 0;
            this.gbxPaymentMethodDetails.TabStop = false;
            this.gbxPaymentMethodDetails.Text = "Payment method details";
            this.gbxPaymentMethodDetails.Visible = false;
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(9, 64);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(28, 13);
            this.lblFee.TabIndex = 3;
            this.lblFee.Text = "Fee:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description:";
            // 
            // lblRefNo
            // 
            this.lblRefNo.AutoSize = true;
            this.lblRefNo.Location = new System.Drawing.Point(9, 28);
            this.lblRefNo.Name = "lblRefNo";
            this.lblRefNo.Size = new System.Drawing.Size(41, 13);
            this.lblRefNo.TabIndex = 5;
            this.lblRefNo.Text = "RefNo:";
            // 
            // gbxPaymentDetails
            // 
            this.gbxPaymentDetails.Controls.Add(this.lblDescriptionDisplay);
            this.gbxPaymentDetails.Controls.Add(this.lblFeeDisplay);
            this.gbxPaymentDetails.Controls.Add(this.lblRefNoDisplay);
            this.gbxPaymentDetails.Controls.Add(this.lblFee);
            this.gbxPaymentDetails.Controls.Add(this.lblRefNo);
            this.gbxPaymentDetails.Controls.Add(this.label2);
            this.gbxPaymentDetails.Location = new System.Drawing.Point(11, 11);
            this.gbxPaymentDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxPaymentDetails.Name = "gbxPaymentDetails";
            this.gbxPaymentDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxPaymentDetails.Size = new System.Drawing.Size(331, 245);
            this.gbxPaymentDetails.TabIndex = 1;
            this.gbxPaymentDetails.TabStop = false;
            this.gbxPaymentDetails.Text = "Payment details";
            // 
            // lblDescriptionDisplay
            // 
            this.lblDescriptionDisplay.AutoSize = true;
            this.lblDescriptionDisplay.Location = new System.Drawing.Point(78, 100);
            this.lblDescriptionDisplay.Name = "lblDescriptionDisplay";
            this.lblDescriptionDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblDescriptionDisplay.TabIndex = 8;
            // 
            // lblFeeDisplay
            // 
            this.lblFeeDisplay.AutoSize = true;
            this.lblFeeDisplay.Location = new System.Drawing.Point(43, 64);
            this.lblFeeDisplay.Name = "lblFeeDisplay";
            this.lblFeeDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblFeeDisplay.TabIndex = 7;
            // 
            // lblRefNoDisplay
            // 
            this.lblRefNoDisplay.AutoSize = true;
            this.lblRefNoDisplay.Location = new System.Drawing.Point(56, 28);
            this.lblRefNoDisplay.Name = "lblRefNoDisplay";
            this.lblRefNoDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblRefNoDisplay.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(39, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(245, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel payment";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ErrP
            // 
            this.ErrP.ContainerControl = this;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 295);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbxPaymentDetails);
            this.Controls.Add(this.gbxPayment);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPayment";
            this.Text = "Enter Payment Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPayment_FormClosing);
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.gbxPayment.ResumeLayout(false);
            this.gbxPayment.PerformLayout();
            this.gbxPaymentDetails.ResumeLayout(false);
            this.gbxPaymentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPaymentMethod;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.GroupBox gbxPayment;
        private System.Windows.Forms.GroupBox gbxPaymentMethodDetails;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRefNo;
        private System.Windows.Forms.GroupBox gbxPaymentDetails;
        private System.Windows.Forms.Label lblDescriptionDisplay;
        private System.Windows.Forms.Label lblFeeDisplay;
        private System.Windows.Forms.Label lblRefNoDisplay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider ErrP;
    }
}