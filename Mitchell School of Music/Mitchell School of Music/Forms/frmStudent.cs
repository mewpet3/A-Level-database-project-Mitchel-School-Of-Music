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
    public partial class frmStudent : Form
    {
        int CurrentRow = -1;
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            try
            {
                //Load student data from sql backend database.
                DataAccess.LoadDatabaseStudentData();
                //Display the student data from the database on the dgv.
                DisplayStudentDataOnGrid();
                //Populate the search fields with the collumn titles.
                PopulateCboColumnTitles();
            }
            catch (Exception ex)
            {
                throw new Exception("Error connecting to database - contact your DB administrator.\r\n\r\nAdditional information:\r\n" + ex.Message);
            }
        }

        private void PopulateCboColumnTitles()
        {
            try
            {
                foreach (DataColumn Column in DataAccess.dtStudent.Columns)
                {
                    cboCollumnTitles.Items.Add(Column.ColumnName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to populate search titles selection. " + ex.Message);
            }
        }

        private void DisplayStudentDataOnGrid()
        {
            try
            {
                DataAccess.LoadDatabaseStudentData();
                dgvStudent.DataSource = null;
                dgvStudent.DataSource = DataAccess.dtStudent;
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
            Student s = new Student();
            if (UpdateClassWVerification(s))
            {
                DataRow r = DataAccess.dtStudent.Rows.Find(CurrentRow);
                ErrP.Clear();
                ImportClassValuesToDataRow(r, s);
                DataAccess.daStudent.Update(DataAccess.ds.Tables["Student"]);
            }
        }

        private void ImportClassValuesToDataRow(DataRow r, Student s)
        {
            r["FirstName"] = s.FirstName;
            r["Surname"] = s.Surname;
            r["Address"] = s.Address;
            r["Town"] = s.Town;
            r["PostCode"] = s.PostCode;
            r["Email"] = s.Email;
            r["DOB"] = s.DOB;
            switch (s.Gender)
            {
                case true:
                    {
                        r["Gender"] = 'M';
                        break;
                    }
                case false:
                    {
                        r["Gender"] = 'F';
                        break;
                    }
            }
            r["Disability"] = s.Disability;
            r["ContactTelNo"] = s.ContactTelNo;
            r["ParentName"] = s.ParentName;
            r["DateJoined"] = s.DateJoined.Date;
            if (s.CurrentStudent == true)
            {
                r["DateLeft"] = DBNull.Value;
            }
            else
            {
                r["DateLeft"] = s.DateLeft;
            }
            r["CurrentStudent"] = s.CurrentStudent;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CurrentRow != -1)
            {
                DialogResult deleteRecord = MessageBox.Show("Are you sure you want to delete this record?", "Delete a record?", MessageBoxButtons.YesNo);
                if (deleteRecord == DialogResult.Yes)
                {
                    DataRow r = DataAccess.dtStudent.Rows.Find(CurrentRow);
                    DataAccess.dtStudent.Rows.Find(CurrentRow).Delete();
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    CurrentRow = -1;
                    DataAccess.daStudent.Update(DataAccess.ds.Tables["Student"]);
                }
                else
                {
                    MessageBox.Show("Delete oporation cancelled.");
                }
            }
        }

        private bool UpdateClassWVerification(Student s)
        {
            ErrP.Clear();
            bool ok = true;

            try
            {
                s.FirstName = txtFirstName.Text;
            }
            catch (Exception ex)
            {
                ErrP.SetError(txtFirstName, ex.Message);
                ok = false;
            }

            try
            {
                s.Surname = txtSurname.Text;
            }
            catch (Exception ex)
            {
                ErrP.SetError(txtSurname, ex.Message);
                ok = false;
            }

            try
            {
                s.Address = txtAddress.Text;
            }
            catch (Exception ex)
            {
                ErrP.SetError(txtAddress, ex.Message);
                ok = false;
            }

            try
            {
                s.Town = txtTown.Text;
            }
            catch (Exception ex)
            {
                ErrP.SetError(txtTown, ex.Message);
                ok = false;
            }

            try
            {
                s.PostCode = mtbPostCode.Text;
            }
            catch (Exception ex)
            {
                ErrP.SetError(mtbPostCode, ex.Message);
                ok = false;
            }

            try
            {
                s.Email = txtEmail.Text;
            }
            catch (Exception ex)
            {
                ErrP.SetError(txtEmail, ex.Message);
                ok = false;
            }

            try
            {
                s.DOB = mtbDOB.Text;
            }
            catch (Exception ex)
            {
                ErrP.SetError(mtbDOB, ex.Message);
                ok = false;
            }

            try
            {
                switch (char.Parse(cboGender.Text.Substring(0, 1)))
                {
                    case 'M':
                        {
                            s.Gender = true;
                            break;
                        }
                    case 'F':
                        {
                            s.Gender = false;
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                ErrP.SetError(cboGender, ex.Message);
                ok = false;
            }

            try
            {
                s.Disability = cbxDisability.Checked;
            }
            catch (Exception ex)
            {
                ErrP.SetError(cbxDisability, ex.Message);
                ok = false;
            }

            try
            {
                s.ContactTelNo = mtbTelNo.Text;
            }
            catch (Exception ex)
            {
                ErrP.SetError(mtbTelNo, ex.Message);
                ok = false;
            }

            try
            {
                s.ParentName = txtParentName.Text;
            }
            catch (Exception ex)
            {
                ErrP.SetError(txtParentName, ex.Message);
                ok = false;
            }

            try
            {
                s.DateJoined = DateTime.Now.Date;
            }
            catch (Exception ex)
            {
                ErrP.SetError(lblDateJoined, ex.Message);
                ok = false;
            }

            if (cbxCurrentStudent.Checked == false)
            {
                try
                {
                    s.DateLeft = mtbDateLeft.Text;
                }
                catch (Exception ex)
                {
                    ErrP.SetError(mtbDateLeft, ex.Message);
                    ok = false;
                }
            }

            try
            {
                s.CurrentStudent = cbxCurrentStudent.Checked;
            }
            catch (Exception ex)
            {
                ErrP.SetError(cbxCurrentStudent, ex.Message);
                ok = false;
            }
            
            return ok;
        }

        private void SaveData()
        {
            DataRow r = DataAccess.dtStudent.NewRow();
            Student s = new Student();
            if (UpdateClassWVerification(s))
            {
                ImportClassValuesToDataRow(r, s);
                DataAccess.dtStudent.Rows.Add(r);
                DataAccess.daStudent.Update(DataAccess.ds.Tables["Student"]);
            }
        }

        private void dgvStudent_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                CurrentRow = int.Parse(dgvStudent.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (CurrentRow != -1)
                {
                    DisplayGridDataOnForm();
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error connecting to database - contact your DB administrator. Was unable to retrieve data from selected datarow.\r\n\r\nAdditional information:\r\n" + ex.Message);
            }
        }

        private void DisplayGridDataOnForm()
        {
            try
            {
                txtFirstName.Text = DataAccess.dtStudent.Rows.Find(CurrentRow)["FirstName"].ToString();
                txtSurname.Text = DataAccess.dtStudent.Rows.Find(CurrentRow)["Surname"].ToString();
                txtAddress.Text = DataAccess.dtStudent.Rows.Find(CurrentRow)["Address"].ToString();
                txtTown.Text = DataAccess.dtStudent.Rows.Find(CurrentRow)["Town"].ToString();
                mtbPostCode.Text = DataAccess.dtStudent.Rows.Find(CurrentRow)["PostCode"].ToString();
                txtEmail.Text = DataAccess.dtStudent.Rows.Find(CurrentRow)["Email"].ToString();
                mtbDOB.Text = DataAccess.dtStudent.Rows.Find(CurrentRow)["DOB"].ToString();
                cboGender.SelectedIndex = cboGender.FindString(DataAccess.dtStudent.Rows.Find(CurrentRow)["Gender"].ToString());
                cbxDisability.Checked = bool.Parse(DataAccess.dtStudent.Rows.Find(CurrentRow)["Disability"].ToString());
                mtbTelNo.Text = DataAccess.dtStudent.Rows.Find(CurrentRow)["ContactTelNo"].ToString();
                txtParentName.Text = DataAccess.dtStudent.Rows.Find(CurrentRow)["ParentName"].ToString();
                mtbDateJoined.Text = DataAccess.dtStudent.Rows.Find(CurrentRow)["DateJoined"].ToString();
                mtbDateLeft.Text = DataAccess.dtStudent.Rows.Find(CurrentRow)["DateLeft"].ToString();
                cbxCurrentStudent.Checked = bool.Parse(DataAccess.dtStudent.Rows.Find(CurrentRow)["CurrentStudent"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxCurrentStudent_CheckedChanged(object sender, EventArgs e)
        {
            switch (cbxCurrentStudent.Checked)
            {
                case true:
                    {
                        mtbDateLeft.Text = string.Empty;
                        break;
                    }
                case false:
                    {
                        mtbDateLeft.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
                        break;
                    }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvStudent.DataSource = Utilities.DataTableFilter("Student", cboCollumnTitles.Text, txtSearch.Text, "StudentNo");
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
            DisplayStudentDataOnGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtParentName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtTown.Text = string.Empty;
            mtbDOB.ResetText();
            mtbPostCode.ResetText();
            mtbTelNo.ResetText();
            mtbDateJoined.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            mtbDateLeft.ResetText();
        }
    }
}
