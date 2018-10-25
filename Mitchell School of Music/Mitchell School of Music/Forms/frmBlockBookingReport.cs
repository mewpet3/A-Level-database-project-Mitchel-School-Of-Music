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
    public partial class frmBlockBookingReport : Form
    {
        public frmBlockBookingReport()
        {
            InitializeComponent();
        }

        private void frmBlockBookingReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mitchellSchoolOfMusicDataSet.BlockBooking' table. You can move, or remove it, as needed.
            this.blockBookingTableAdapter.Fill(this.mitchellSchoolOfMusicDataSet.BlockBooking);
            DataAccess.LoadDatabaseBlockBookingData();
            rptvBlockBooking.RefreshReport();
            PopulateCboColumnTitles();
        }

        //populates the column titles of block booking
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

        //populates potential queries from each of the unique things from the selected column.
        private void PopulatePotentialQueries(string Column)
        {
            cboSearch.Items.Clear();
            int ArrayCount = 0;
            string[] Values = new string[DataAccess.dtBlockBooking.Rows.Count];
            foreach (DataRow r in DataAccess.dtBlockBooking.Rows)
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

        //When text is changed it checks if the query is addable.
        private void cboSearch_TextChanged(object sender, EventArgs e)
        {
            EnableSearch();
        }

        //populates the potential queries when the column title selection has been changed
        private void cboCollumnTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatePotentialQueries(cboCollumnTitles.Text);
            EnableSearch();
        }

        //checks if necessary things have been added in order to enable the query
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
            //Brings up the add query group box
            EnableSearch();
            btnNewQuery.Visible = false;
            gbxNewQuery.Visible = true;
        }

        private void btnAddQuery_Click(object sender, EventArgs e)
        {
            //Adds the created query to the report viewer based on the column selected
            try
            {
                switch (cboCollumnTitles.Text)
                {
                    case "BookingNo":
                        {
                            blockBookingTableAdapter.BookingNoQuery(mitchellSchoolOfMusicDataSet.BlockBooking, int.Parse(cboSearch.Text));
                            break;
                        }
                    case "StudentNo":
                        {
                            blockBookingTableAdapter.StudentNoQuery(mitchellSchoolOfMusicDataSet.BlockBooking, int.Parse(cboSearch.Text));
                            break;
                        }
                    case "TuitionChoice":
                        {
                            blockBookingTableAdapter.TuitionChoiceQuery(mitchellSchoolOfMusicDataSet.BlockBooking, cboSearch.Text);
                            break;
                        }
                    case "DateBooking":
                        {
                            blockBookingTableAdapter.DateBookingQuery(mitchellSchoolOfMusicDataSet.BlockBooking, cboSearch.Text);
                            break;
                        }
                    case "AbilityLevel":
                        {
                            blockBookingTableAdapter.AbilityLevelQuery(mitchellSchoolOfMusicDataSet.BlockBooking, cboSearch.Text);
                            break;
                        }
                    case "NoLessons":
                        {
                            blockBookingTableAdapter.NoLessonsQuery(mitchellSchoolOfMusicDataSet.BlockBooking, int.Parse(cboSearch.Text));
                            break;
                        }
                    case "DiscountRate":
                        {
                            blockBookingTableAdapter.DiscountRateQuery(mitchellSchoolOfMusicDataSet.BlockBooking, int.Parse(cboSearch.Text));
                            break;
                        }
                    case "LessonRate":
                        {
                            blockBookingTableAdapter.LessonRateQuery(mitchellSchoolOfMusicDataSet.BlockBooking, decimal.Parse(cboSearch.Text));
                            break;
                        }
                    case "TotalDue":
                        {
                            blockBookingTableAdapter.TotalDueQuery(mitchellSchoolOfMusicDataSet.BlockBooking, decimal.Parse(cboSearch.Text));
                            break;
                        }
                    case "Paid":
                        {
                            blockBookingTableAdapter.PaidQuery(mitchellSchoolOfMusicDataSet.BlockBooking, bool.Parse(cboSearch.Text));
                            break;
                        }
                    case "WaitingList":
                        {
                            blockBookingTableAdapter.WaitingListQuery(mitchellSchoolOfMusicDataSet.BlockBooking, bool.Parse(cboSearch.Text));
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
            rptvBlockBooking.RefreshReport();
        }

        private void btnClearQuery_Click(object sender, EventArgs e)
        {
            blockBookingTableAdapter.Fill(this.mitchellSchoolOfMusicDataSet.BlockBooking);
            rptvBlockBooking.RefreshReport();
        }
    }
}
