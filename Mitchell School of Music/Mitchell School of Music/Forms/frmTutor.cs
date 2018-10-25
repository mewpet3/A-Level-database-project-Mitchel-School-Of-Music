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
    public partial class frmTutor : Form
    {
        bool ToOtherFrm = false;
        int CurrentRow = -1;
        public frmTutor()
        {
            InitializeComponent();
        }

        private void frmTutor_Load(object sender, EventArgs e)
        {
            try
            {
                //Load customer data from sql backend database.
                DataAccess.LoadDatabaseTutorData();
                DisplayTutorDataOnGrid();
            }
            catch
            {
                throw new Exception("Error connecting to database - contact your DB administrator.");
            }
            PopulateCboColumnTitles();
        }

        private void PopulateCboColumnTitles()
        {
            try
            {
                foreach (DataColumn Column in DataAccess.dtTutor.Columns)
                {
                    cboCollumnTitles.Items.Add(Column.ColumnName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to populate search titles selection. " + ex.Message);
            }
        }

        private void DisplayTutorDataOnGrid()
        {
            DataAccess.LoadDatabaseTutorData();
            dgvTutor.DataSource = null;
            dgvTutor.DataSource = DataAccess.dtTutor;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                SaveData();
            }
            catch (Exception ex)
            {
                throw new Exception("Error connecting to database - contact your DB administrator.\r\n\r\nAdditional information:\r\n" + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Tutor t = new Tutor();
            if (UpdateClassWVerification(t))
            {
                DataRow r = DataAccess.dtTutor.Rows.Find(CurrentRow);
                ErrP.Clear();
                ImportClassValuesToDataRow(r, t);
                DataAccess.daTutor.Update(DataAccess.ds.Tables["Tutors"]);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow r = DataAccess.dtTutor.Rows.Find(CurrentRow);
            DialogResult DeleteRecord = MessageBox.Show("Are you sure you want to delete this record?", "Delete a record?", MessageBoxButtons.YesNo);
            if (DeleteRecord == DialogResult.Yes)
            {
                DataAccess.dtTutor.Rows.Find(CurrentRow).Delete();
                CurrentRow = -1;
                DataAccess.daTutor.Update(DataAccess.ds.Tables["Tutor"]);
            }
            else
            {
                MessageBox.Show("Delete oporation cancelled.");
            }
        }

        private void ImportClassValuesToDataRow(DataRow r, Tutor t)
        {
            r["Firstname"] = t.FirstName;
            r["Surname"] = t.Surname;
            r["Address"] = t.Address;
            r["Town"] = t.Town;
            r["PostCode"] = t.PostCode;
            r["Email"] = t.Email;
            r["DOB"] = t.DOB;
            switch (t.Gender)
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
            r["Disability"] = t.Disability;
            r["ContactTelNo"] = t.ContactTelNo;
            r["NextOfKin"] = t.NextOfKin;
            r["DateJoined"] = t.DateJoined;
            r["CurrentTutor"] = t.CurrentTutor;
            if (!t.CurrentTutor)
            {
                r["DateLeft"] = t.DateLeft;
            }
            else
            {
                r["DateLeft"] = DBNull.Value;
            }
        }

        private bool UpdateClassWVerification(Tutor t)
        {
            ErrP.Clear();
            bool ok = true;

            try
            {
                t.FirstName = txtFirstName.Text;
            }
            catch (Exception ex)
            {
                ErrP.SetError(txtFirstName, ex.Message);
                ok = false;
            }

            try
            {
                t.Surname = txtSurname.Text;
            }
            catch (Exception ex)
            {
                ErrP.SetError(txtSurname, ex.Message);
                ok = false;
            }

            try
            {
                t.Address = txtAddress.Text;
            }
            catch (Exception ex)
            {
                ErrP.SetError(txtAddress, ex.Message);
                ok = false;
            }

            try
            {
                t.Town = txtTown.Text;
            }
            catch (Exception ex)
            {
                ErrP.SetError(txtTown, ex.Message);
                ok = false;
            }

            try
            {
                t.PostCode = mtbPostCode.Text;
            }
            catch (Exception ex)
            {
                ErrP.SetError(mtbPostCode, ex.Message);
                ok = false;
            }

            try
            {
                t.Email = txtEmail.Text;
            }
            catch (Exception ex)
            {
                ErrP.SetError(txtEmail, ex.Message);
                ok = false;
            }

            try
            {
                t.DOB = mtbDOB.Text;
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
                            t.Gender = true;
                            break;
                        }
                    case 'F':
                        {
                            t.Gender = false;
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
                t.Disability = cbxDisability.Checked;
            }
            catch (Exception ex)
            {
                ErrP.SetError(cbxDisability, ex.Message);
            }

            try
            {
                t.ContactTelNo = mtbTelNo.Text;
            }
            catch (Exception ex)
            {
                ErrP.SetError(mtbTelNo, ex.Message);
                ok = false;
            }

            try
            {
                t.NextOfKin = txtNextOfKinName.Text;
            }
            catch (Exception ex)
            {
                ErrP.SetError(txtNextOfKinName, ex.Message);
                ok = false;
            }

            try
            {
                t.DateJoined = DateTime.Now.Date;
            }
            catch (Exception ex)
            {
                ErrP.SetError(txtDateJoined, ex.Message);
                ok = false;
            }

            try
            {
                t.CurrentTutor = cbxCurrentTutor.Checked;
            }
            catch (Exception ex)
            {
                ErrP.SetError(cbxCurrentTutor, ex.Message);
                ok = false;
            }

            try
            {
                if (t.CurrentTutor == false)
                    t.DateLeft = mtbDateLeft.Text;
            }
            catch (Exception ex)
            {
                ErrP.SetError(mtbDateLeft, ex.Message);
                ok = false;
            }

            return ok;
        }

        private void SaveData()
        {
            DataRow r = DataAccess.dtTutor.NewRow();
            Tutor t = new Tutor();
            if (UpdateClassWVerification(t))
            {
                ImportClassValuesToDataRow(r, t);
                DataAccess.dtTutor.Rows.Add(r);
                DataAccess.daTutor.Update(DataAccess.ds.Tables["Tutors"]);
            }
        }

        private void dgvTutor_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CurrentRow = int.Parse(dgvTutor.Rows[e.RowIndex].Cells[0].Value.ToString());

                if (CurrentRow != -1)
                {
                    DisplayGridDataOnForm();
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
                txtFirstName.Text = DataAccess.dtTutor.Rows.Find(CurrentRow)["FirstName"].ToString();
                txtSurname.Text = DataAccess.dtTutor.Rows.Find(CurrentRow)["Surname"].ToString();
                txtAddress.Text = DataAccess.dtTutor.Rows.Find(CurrentRow)["Address"].ToString();
                txtTown.Text = DataAccess.dtTutor.Rows.Find(CurrentRow)["Town"].ToString();
                mtbPostCode.Text = DataAccess.dtTutor.Rows.Find(CurrentRow)["PostCode"].ToString();
                txtEmail.Text = DataAccess.dtTutor.Rows.Find(CurrentRow)["Email"].ToString();
                mtbDOB.Text = DataAccess.dtTutor.Rows.Find(CurrentRow)["DOB"].ToString();
                cboGender.SelectedIndex = cboGender.FindString(DataAccess.dtTutor.Rows.Find(CurrentRow)["Gender"].ToString());
                cbxDisability.Checked = bool.Parse(DataAccess.dtTutor.Rows.Find(CurrentRow)["Disability"].ToString());
                mtbTelNo.Text = DataAccess.dtTutor.Rows.Find(CurrentRow)["ContactTelNo"].ToString();
                txtNextOfKinName.Text = DataAccess.dtTutor.Rows.Find(CurrentRow)["NextOfKin"].ToString();
                mtbDateJoined.Text = DataAccess.dtTutor.Rows.Find(CurrentRow)["DateJoined"].ToString();
                mtbDateLeft.Text = DataAccess.dtTutor.Rows.Find(CurrentRow)["DateLeft"].ToString();
                cbxCurrentTutor.Checked = bool.Parse(DataAccess.dtTutor.Rows.Find(CurrentRow)["CurrentTutor"].ToString());
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
                dgvTutor.DataSource = Utilities.DataTableFilter("Tutor", cboCollumnTitles.Text, txtSearch.Text, "TutorNo");
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
            DisplayTutorDataOnGrid();
        }

        private void btnProficiencies_Click(object sender, EventArgs e)
        {
            ToOtherFrm = true;
            frmTutorTakes NewForm = new frmTutorTakes(int.Parse(DataAccess.dtTutor.Rows.Find(CurrentRow)["TutorNo"].ToString()));
            Utilities.OpenNewForm(this, NewForm, true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtNextOfKinName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtTown.Text = string.Empty;
            mtbDOB.ResetText();
            mtbPostCode.ResetText();
            mtbTelNo.ResetText();
            mtbDateJoined.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            mtbDateLeft.ResetText();
        }

        private void cbxCurrentTutor_CheckedChanged(object sender, EventArgs e)
        {
            switch (cbxCurrentTutor.Checked)
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
    }
}
