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
    public partial class frmPaymentHistoryReport : Form
    {
        public frmPaymentHistoryReport()
        {
            InitializeComponent();
        }

        private void frmPaymentHistoryReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mitchellSchoolOfMusicDataSet.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.mitchellSchoolOfMusicDataSet.Payment);
            this.rptvPaymentHistory.RefreshReport();
            DataAccess.LoadDatabasePaymentData();
            PopulateCboColumnTitles();
        }

        private void PopulateCboColumnTitles()
        {
            try
            {
                foreach (DataColumn Column in DataAccess.dtPayment.Columns)
                {
                    cboCollumnTitles.Items.Add(Column.ColumnName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to populate search titles selection. " + ex.Message);
            }
        }

        private void PopulatePotentialQueries(string Column)
        {
            cboSearch.Items.Clear();
            int ArrayCount = 0;
            string[] Values = new string[DataAccess.dtPayment.Rows.Count];
            foreach (DataRow r in DataAccess.dtPayment.Rows)
            {
                Values[ArrayCount] = r[Column].ToString();
                ArrayCount++;
            }
            string[] DistinctValues = Utilities.UniqueArrayData(Values);
            foreach (string s in DistinctValues)
            {
                if (!string.IsNullOrWhiteSpace(s))
                    cboSearch.Items.Add(s);
            }
        }

        private void cboSearch_TextChanged(object sender, EventArgs e)
        {
            EnableSearch();
        }

        private void cboCollumnTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatePotentialQueries(cboCollumnTitles.Text);
            EnableSearch();
        }

        private void EnableSearch()
        {
            if (!string.IsNullOrEmpty(cboSearch.Text) && !string.IsNullOrEmpty(cboCollumnTitles.Text))
            {
                btnAddQuery.Enabled = true;
            }
            else
            {
                btnAddQuery.Enabled = false;
            }
        }

        private void btnNewQuery_Click(object sender, EventArgs e)
        {
            EnableSearch();
            btnNewQuery.Visible = false;
            gbxNewQuery.Visible = true;
        }

        private void btnAddQuery_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cboCollumnTitles.Text)
                {
                    case "PaymentNo":
                        {
                            paymentTableAdapter.PaymentNoQuery(mitchellSchoolOfMusicDataSet.Payment, int.Parse(cboSearch.Text));
                            break;
                        }
                    case "RefNo":
                        {
                            paymentTableAdapter.RefNoQuery(mitchellSchoolOfMusicDataSet.Payment, int.Parse(cboSearch.Text));
                            break;
                        }
                    case "StudentNo":
                        {
                            paymentTableAdapter.StudentNoQuery(mitchellSchoolOfMusicDataSet.Payment, int.Parse(cboSearch.Text));
                            break;
                        }
                    case "Description":
                        {
                            paymentTableAdapter.DescriptionQuery(mitchellSchoolOfMusicDataSet.Payment, cboSearch.Text);
                            break;
                        }
                    case "DatePaid":
                        {
                            paymentTableAdapter.DatePaidQuery(mitchellSchoolOfMusicDataSet.Payment, cboSearch.Text);
                            break;
                        }
                    case "AmountPaid":
                        {
                            paymentTableAdapter.AmountPaidQuery(mitchellSchoolOfMusicDataSet.Payment, decimal.Parse(cboSearch.Text));
                            break;
                        }
                    case "PaymentMethod":
                        {
                            paymentTableAdapter.PaymentMethodQuery(mitchellSchoolOfMusicDataSet.Payment, cboSearch.Text);
                            break;
                        }
                    case "ResponsibleEmployee":
                        {
                            paymentTableAdapter.ResponsibleEmployeeQuery(mitchellSchoolOfMusicDataSet.Payment, cboSearch.Text);
                            break;
                        }
                    case "Sponsor":
                        {
                            paymentTableAdapter.SponsorQuery(mitchellSchoolOfMusicDataSet.Payment, cboSearch.Text);
                            break;
                        }
                    case "SponsorOwner":
                        {
                            paymentTableAdapter.SponsorOwnerQuery(mitchellSchoolOfMusicDataSet.Payment, cboSearch.Text);
                            break;
                        }
                    case "Paid":
                        {
                            paymentTableAdapter.PaidQuery(mitchellSchoolOfMusicDataSet.Payment, bool.Parse(cboSearch.Text));
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Value entered is not an expected or acceptable value: " + ex.Message);
            }
            gbxNewQuery.Visible = false;
            btnNewQuery.Visible = true;
            btnAddQuery.Enabled = false;
            rptvPaymentHistory.RefreshReport();
        }

        private void btnClearQuery_Click(object sender, EventArgs e)
        {
            paymentTableAdapter.Fill(this.mitchellSchoolOfMusicDataSet.Payment);
            rptvPaymentHistory.RefreshReport();
        }
    }
}