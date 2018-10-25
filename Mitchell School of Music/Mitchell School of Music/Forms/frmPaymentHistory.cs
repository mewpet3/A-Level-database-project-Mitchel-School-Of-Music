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
    public partial class frmPaymentHistory : Form
    {
        public frmPaymentHistory()
        {
            InitializeComponent();
        }

        private void frmPaymentHistory_Load(object sender, EventArgs e)
        {
            DataAccess.LoadDatabasePaymentData();
            DisplayPaymentDataOnGrid();
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

        private void DisplayPaymentDataOnGrid()
        {
            try
            {
                dgvPayments.DataSource = null;
                dgvPayments.DataSource = DataAccess.dtPayment;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPayments.DataSource = Utilities.DataTableFilter("Payment", cboCollumnTitles.Text, txtSearch.Text, "PaymentNo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering database: " + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            EnableSearch();
        }

        private void cboCollumnTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableSearch();
        }

        private void EnableSearch()
        {
            if (!string.IsNullOrEmpty(txtSearch.Text) && !string.IsNullOrEmpty(cboCollumnTitles.Text))
            {
                btnSearch.Enabled = true;
            }
            else
            {
                btnSearch.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DisplayPaymentDataOnGrid();
        }
    }
}