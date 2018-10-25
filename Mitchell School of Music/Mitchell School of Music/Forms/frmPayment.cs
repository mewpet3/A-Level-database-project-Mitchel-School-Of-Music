using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitchell_School_of_Music
{
    public partial class frmPayment : Form
    {
        bool ChangingForm;
        byte FieldCount;
        Label[] Labels;
        TextBox[] InputBoxes;
        Button btnMakePayment;
        Payment p;
        enum PaymentMethod
        {
            Cash,
            CreditCard,
            DebitCard,
            Sponsorship
        };

        public frmPayment(Payment P)
        {
            InitializeComponent();
            p = P;
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            switch (p.Description)
            {
                case "ExamEntry":
                    {
                        DataAccess.LoadDatabaseExamEntryData();
                        break;
                    }
                case "BlockBooking":
                    {
                        DataAccess.LoadDatabaseBlockBookingData();
                        break;
                    }
            }
            DataAccess.LoadDatabasePaymentData();
            lblRefNoDisplay.Text = p.RefNo.ToString();
            lblFeeDisplay.Text = "£" + p.AmountPaid.ToString();
            lblDescriptionDisplay.Text = p.Description.ToString();
        }

        private void cboPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                gbxPaymentMethodDetails.Controls.Clear();
                btnMakePayment = new Button();
                btnMakePayment.Click += btnMakePayment_Click;
                gbxPaymentMethodDetails.Controls.Add(btnMakePayment);
                btnMakePayment.Enabled = false;
                btnMakePayment.Location = new System.Drawing.Point(5, 183);
                btnMakePayment.Size = new System.Drawing.Size(247, 23);
                btnMakePayment.Text = "Make payment";
                string[] Designations;
                switch (cboPaymentMethod.SelectedIndex)
                {
                    case (int)PaymentMethod.Cash:
                        {
                            FieldCount = 1;
                            Designations = new string[FieldCount];
                            Designations[0] = "Responsible Employee";
                            Labels = new Label[FieldCount];
                            InputBoxes = new TextBox[FieldCount];
                            break;
                        }
                    case (int)PaymentMethod.CreditCard:
                        {
                            FieldCount = 2;
                            Designations = new string[FieldCount];
                            Designations[0] = "Responsible Employee:";
                            Designations[1] = "Credit card No.:";
                            Labels = new Label[FieldCount];
                            InputBoxes = new TextBox[FieldCount];
                            break;
                        }
                    case (int)PaymentMethod.DebitCard:
                        {
                            FieldCount = 2;
                            Designations = new string[FieldCount];
                            Designations[0] = "Responsible Employee:";
                            Designations[1] = "Debit card No.:";
                            Labels = new Label[FieldCount];
                            InputBoxes = new TextBox[FieldCount];

                            break;
                        }
                    case (int)PaymentMethod.Sponsorship:
                        {
                            FieldCount = 3;
                            Designations = new string[FieldCount];
                            Designations[0] = "Responsible Employee:";
                            Designations[1] = "Sponsor:";
                            Designations[2] = "Sponsor member responsible:";
                            Labels = new Label[FieldCount];
                            InputBoxes = new TextBox[FieldCount];
                            break;
                        }
                    default:
                        {
                            throw new Exception("No/invalid payment method selected.");
                        }
                }
                for (byte FieldNo = 0; FieldNo < FieldCount; FieldNo++)
                {
                    Labels[FieldNo] = new Label();
                    InputBoxes[FieldNo] = new TextBox();
                    gbxPaymentMethodDetails.Controls.Add(Labels[FieldNo]);
                    gbxPaymentMethodDetails.Controls.Add(InputBoxes[FieldNo]);
                    Labels[FieldNo].Top = ((FieldNo * 25) + 20);
                    Labels[FieldNo].Left = 10;
                    Labels[FieldNo].AutoSize = true;
                    Labels[FieldNo].Text = Designations[FieldNo];
                    InputBoxes[FieldNo].TextChanged += new EventHandler(txtInputField);
                    InputBoxes[FieldNo].Top = Labels[FieldNo].Top;
                    InputBoxes[FieldNo].Left = Labels[FieldNo].Left + Labels[FieldNo].Width;
                }
                gbxPaymentMethodDetails.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting payment method: " + ex.Message + ".");
            }
        }

        private void BtnMakePayment_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtInputField(object sender, EventArgs e)
        {
            if (FieldsEntered(InputBoxes))
                btnMakePayment.Enabled = true;
            else
                btnMakePayment.Enabled = false;
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (FieldsEntered(InputBoxes))
                {
                    if (UpdateClassWVerification(p))
                    {
                        DataRow r = DataAccess.dtPayment.NewRow();
                        ImportClassValuesToDataRow(r);
                        DataAccess.dtPayment.Rows.Add(r);
                        DataAccess.daPayment.Update(DataAccess.ds.Tables["Payment"]);
                        switch (p.Description)
                        {
                            case "ExamEntry":
                                {
                                    DataAccess.dtExamEntry.Rows.Find(p.RefNo)["Paid"] = true;
                                    DataAccess.dtExamEntry.Rows.Find(p.RefNo)["DatePaid"] = DateTime.Now.Date;
                                    DataAccess.daExamEntry.Update(DataAccess.ds.Tables["ExamEntry"]);
                                    MessageBox.Show("Payment Successful.\r\nReturning to previous form.");
                                    frmExamEntry NewForm = new frmExamEntry();
                                    ChangingForm = true;
                                    Utilities.OpenNewForm(this, NewForm, true);
                                    break;
                                }
                            case "BlockBooking":
                                {
                                    DataAccess.dtBlockBooking.Rows.Find(p.RefNo)["Paid"] = true;
                                    DataAccess.daBlockBooking.Update(DataAccess.ds.Tables["BlockBooking"]);
                                    MessageBox.Show("Payment Successful.\r\nReturning to previous form.");
                                    frmBlockBooking NewForm = new frmBlockBooking();
                                    ChangingForm = true;
                                    Utilities.OpenNewForm(this, NewForm, true);
                                    break;
                                }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Not all fields have been entered. Please enter all fields before proceeding.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error detected while making payment.\r\nAdditional information\r\n" + ex.Message);
            }
        }

        private bool FieldsEntered(TextBox[] InputBoxes)
        {
            try
            {
                bool Acceptable = true;
                foreach (TextBox txtBox in InputBoxes)
                {
                    if (string.IsNullOrWhiteSpace(txtBox.Text))
                        Acceptable = false;
                }
                return Acceptable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to detect if all fields have been entered. " + ex.Message + "." + " Please contact system administrator.");
                return false;
            }
        }

        private void ImportClassValuesToDataRow(DataRow r)
        {
            r["RefNo"] = p.RefNo;
            r["StudentNo"] = p.StudentNo;
            r["Description"] = p.Description;
            r["DatePaid"] = p.DatePaid.Date;
            r["AmountPaid"] = p.AmountPaid;
            r["PaymentMethod"] = p.PaymentMethod;
            r["ResponsibleEmployee"] = p.ResponsibleEmployee;
            r["Sponsor"] = p.Sponsor;
            r["SponsorOwner"] = p.SponsorOwner;
            r["Paid"] = p.Paid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ChangingForm = true;
            switch (p.Description)
            {
                case "ExamEntry":
                    {
                        ChangingForm = true;
                        frmExamEntry NewForm = new frmExamEntry();
                        Utilities.OpenNewForm(this, NewForm, true);
                        break;
                    }
                case "BlockBooking":
                    {
                        ChangingForm = true;
                        frmBlockBooking NewForm = new frmBlockBooking();
                        Utilities.OpenNewForm(this, NewForm, true);
                        break;
                    }
            }
        }

        private bool UpdateClassWVerification(Payment p)
        {
            ErrP.Clear();
            bool ok = true;

            try
            {
                p.DatePaid = DateTime.Now.Date;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured, please contact system administrator. (" + ex.Message + ").");
                ok = false;
            }
            try
            {
                p.Paid = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured, please contact system administrator. (" + ex.Message + ").");
                ok = false;
            }
            try
            {
                p.ResponsibleEmployee = InputBoxes[0].Text;
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(InputBoxes[0], ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured, please contact system administrator. (" + ex.Message + ").");
                ok = false;
            }
            try
            {
                switch (cboPaymentMethod.SelectedIndex)
                {
                    case (int)PaymentMethod.Cash:
                        {
                            p.PaymentMethod = PaymentMethod.Cash.ToString();
                            break;
                        }
                    case (int)PaymentMethod.CreditCard:
                        {
                            p.PaymentMethod = PaymentMethod.CreditCard.ToString();
                            break;
                        }
                    case (int)PaymentMethod.DebitCard:
                        {
                            p.PaymentMethod = PaymentMethod.DebitCard.ToString();
                            break;
                        }
                    case (int)PaymentMethod.Sponsorship:
                        {
                            p.PaymentMethod = PaymentMethod.Sponsorship.ToString();
                            p.Sponsor = InputBoxes[1].Text;
                            p.SponsorOwner = InputBoxes[2].Text;
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured, please contact system administrator. (" + ex.Message + ").");
                ok = false;
            }
            return ok;
        }

        private void frmPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ChangingForm)
                btnCancel_Click(sender, e);
        }
    }
}