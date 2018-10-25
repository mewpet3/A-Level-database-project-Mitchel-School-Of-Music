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
    public partial class frmTutorTakes : Form
    {
        int CurrentRow = -1;
        int TutorNo;

        public frmTutorTakes(int tutorNo)
        {
            InitializeComponent();
            TutorNo = tutorNo;
        }

        private void frmTutorTakes_Load(object sender, EventArgs e)
        {
            DataAccess.LoadDatabaseTutorTakesData();
            DataAccess.LoadDatabaseTuitionChoiceData();
            txtTutorNo.Text = TutorNo.ToString();
            DisplayTutorTakesDataOnGrid();
            PopulateCboColumnTitles();
            PopulateComboBoxTuitionChoice();
        }

        private void PopulateComboBoxTuitionChoice()
        {
            foreach (DataRow dr in DataAccess.dtTuitionChoice.Rows)
            {
                cboTuition.Items.Add(dr.ItemArray.GetValue(0));
            }
        }

        private void PopulateCboColumnTitles()
        {
            try
            {
                foreach (DataColumn Column in DataAccess.dtTutorTakes.Columns)
                {
                    cboCollumnTitles.Items.Add(Column.ColumnName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to populate search titles selection. " + ex.Message);
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
            TutorTakes tt = new TutorTakes();
            if (UpdateClassWVerification(tt))
            {
                DataRow r = DataAccess.dtTutorTakes.Rows.Find(CurrentRow);
                ErrP.Clear();
                ImportClassValuesToDataRow(r, tt);
                DataAccess.daTutorTakes.Update(DataAccess.ds.Tables["TutorTakes"]);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CurrentRow != -1)
            {
                DialogResult deleteRecord = MessageBox.Show("Are you sure you want to delete this record?", "Delete a record?", MessageBoxButtons.YesNo);
                if (deleteRecord == DialogResult.Yes)
                {
                    DataRow r = DataAccess.dtTutorTakes.Rows.Find(CurrentRow);
                    DataAccess.dtTutorTakes.Rows.Find(CurrentRow).Delete();
                    CurrentRow = -1;
                    DataAccess.daTutorTakes.Update(DataAccess.ds.Tables["TutorTakes"]);
                }
                else
                {
                    MessageBox.Show("Delete oporation cancelled.");
                }
            }
        }

        private bool UpdateClassWVerification(TutorTakes tt)
        {
            ErrP.Clear();
            bool ok = true;

            try
            {
                tt.TutorNo = int.Parse(txtTutorNo.Text);
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(txtTutorNo, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error detected: " + ex.Message);
                ok = false;
            }

            try
            {
                tt.TuitionChoice = cboTuition.Text;
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(cboTuition, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error detected: " + ex.Message);
                ok = false;
            }

            try
            {
                tt.TeachUpTo = char.Parse(cboTeachUpTo.Text);
            }
            catch (InvalidDataException ex)
            {
                ErrP.SetError(cboTeachUpTo, ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error detected: " + ex.Message);
                ok = false;
            }

            return ok;
        }

        private void SaveData()
        {
            try
            {
                DataRow r = DataAccess.dtBlockBooking.NewRow();
                TutorTakes tt = new TutorTakes();
                if (UpdateClassWVerification(tt))
                {
                    ImportClassValuesToDataRow(r, tt);
                    DataAccess.dtTutorTakes.Rows.Add(r);
                    DataAccess.daTutorTakes.Update(DataAccess.ds.Tables["TutorTakes"]);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void ImportClassValuesToDataRow(DataRow r, TutorTakes tt)
        {
            r["TutorNo"] = tt.TutorNo;
            r["TuitionChoice"] = tt.TuitionChoice;
            r["TeachUpToGrade"] = tt.TeachUpTo;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTutorTakes.DataSource = new DataView(DataAccess.dtTutor, cboCollumnTitles.Text + " Like '" + txtSearch + "%' AND TutorNo = " + txtTutorNo, "TutorTakesNo" + " ASC", DataViewRowState.CurrentRows);
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
            DisplayTutorTakesDataOnGrid();
        }

        private void DisplayTutorTakesDataOnGrid()
        {
            DataAccess.LoadDatabaseTutorTakesData();
            dgvTutorTakes.DataSource = null;
            dgvTutorTakes.DataSource = new DataView(DataAccess.dtTutorTakes, "TutorNo = " + TutorNo, "TutorTakesNo" + " ASC", DataViewRowState.CurrentRows);
        }

        private void dgvTutorTakes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CurrentRow = int.Parse(dgvTutorTakes.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (CurrentRow != -1)
                {
                    DisplayGridDataOnForm();
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnUpdate.Enabled = false;
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
                cboTeachUpTo.SelectedText = DataAccess.dtTutorTakes.Rows.Find(CurrentRow)[3].ToString();
                cboTuition.SelectedText = DataAccess.dtTutorTakes.Rows.Find(CurrentRow)[2].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTutorNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataRow r = DataAccess.dtTutor.Rows.Find(int.Parse(txtTutorNo.Text));
                for (int CollumnNo = 0; CollumnNo < r.ItemArray.Count(); CollumnNo++)
                {
                    if (CollumnNo != 7 || CollumnNo != 12 || CollumnNo != 13)
                    {
                        txtTutorData.Text += r.Table.Columns[CollumnNo].ColumnName + ": " + r[CollumnNo].ToString() + "\r\n";
                    }
                    else
                    {
                        txtTutorData.Text += r.Table.Columns[CollumnNo].ColumnName + ": " + DateTime.Parse(r[CollumnNo].ToString()).Date.ToString("dd/MM/yyyy") + "\r\n";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving information regarding selected tutor, please contact system administrator.\r\n\r\nAdditional information:\r\n" + ex.Message);
            }
        }
    }
}