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
    public partial class frmExamEntry : Form
    {
        //global variables
        int CurrentRow = -1;

        public frmExamEntry()
        {
            InitializeComponent();
        }

        private void frmExamEntry_Load(object sender, EventArgs e)
        {
            DataAccess.LoadDatabaseStudentData();
            DataAccess.LoadDatabaseExternalExamData();
            DataAccess.LoadDatabaseExamEntryData();
            PopulateComboBoxStudent();
            PopulateComboBoxExam(); 
            DisplayExamEntryDataOnGrid();
            PopulateCboColumnTitles();
        }

        private void PopulateCboColumnTitles()
        {
            try
            {
                foreach (DataColumn Column in DataAccess.dtExamEntry.Columns)
                {
                    cboCollumnTitles.Items.Add(Column.ColumnName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to populate search titles selection. " + ex.Message);
            }
        }

        private void DisplayExamEntryDataOnGrid()
        {
            try
            {
                DataAccess.LoadDatabaseExamEntryData();
                dgvExamEntry.DataSource = null;
                dgvExamEntry.DataSource = DataAccess.dtExamEntry;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
            ExamEntry ee = new ExamEntry();
            if (UpdateClassWVerification(ee))
            {
                DataRow r = DataAccess.dtExamEntry.Rows.Find(CurrentRow);
                ErrP.Clear(); ImportClassValuesToDataRow(r, ee);

                DataAccess.daExamEntry.Update(DataAccess.ds.Tables["ExamEntry"]);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow r = DataAccess.dtExamEntry.Rows.Find(CurrentRow);
            DialogResult deleteRecord = MessageBox.Show("Are you sure you want to delete this record?", "Delete a record?", MessageBoxButtons.YesNo);
            if (deleteRecord == DialogResult.Yes)
            {
                DataAccess.dtExamEntry.Rows.Find(CurrentRow).Delete();
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                CurrentRow = -1;
                DataAccess.daExamEntry.Update(DataAccess.ds.Tables["ExamEntry"]);
            }
            else
            {
                MessageBox.Show("Delete oporation cancelled.");
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
            p.AmountPaid = float.Parse(DataAccess.dtExamEntry.Rows.Find(CurrentRow)["Fee"].ToString());
            p.RefNo = int.Parse(DataAccess.dtExamEntry.Rows.Find(CurrentRow)["ExamEntryNo"].ToString());
            p.Description = "ExamEntry";
            p.StudentNo = int.Parse(cboStudentNo.Text);
            frmPayment NewPayment = new frmPayment(p);
            NewPayment.Show();
            this.Close();
        }

        private void cboStudentNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStudentData.Clear();
            if (cboStudentNo.SelectedIndex != -1)
            {
                DataRow r = DataAccess.dtStudent.Rows.Find(int.Parse(cboStudentNo.Text));
                for (int CollumnNo = 0; CollumnNo < r.ItemArray.Count(); CollumnNo++)
                {
                    if (CollumnNo != 7 && CollumnNo != 12 && CollumnNo != 13)
                    {
                        txtStudentData.Text += r.Table.Columns[CollumnNo].ColumnName + ": " + r[CollumnNo].ToString() + "\r\n";
                    }
                    else
                    {
                        if (CollumnNo == 13)
                        {
                            if ((bool)r[14] == false)
                                txtStudentData.Text += r.Table.Columns[CollumnNo].ColumnName + ": " + DateTime.Parse(r[CollumnNo].ToString()).Date.ToString("dd/MM/yyyy") + "\r\n";
                            else
                            {
                                txtStudentData.Text += "DateLeft: N/A\r\n";
                            }
                        }
                        else
                        {
                            txtStudentData.Text += r.Table.Columns[CollumnNo].ColumnName + ": " + DateTime.Parse(r[CollumnNo].ToString()).Date.ToString("dd/MM/yyyy") + "\r\n";
                        }
                    }
                }
            }
        }

        private void cboExamNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtExamData.Clear();
            if (cboExamNo.SelectedIndex != -1)
            {
                DataRow r = DataAccess.dtExternalExam.Rows.Find(int.Parse(cboExamNo.Text));
                for (int CollumnNo = 0; CollumnNo < r.ItemArray.Count(); CollumnNo++)
                {
                    if (CollumnNo != 4)
                    {
                        txtExamData.Text += r.Table.Columns[CollumnNo].ColumnName + ": " + r[CollumnNo].ToString() + "\r\n";
                    }
                    else
                    {
                        txtExamData.Text += r.Table.Columns[CollumnNo].ColumnName + ": " + DateTime.Parse(r[CollumnNo].ToString()).Date.ToString("dd/MM/yyyy") + "\r\n";
                    }
                }
            }
        }

        private void PopulateComboBoxStudent()
        {
            foreach (DataRow dr in DataAccess.dtStudent.Rows)
            {
                cboStudentNo.Items.Add(dr.ItemArray.GetValue(0));
            }
        }

        private void PopulateComboBoxExam()
        {
            foreach (DataRow dr in DataAccess.dtExternalExam.Rows)
            {
                cboExamNo.Items.Add(dr.ItemArray.GetValue(0));
            }
        }

        private void SaveData()
        {
            try
            {
                ExamEntry ee = new ExamEntry();
                if (UpdateClassWVerification(ee))
                {
                    DataRow r = DataAccess.dtExamEntry.NewRow();
                    ImportClassValuesToDataRow(r, ee);
                    DataAccess.dtExamEntry.Rows.Add(r);
                    DataAccess.daExamEntry.Update(DataAccess.ds.Tables["ExamEntry"]);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool UpdateClassWVerification(ExamEntry ee)
        {
            ErrP.Clear();
            bool ok = true;

            try
            {
                ee.StudentNo = int.Parse(cboStudentNo.Text);
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(cboStudentNo, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured, please contact system administrator. (" + ex.Message + ").");
                ok = false;
            }

            try
            {
                ee.ExamNo = int.Parse(cboExamNo.Text);
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(cboExamNo, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured, please contact system administrator. (" + ex.Message + ").");
                ok = false;
            }

            try
            {
                ee.DateEntry = DateTime.Now.Date;
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(mtbDateEntry, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured, please contact system administrator. (" + ex.Message + ").");
                ok = false;
            }

            try
            {
                ee.Fee = float.Parse(DataAccess.dtExternalExam.Rows.Find(int.Parse(cboExamNo.Text))[6].ToString().Trim('£'));
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(cboExamNo, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured, please contact system administrator. (" + ex.Message + ").");
                ok = false;
            }

            try
            {
                ee.Paid = cbxPaid.Checked;
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(cbxPaid, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured, please contact system administrator. (" + ex.Message + ").");
                ok = false;
            }

            try
            {
                if (ee.Paid != false)
                {
                    ee.DatePaid = mtbDatePaid.Text;
                }
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(mtbDatePaid, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured, please contact system administrator. (" + ex.Message + ").");
                ok = false;
            }

            return ok;
        }

        private void ImportClassValuesToDataRow(DataRow r, ExamEntry ee)
        {
            r["ExamNo"] = ee.ExamNo;
            r["StudentNo"] = ee.StudentNo;
            r["DateEntry"] = ee.DateEntry;
            r["Fee"] = ee.Fee;
            r["Paid"] = ee.Paid;
            if (ee.Paid)
            {
                r["DatePaid"] = ee.DatePaid;
            }
            else
            {
                r["DatePaid"] = DBNull.Value;
            }
        }

        private void dgvExamEntry_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CurrentRow = int.Parse(dgvExamEntry.Rows[e.RowIndex].Cells[0].Value.ToString());

                if (CurrentRow != -1)
                {
                    DisplayGridDataOnForm();
                    if (!Convert.ToBoolean(DataAccess.dtExamEntry.Rows.Find(CurrentRow)["Paid"]))
                    {
                        btnPay.Enabled = true;
                    }
                    else
                    {
                        btnPay.Enabled = false;
                    }
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnPay.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            catch
            {
                throw new Exception("Error connecting to database - contact your DB administrator.");
            }
        }

        private void DisplayGridDataOnForm()
        {
            try
            {
                cboExamNo.Text = DataAccess.dtExamEntry.Rows.Find(CurrentRow)["ExamNo"].ToString();
                cboStudentNo.Text = DataAccess.dtExamEntry.Rows.Find(CurrentRow)["StudentNo"].ToString();
                mtbDateEntry.Text = DataAccess.dtExamEntry.Rows.Find(CurrentRow)["DateEntry"].ToString();
                cbxPaid.Checked = Convert.ToBoolean(DataAccess.dtExamEntry.Rows.Find(CurrentRow)["Paid"]);
                mtbDatePaid.Text = DataAccess.dtExamEntry.Rows.Find(CurrentRow)["DatePaid"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxPaid_CheckedChanged(object sender, EventArgs e)
        {
            switch (cbxPaid.Checked)
            {
                case true:
                    {
                        mtbDatePaid.Enabled = true;
                        break;
                    }
                case false:
                    {
                        mtbDatePaid.Enabled = false;
                        break;
                    }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvExamEntry.DataSource = Utilities.DataTableFilter("ExamEntry", cboCollumnTitles.Text, txtSearch.Text, "ExamEntryNo");
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
            DisplayExamEntryDataOnGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboExamNo.SelectedIndex = -1;
            cboStudentNo.SelectedIndex = -1;
            mtbDateEntry.ResetText();
            mtbDatePaid.ResetText();
            cbxPaid.Checked = false;
        }
    }
}
