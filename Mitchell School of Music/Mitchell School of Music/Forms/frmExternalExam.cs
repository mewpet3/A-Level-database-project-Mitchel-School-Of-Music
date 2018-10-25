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
    public partial class frmExternalExam : Form
    {
        //global variables
        int CurrentRow = -1;

        public frmExternalExam()
        {
            InitializeComponent();
        }

        private void frmExternalExam_Load(object sender, EventArgs e)
        {
            DataAccess.LoadDatabaseExternalExamData();
            DataAccess.LoadDatabaseTuitionChoiceData();
            DisplayExternalExamDataOnGrid();
            PopulateCboColumnTitles();
            PopulateCboExamTitle();
        }

        private void PopulateCboExamTitle()
        {
            try
            {
                foreach (DataRow r in DataAccess.dtTuitionChoice.Rows)
                {
                    cboExamTitle.Items.Add(r[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to populate tuition choices for quick-selecting exam title. \r\n\r\n" + ex.Message);
            }
        }

        private void PopulateCboColumnTitles()
        {
            try
            {
                foreach (DataColumn Column in DataAccess.dtExternalExam.Columns)
                {
                    cboCollumnTitles.Items.Add(Column.ColumnName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to populate search titles selection. \r\n\r\n" + ex.Message);
            }
        }

        private void DisplayExternalExamDataOnGrid()
        {
            try
            {
                DataAccess.LoadDatabaseExternalExamData();
                dgvExternalExam.DataSource = null;
                dgvExternalExam.DataSource = DataAccess.dtExternalExam;
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
            ExternalExam ee = new ExternalExam();
            if (UpdateClassWVerification(ee))
            {
                DataRow r = DataAccess.dtExternalExam.Rows.Find(CurrentRow);
                ErrP.Clear();
                ImportClassValuesToDataRow(r, ee);
                
                DataAccess.daExternalExam.Update(DataAccess.ds.Tables["ExternalExam"]);
            }
        }

        private void ImportClassValuesToDataRow(DataRow r, ExternalExam ee)
        {
            r["ExamBoard"] = ee.ExamBoard;
            r["TitleExam"] = ee.TitleExam;
            r["Grade"] = ee.Grade;
            r["DateExam"] = ee.ExamDateStringInOut;
            r["TimeExam"] = ee.ExamTimeStringInOut.ToString().Substring(0,5);
            if (ee.ExamFee.ToString().Contains('.'))
            {
                r["ExamFee"] = "£" + ee.ExamFee.ToString();
            }
            else
            {
                r["ExamFee"] = "£" + ee.ExamFee.ToString() + ".00";
            }
            r["AcceptingEntries"] = ee.AcceptingEntries;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult deleteRecord = MessageBox.Show("Are you sure you want to delete this record?", "Delete a record?", MessageBoxButtons.YesNo);
            if (deleteRecord == DialogResult.Yes)
            {
                DataRow r = DataAccess.dtExternalExam.Rows.Find(CurrentRow);
                DataAccess.dtExternalExam.Rows.Find(CurrentRow).Delete();
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                CurrentRow = -1;
                DataAccess.daExternalExam.Update(DataAccess.ds.Tables["ExternalExam"]);
            }
            else
            {
                MessageBox.Show("Delete oporation cancelled.");
            }
        }

        private void SaveData()
        {
            try
            {
                DataRow r = DataAccess.dtExternalExam.NewRow();
                ExternalExam ee = new ExternalExam();
                if (UpdateClassWVerification(ee))
                {
                    ImportClassValuesToDataRow(r, ee);

                    DataAccess.dtExternalExam.Rows.Add(r);

                    DataAccess.daExternalExam.Update(DataAccess.ds.Tables["ExternalExam"]);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool UpdateClassWVerification(ExternalExam ee)
        {
            ErrP.Clear();
            bool ok = true;

            try
            {
                ee.ExamBoard = cboExamBoard.Text;
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(cboExamBoard, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured, please contact system administrator. (" + ex.Message + ").");
                ok = false;
            }

            try
            {
                ee.TitleExam = cboExamTitle.Text;
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(cboExamTitle, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured, please contact system administrator. (" + ex.Message + ").");
                ok = false;
            }

            try
            {
                ee.Grade = char.Parse(cboGrade.Text.Substring(0,1));
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(cboGrade, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured, please contact system administrator. (" + ex.Message + ").");
                ok = false;
            }

            try
            {
                ee.ExamDateStringInOut = mtbExamDate.Text;
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(mtbExamDate, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured, please contact system administrator. (" + ex.Message + ").");
                ok = false;
            }

            try
            {
                ee.ExamTimeStringInOut = mtbExamTime.Text;
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(mtbExamTime, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured, please contact system administrator. (" + ex.Message + ").");
                ok = false;
            }

            try
            {
                ee.ExamFee = float.Parse(nudExamFee.Value.ToString());
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(nudExamFee, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured, please contact system administrator. (" + ex.Message + ").");
                ok = false;
            }

            try
            {
                ee.AcceptingEntries = cbxAcceptingEntries.Checked;
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(cbxAcceptingEntries, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured, please contact system administrator. (" + ex.Message + ").");
                ok = false;
            }

            return ok;
        }

        private void dgvExternalExam_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CurrentRow = int.Parse(dgvExternalExam.Rows[e.RowIndex].Cells[0].Value.ToString());

                if (CurrentRow != -1)
                {
                    DisplayGridDataOnForm();
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
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
                cboExamBoard.Text = DataAccess.dtExternalExam.Rows.Find(CurrentRow)["ExamBoard"].ToString();
                cboExamTitle.Text = DataAccess.dtExternalExam.Rows.Find(CurrentRow)["TitleExam"].ToString();
                cboGrade.SelectedItem = DataAccess.dtExternalExam.Rows.Find(CurrentRow)["Grade"].ToString();
                mtbExamDate.Text = DataAccess.dtExternalExam.Rows.Find(CurrentRow)["DateExam"].ToString();
                mtbExamTime.Text = DataAccess.dtExternalExam.Rows.Find(CurrentRow)["TimeExam"].ToString();
                nudExamFee.Value = Decimal.Parse(DataAccess.dtExternalExam.Rows.Find(CurrentRow)["ExamFee"].ToString().Substring(1));
                cbxAcceptingEntries.Checked = Convert.ToBoolean(DataAccess.dtExternalExam.Rows.Find(CurrentRow)["AcceptingEntries"]);
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
                dgvExternalExam.DataSource = Utilities.DataTableFilter("ExternalExam", cboCollumnTitles.Text, txtSearch.Text, "ExamNo");
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
            DisplayExternalExamDataOnGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                cboExamBoard.Text = string.Empty;
                cboExamTitle.Text = string.Empty;
                cboGrade.SelectedIndex = -1;
                cbxAcceptingEntries.Checked = false;
                nudExamFee.Value = 0.00M;
                mtbExamDate.ResetText();
                mtbExamTime.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to clear fields.\r\n\r\nAdditional information:\r\n" + ex.Message);
            }
        }
    }
}
