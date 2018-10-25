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
    public partial class frmStudentReport : Form
    {
        public frmStudentReport()
        {
            InitializeComponent();
        }

        private void frmStudentReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mitchellSchoolOfMusicDataSet.Student' table. You can move, or remove it, as needed.
            DataAccess.LoadDatabaseStudentData();
            this.studentTableAdapter.Fill(this.mitchellSchoolOfMusicDataSet.Student);
            rptvStudent.RefreshReport();
            PopulateCboColumnTitles();
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

        private void cboSearch_TextChanged(object sender, EventArgs e)
        {
            EnableSearch();
        }

        private void cboCollumnTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatePotentialQueries(cboCollumnTitles.Text);
            EnableSearch();
        }

        private void PopulatePotentialQueries(string Column)
        {
            cboSearch.Items.Clear();
            int ArrayCount = 0;
            string[] Values = new string[DataAccess.dtStudent.Rows.Count];
            foreach (DataRow r in DataAccess.dtStudent.Rows)
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
                    case "StudentNo":
                        {
                            studentTableAdapter.StudentNoQuery(mitchellSchoolOfMusicDataSet.Student, int.Parse(cboSearch.Text));
                            break;
                        }
                    case "FirstName":
                        {
                            studentTableAdapter.FirstNameQuery(mitchellSchoolOfMusicDataSet.Student, cboSearch.Text);
                            break;
                        }
                    case "Surname":
                        {
                            studentTableAdapter.SurnameQuery(mitchellSchoolOfMusicDataSet.Student, cboSearch.Text);
                            break;
                        }
                    case "Address":
                        {
                            studentTableAdapter.AddressQuery(mitchellSchoolOfMusicDataSet.Student, cboSearch.Text);
                            break;
                        }
                    case "Town":
                        {
                            studentTableAdapter.TownQuery(mitchellSchoolOfMusicDataSet.Student, cboSearch.Text);
                            break;
                        }
                    case "PostCode":
                        {
                            studentTableAdapter.PostCodeQuery(mitchellSchoolOfMusicDataSet.Student, cboSearch.Text);
                            break;
                        }
                    case "Email":
                        {
                            studentTableAdapter.EmailQuery(mitchellSchoolOfMusicDataSet.Student, cboSearch.Text);
                            break;
                        }
                    case "DOB":
                        {
                            studentTableAdapter.DobQuery(mitchellSchoolOfMusicDataSet.Student, cboSearch.Text);
                            break;
                        }
                    case "Gender":
                        {
                            studentTableAdapter.GenderQuery(mitchellSchoolOfMusicDataSet.Student, cboSearch.Text);
                            break;
                        }
                    case "Disability":
                        {
                            studentTableAdapter.DisabilityQuery(mitchellSchoolOfMusicDataSet.Student, bool.Parse(cboSearch.Text));
                            break;
                        }
                    case "ContactTelNo":
                        {
                            studentTableAdapter.ContactTelNoQuery(mitchellSchoolOfMusicDataSet.Student, cboSearch.Text);
                            break;
                        }
                    case "ParentName":
                        {
                            studentTableAdapter.ParentNameQuery(mitchellSchoolOfMusicDataSet.Student, cboSearch.Text);
                            break;
                        }
                    case "DateJoined":
                        {
                            studentTableAdapter.DateJoinedQuery(mitchellSchoolOfMusicDataSet.Student, cboSearch.Text);
                            break;
                        }
                    case "DateLeft":
                        {
                            studentTableAdapter.DateLeftQuery(mitchellSchoolOfMusicDataSet.Student, cboSearch.Text);
                            break;
                        }
                    case "CurrentStudent":
                        {
                            studentTableAdapter.CurrentStudentQuery(mitchellSchoolOfMusicDataSet.Student, bool.Parse(cboSearch.Text));
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
            rptvStudent.RefreshReport();
        }

        private void btnClearQuery_Click(object sender, EventArgs e)
        {
            studentTableAdapter.Fill(this.mitchellSchoolOfMusicDataSet.Student);
            rptvStudent.RefreshReport();
        }
    }
}