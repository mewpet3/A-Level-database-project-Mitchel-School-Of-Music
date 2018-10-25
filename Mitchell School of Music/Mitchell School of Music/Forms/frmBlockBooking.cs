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
    public partial class frmBlockBooking : Form
    {
        //global variables
        int CurrentRow = -1;
        byte DiscountRate = 0;
        float PricePerLesson = 0;
        float FinalPrice = 0;
        bool? canConcessionary  = null;
        bool Available = true;

        public frmBlockBooking()
        {
            InitializeComponent();
        }
        
        private void frmBlockBooking_Load(object sender, EventArgs e)
        {
            DataAccess.LoadDatabaseStudentData();
            DataAccess.LoadDatabaseBlockBookingData();
            DataAccess.LoadDatabaseTuitionChoiceData();
            PopulateComboBoxStudent();
            PopulateComboBoxTuitionChoice();
            DisplayBlockBookingDataOnGrid();
            PopulateCboColumnTitles();
        }

        private void PopulateCboColumnTitles()
        {
            try
            {
                foreach (DataColumn Column in DataAccess.dtBlockBooking.Columns)
                {
                    cboCollumnTitles.Items.Add(Column.ColumnName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to populate search titles selection. " + ex.Message);
            }
        }

        private void cboStudentNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStudentData.Clear();
            if (!string.IsNullOrWhiteSpace(cboStudentNo.Text))
            {
                DataRow r = DataAccess.dtStudent.Rows.Find(int.Parse(cboStudentNo.Text));
                string ReturnString = string.Empty;
                for (int CollumnNo = 0; CollumnNo < r.ItemArray.Count(); CollumnNo++)
                {
                    ReturnString += r.Table.Columns[CollumnNo].ColumnName + ": " + r[CollumnNo].ToString() + "\r\n";
                }
                txtStudentData.Text = ReturnString;
                if ((bool)r[9] || DateTime.Now.Year - DateTime.Parse(r[7].ToString()).Year > 60)
                    CanConcessionary = true;
                else
                    CanConcessionary = false;
            }
            else
            {
                CanConcessionary = null;
            }
            UpdateValues();
        }

        private bool? CanConcessionary
        {
            get { return canConcessionary; }
            set
            {
                if (Utilities.ValidBool(value))
                {
                    canConcessionary = value;
                    lblConcessionaryDiscount.Text = "Concessionary discount: " + value;
                }
                else
                    lblConcessionaryDiscount.Text = "Concessionary discount: ";
            }
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                SaveData();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BlockBooking bb = new BlockBooking();
            if (UpdateClassWVerification(bb))
            {
                DataRow r = DataAccess.dtBlockBooking.Rows.Find(CurrentRow);
                ErrP.Clear(); 
                ImportClassValuesToDataRow(r, bb);

                DataAccess.daBlockBooking.Update(DataAccess.ds.Tables["BlockBooking"]);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow r = DataAccess.dtBlockBooking.Rows.Find(CurrentRow);
            DialogResult deleteRecord = MessageBox.Show("Are you sure you want to delete this record?", "Delete a record?", MessageBoxButtons.YesNo);
            if (deleteRecord == DialogResult.Yes)
            {
                DataAccess.dtBlockBooking.Rows.Find(CurrentRow).Delete();
                btnDelete.Enabled = false;
                CurrentRow = -1;
                DataAccess.daBlockBooking.Update(DataAccess.ds.Tables["BlockBooking"]);
            }
            else
            {
                MessageBox.Show("Delete oporation cancelled.");
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
            p.AmountPaid = float.Parse(DataAccess.dtBlockBooking.Rows.Find(CurrentRow)["TotalDue"].ToString());
            p.RefNo = int.Parse(DataAccess.dtBlockBooking.Rows.Find(CurrentRow)["BookingNo"].ToString());
            p.Description = "BlockBooking";
            p.StudentNo = int.Parse(DataAccess.dtBlockBooking.Rows.Find(CurrentRow)["StudentNo"].ToString());
            frmPayment NewPayment = new frmPayment(p);
            NewPayment.Show();
            this.Hide();
        }

        private void dgvBlockBooking_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CurrentRow = int.Parse(dgvBlockBooking.Rows[e.RowIndex].Cells[0].Value.ToString());

                if (CurrentRow != -1)
                {
                    DisplayGridDataOnForm();
                    if (!Convert.ToBoolean(DataAccess.dtBlockBooking.Rows.Find(CurrentRow)["Paid"]))
                    {
                        btnPay.Enabled = true;
                    }
                    else
                    {
                        btnPay.Enabled = false;
                    }
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnUpdate.Enabled = false;
                    btnPay.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error connecting to database - contact your DB administrator. " + ex.Message);
            }
        }

        private void SaveData()
        {
            try
            {
                DataRow r = DataAccess.dtBlockBooking.NewRow();
                BlockBooking bb = new BlockBooking();
                if (UpdateClassWVerification(bb))
                {
                    ImportClassValuesToDataRow(r, bb);
                    DataAccess.dtBlockBooking.Rows.Add(r);
                    DataAccess.daBlockBooking.Update(DataAccess.ds.Tables["BlockBooking"]);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool UpdateClassWVerification(BlockBooking bb)
        {
            ErrP.Clear();
            bool ok = true;

            try
            {
                bb.StudentNo = int.Parse(cboStudentNo.Text);
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(cboStudentNo, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error detected: " + ex.Message);
                ok = false;
            }

            try
            {
                bb.TuitionChoice = cboTuitionChoice.Text.Substring(0, cboTuitionChoice.Text.LastIndexOf(" - "));
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(cboTuitionChoice, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error detected: " + ex.Message);
                ok = false;
            }

            try
            {
                bb.DateBooking = DateTime.Now.Date;
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(cboTuitionChoice, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error detected: " + ex.Message);
                ok = false;
            }

            try
            {
                bb.AbilityLevel = char.Parse(cboAbilityLevel.Text);
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(cboAbilityLevel, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error detected: " + ex.Message);
                ok = false;
            }

            try
            {
                bb.NoLessons = (short)nudNoLessons.Value;
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(cboAbilityLevel, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error detected: " + ex.Message);
                ok = false;
            }

            try
            {
                bb.DiscountRate = DiscountRate;
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(lblDiscountRate, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error detected: " + ex.Message);
                ok = false;
            }

            try
            {
                bb.LessonRate = PricePerLesson;
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(lblPricePerLesson, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error detected: " + ex.Message);
                ok = false;
            }

            try
            {
                bb.TotalDue = FinalPrice;
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(lblTotalPrice, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error detected: " + ex.Message);
                ok = false;
            }

            try
            {
                bb.WaitingList = !Available;
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(cboTuitionChoice, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error detected: " + ex.Message);
                ok = false;
            }

            return ok;
        }

        private void ImportClassValuesToDataRow(DataRow r, BlockBooking bb)
        {
            r["StudentNo"] = bb.StudentNo;
            r["DateBooking"] = bb.DateBooking;
            r["TuitionChoice"] = bb.TuitionChoice;
            r["AbilityLevel"] = bb.AbilityLevel;
            r["NoLessons"] = bb.NoLessons;
            r["DiscountRate"] = bb.DiscountRate;
            r["LessonRate"] = bb.LessonRate;
            r["TotalDue"] = bb.TotalDue;
            r["Paid"] = bb.Paid;
            r["WaitingList"] = bb.WaitingList;
        }

        private void DisplayBlockBookingDataOnGrid()
        {
            try
            {
                DataAccess.LoadDatabaseBlockBookingData();
                dgvBlockBooking.DataSource = null;
                dgvBlockBooking.DataSource = DataAccess.dtBlockBooking;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void PopulateComboBoxStudent()
        {
            foreach (DataRow dr in DataAccess.dtStudent.Rows)
            {
                cboStudentNo.Items.Add(dr.ItemArray.GetValue(0));
            }
        }

        private void PopulateComboBoxTuitionChoice()
        {
            foreach (DataRow dr in DataAccess.dtTuitionChoice.Rows)
            {
                if (bool.Parse(dr.ItemArray.GetValue(1).ToString()))
                    cboTuitionChoice.Items.Add(dr.ItemArray.GetValue(0) + " - Available");
                else
                    cboTuitionChoice.Items.Add(dr.ItemArray.GetValue(0) + " - Unavailable");
            }
        }

        private void DisplayGridDataOnForm()
        {
            try
            {
                cboStudentNo.Text = DataAccess.dtBlockBooking.Rows.Find(CurrentRow)["StudentNo"].ToString();
                nudNoLessons.Value = decimal.Parse(DataAccess.dtBlockBooking.Rows.Find(CurrentRow)["NoLessons"].ToString());
                cboAbilityLevel.SelectedIndex = cboAbilityLevel.Items.IndexOf(DataAccess.dtBlockBooking.Rows.Find(CurrentRow)["AbilityLevel"].ToString());
                if ((bool)DataAccess.dtTuitionChoice.Rows.Find(DataAccess.dtBlockBooking.Rows.Find(CurrentRow)["TuitionChoice"])[1])
                {
                    cboTuitionChoice.SelectedIndex = cboTuitionChoice.Items.IndexOf(DataAccess.dtBlockBooking.Rows.Find(CurrentRow)["TuitionChoice"].ToString() + " - Available");
                }
                else
                {
                    cboTuitionChoice.SelectedIndex = cboTuitionChoice.Items.IndexOf(DataAccess.dtBlockBooking.Rows.Find(CurrentRow)["TuitionChoice"].ToString() + " - Unavailable");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvBlockBooking.DataSource = Utilities.DataTableFilter("BlockBooking", cboCollumnTitles.Text, txtSearch.Text, "BookingNo");
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
            DisplayBlockBookingDataOnGrid();
        }

        private void cboTuitionChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cboTuitionChoice.Text))
            {
                DataRow SelectedTuition = DataAccess.dtTuitionChoice.Rows.Find(cboTuitionChoice.Text.Substring(0, cboTuitionChoice.Text.LastIndexOf(" - ")));
                Available = (bool.Parse(SelectedTuition[1].ToString()));
                lblAvailable.Text = "Choice available: " + Available;
            }
            else
            {
                lblAvailable.Text = "Choice available: ";
            }
        }

        private void nudNoLessons_ValueChanged(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void UpdateValues()
        {
            DiscountRate = 0;
            switch (nudNoLessons.Value.ToString())
            {
                case "20":
                    {
                        DiscountRate = 5;
                        break;
                    }
                case "30":
                    {
                        DiscountRate = 10;
                        break;
                    }
            }
            if (CanConcessionary == true)
                DiscountRate += 20;
            switch (cboAbilityLevel.Text)
            {
                case "B":
                    {
                        PricePerLesson = 12 - 12 * DiscountRate / 100;
                        break;
                    }
                case "I":
                    {
                        PricePerLesson = 15 - 15 * DiscountRate / 100;
                        break;
                    }
                case "A":
                    {
                        PricePerLesson = 18 - 18 * DiscountRate / 100;
                        break;
                    }
                case "D":
                    {
                        PricePerLesson = 20 - 20 * DiscountRate / 100;
                        break;
                    }
            }
            FinalPrice = (PricePerLesson * (float)nudNoLessons.Value) + 30;
            UpdatePaymentDetails();
        }

        private void UpdatePaymentDetails()
        {
            lblDiscountRate.Text = "Discount rate: " + DiscountRate.ToString() + '%';
            lblPricePerLesson.Text = "Price per lesson: £" + PricePerLesson.ToString();
            lblTotalPrice.Text = "Total price for lessons: £" + (FinalPrice - 30);
            lblFinalPrice.Text = "Final price including tuition fees: £" + FinalPrice.ToString();
        }

        private void cboAbilityLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboAbilityLevel.SelectedIndex = -1;
            cboStudentNo.SelectedIndex = -1;
            cboTuitionChoice.SelectedIndex = -1;
            nudNoLessons.Value = 10;
        }
    }
}
