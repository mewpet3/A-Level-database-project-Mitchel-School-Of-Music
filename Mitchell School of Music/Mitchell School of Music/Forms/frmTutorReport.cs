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
    public partial class frmTutorReport : Form
    {
        public frmTutorReport()
        {
            InitializeComponent();
        }

        private void frmTutorReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mitchellSchoolOfMusicDataSet.Tutor' table. You can move, or remove it, as needed.
            DataAccess.LoadDatabaseTutorData();
            this.tutorTableAdapter.Fill(this.mitchellSchoolOfMusicDataSet.Tutor);
            rptvTutor.RefreshReport();
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

        private void PopulatePotentialQueries(string Column)
        {
            cboSearch.Items.Clear();
            int ArrayCount = 0;
            string[] Values = new string[DataAccess.dtTutor.Rows.Count];
            foreach (DataRow r in DataAccess.dtTutor.Rows)
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
                    case "TutorNo":
                        {
                            tutorTableAdapter.TutorNoQuery(mitchellSchoolOfMusicDataSet.Tutor, int.Parse(cboSearch.Text));
                            break;
                        }
                    case "FirstName":
                        {
                            tutorTableAdapter.FirstNameQuery(mitchellSchoolOfMusicDataSet.Tutor, cboSearch.Text);
                            break;
                        }
                    case "Surname":
                        {
                            tutorTableAdapter.SurnameQuery(mitchellSchoolOfMusicDataSet.Tutor, cboSearch.Text);
                            break;
                        }
                    case "Address":
                        {
                            tutorTableAdapter.AddressQuery(mitchellSchoolOfMusicDataSet.Tutor, cboSearch.Text);
                            break;
                        }
                    case "Town":
                        {
                            tutorTableAdapter.TownQuery(mitchellSchoolOfMusicDataSet.Tutor, cboSearch.Text);
                            break;
                        }
                    case "PostCode":
                        {
                            tutorTableAdapter.PostCodeQuery(mitchellSchoolOfMusicDataSet.Tutor, cboSearch.Text);
                            break;
                        }
                    case "Email":
                        {
                            tutorTableAdapter.EmailQuery(mitchellSchoolOfMusicDataSet.Tutor, cboSearch.Text);
                            break;
                        }
                    case "DOB":
                        {
                            tutorTableAdapter.DOBQuery(mitchellSchoolOfMusicDataSet.Tutor, cboSearch.Text);
                            break;
                        }
                    case "Gender":
                        {
                            tutorTableAdapter.GenderQuery(mitchellSchoolOfMusicDataSet.Tutor, cboSearch.Text);
                            break;
                        }
                    case "Disability":
                        {
                            tutorTableAdapter.DisabilityQuery(mitchellSchoolOfMusicDataSet.Tutor, bool.Parse(cboSearch.Text));
                            break;
                        }
                    case "ContactTelNo":
                        {
                            tutorTableAdapter.ContactTelNoQuery(mitchellSchoolOfMusicDataSet.Tutor, cboSearch.Text);
                            break;
                        }
                    case "NextOfKin":
                        {
                            tutorTableAdapter.NextOfKinQuery(mitchellSchoolOfMusicDataSet.Tutor, cboSearch.Text);
                            break;
                        }
                    case "DateJoined":
                        {
                            tutorTableAdapter.DateJoinedQuery(mitchellSchoolOfMusicDataSet.Tutor, cboSearch.Text);
                            break;
                        }
                    case "DateLeft":
                        {
                            tutorTableAdapter.DateLeftQuery(mitchellSchoolOfMusicDataSet.Tutor, cboSearch.Text);
                            break;
                        }
                    case "CurrentTutor":
                        {
                            tutorTableAdapter.CurrentTutorQuery(mitchellSchoolOfMusicDataSet.Tutor, bool.Parse(cboSearch.Text));
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
            rptvTutor.RefreshReport();
        }

        private void btnClearQuery_Click(object sender, EventArgs e)
        {
            tutorTableAdapter.Fill(this.mitchellSchoolOfMusicDataSet.Tutor);
            rptvTutor.RefreshReport();
        }
    }
}