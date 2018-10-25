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
    public partial class frmTimetabledLesson : Form
    {
        int CurrentRow = -1;

        public frmTimetabledLesson()
        {
            InitializeComponent();
            dtpLessonDateTime.MinDate = DateTime.Parse("01/01/2017");
        }

        public frmTimetabledLesson(DateTime Date, int RoomNo, byte Period)
        {
            InitializeComponent();
            cboRoomNo.Text = RoomNo.ToString();
            nudLessonPeriod.Value = Period;
            dtpLessonDateTime.Value = Date;
        }

        private void TimetabledLesson_Load(object sender, EventArgs e)
        {
            DataAccess.LoadDatabaseStudentData();
            DataAccess.LoadDatabaseTutorData();
            DataAccess.LoadDatabaseRoomData();
            DataAccess.LoadDatabaseBlockBookingData();
            DataAccess.LoadDatabaseTimetabledLessonData();
            DataAccess.LoadDatabaseTutorTakesData();
            PopulateComboBoxStudent();
            PopulateComboBoxBooking();
            PopulateCboColumnTitles();
            DisplayTimetabledLessonDataOnGrid();
            UpdateLabelForNumberOfRows();
            dtpLessonDateTime.Value = DateTime.Now.Date;
            CheckDayOfTheWeekForMaxNud();
        }

        private void CheckDayOfTheWeekForMaxNud()
        {
            if (dtpLessonDateTime.Value.DayOfWeek == DayOfWeek.Friday)
                nudLessonPeriod.Maximum = 8;
            else
                nudLessonPeriod.Maximum = 16;       
        }

        private void PopulateCboColumnTitles()
        {
            try
            {
                foreach (DataColumn Column in DataAccess.dtTimetabledLesson.Columns)
                {
                    cboCollumnTitles.Items.Add(Column.ColumnName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to populate search titles selection. " + ex.Message);
            }
        }

        private void cboTutorNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtTutorData.Clear();
                DataRow r = DataAccess.dtTutor.Rows.Find(int.Parse(cboTutorNo.Text));
                for (int CollumnNo = 0; CollumnNo < r.ItemArray.Count(); CollumnNo++)
                {
                    if (CollumnNo != 7 && CollumnNo != 12 && CollumnNo != 13)
                    {
                        txtTutorData.Text += r.Table.Columns[CollumnNo].ColumnName + ": " + r[CollumnNo].ToString() + "\r\n";
                    }
                    else
                    {
                        if (CollumnNo == 13)
                        {
                            if ((bool)r[14] == false)
                                txtTutorData.Text += r.Table.Columns[CollumnNo].ColumnName + ": " + DateTime.Parse(r[CollumnNo].ToString()).Date.ToString("dd/MM/yyyy") + "\r\n";
                            else
                            {
                                txtTutorData.Text += "DateLeft: N/A\r\n";
                            }
                        }
                        else
                        {
                            txtTutorData.Text += r.Table.Columns[CollumnNo].ColumnName + ": " + DateTime.Parse(r[CollumnNo].ToString()).Date.ToString("dd/MM/yyyy") + "\r\n";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to display information on selected Tutor.\r\n\r\nAdditional details:\r\n" + ex.Message);
            }
        }

        private void cboStudentNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStudentData.Clear();
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

        private void cboRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomData.Clear();
            DataRow r = DataAccess.dtRoom.Rows.Find(int.Parse(cboRoomNo.Text));
            for (int CollumnNo = 0; CollumnNo < r.ItemArray.Count(); CollumnNo++)
            {
                txtRoomData.Text += r.Table.Columns[CollumnNo].ColumnName + ": " + r[CollumnNo].ToString() + "\r\n";
            }
        }

        private void cboBookingNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBookingData.Clear();
            DataRow r = DataAccess.dtBlockBooking.Rows.Find(int.Parse(cboBookingNo.Text));
            for (int CollumnNo = 0; CollumnNo < r.ItemArray.Count(); CollumnNo++)
            {
                if (CollumnNo != 3)
                {
                    txtBookingData.Text += r.Table.Columns[CollumnNo].ColumnName + ": " + r[CollumnNo].ToString() + "\r\n";
                }
                else
                {
                    txtBookingData.Text += r.Table.Columns[CollumnNo].ColumnName + ": " + DateTime.Parse(r[CollumnNo].ToString()).Date.ToString("dd/MM/yyyy") + "\r\n";
                }
            }
            cboStudentNo.Text = r[1].ToString();
            PopulateComboBoxTutor(r[2].ToString());
            PopulateComboBoxRoom();
            cboRoomNo.Enabled = true;
            cboTutorNo.Enabled = true;
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
            TimetabledLesson tl = new TimetabledLesson();
            if (UpdateClassWVerification(tl))
            {
                DataRow r = DataAccess.dtTimetabledLesson.Rows.Find(CurrentRow);
                ErrP.Clear();
                ImportClassValuesToDataRow(r, tl);

                DataAccess.daTimetabledLesson.Update(DataAccess.ds.Tables["TimetabledLesson"]);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow r = DataAccess.dtTimetabledLesson.Rows.Find(CurrentRow);
            DialogResult deleteRecord = MessageBox.Show("Are you sure you want to delete this record?", "Delete a record?", MessageBoxButtons.YesNo);
            if (deleteRecord == DialogResult.Yes)
            {
                DataAccess.dtTimetabledLesson.Rows.Find(CurrentRow).Delete();
                btnDelete.Enabled = false;
                CurrentRow = -1;
                DataAccess.daTimetabledLesson.Update(DataAccess.ds.Tables["TimetabledLesson"]);
            }
            else
            {
                MessageBox.Show("Delete oporation cancelled.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTimetabledLessons.DataSource = Utilities.DataTableFilter("TimetabledLesson", cboCollumnTitles.Text, txtSearch.Text, "TLNo");
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            DisplayTimetabledLessonDataOnGrid();
        }

        private void dgvTimetabledLessons_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CurrentRow = int.Parse(dgvTimetabledLessons.Rows[e.RowIndex].Cells[0].Value.ToString());

                if (CurrentRow != -1)
                {
                    btnDelete.Enabled = true;
                    gbxModifiers.Visible = true;
                    btnImport.Enabled = true;
                }
                else
                {
                    gbxModifiers.Visible = false;
                    btnDelete.Enabled = false;
                    btnImport.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error connecting to database - contact your DB administrator. " + ex.Message);
            }
        }

        private void cbxCancellation_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCancellation.Checked)
            {
                txtCancellationReason.Enabled = true;
            }
            else
            {
                txtCancellationReason.Enabled = false;
            }
            txtCancellationReason.Clear();
        }

        private void DisplayGridDataOnForm()
        {
            try
            {
                if (DateTime.Parse(DataAccess.dtTimetabledLesson.Rows.Find(CurrentRow)["DateLesson"].ToString()).Date < DateTime.Now)
                {
                    cboTutorNo.Text = DataAccess.dtTimetabledLesson.Rows.Find(CurrentRow)["TutorNo"].ToString();
                    cboStudentNo.Text = DataAccess.dtTimetabledLesson.Rows.Find(CurrentRow)["StudentNo"].ToString();
                    cboRoomNo.Text = DataAccess.dtTimetabledLesson.Rows.Find(CurrentRow)["RoomNo"].ToString();
                    cboBookingNo.Text = DataAccess.dtTimetabledLesson.Rows.Find(CurrentRow)["BookingNo"].ToString();
                    dtpLessonDateTime.Value = DateTime.MinValue.AddTicks(DateTime.Parse(DataAccess.dtTimetabledLesson.Rows.Find(CurrentRow)["DateLesson"].ToString()).Ticks);
                    nudLessonPeriod.Value = int.Parse(DataAccess.dtTimetabledLesson.Rows.Find(CurrentRow)["TimeLesson"].ToString());
                    cbxStudentPresent.Checked = bool.Parse(DataAccess.dtTimetabledLesson.Rows.Find(CurrentRow)["StudentPresent"].ToString());
                    cbxCancellation.Checked = bool.Parse(DataAccess.dtTimetabledLesson.Rows.Find(CurrentRow)["Cancellation"].ToString());
                }
                else
                {
                    cboTutorNo.Text = DataAccess.dtTimetabledLesson.Rows.Find(CurrentRow)["TutorNo"].ToString();
                    cboStudentNo.Text = DataAccess.dtTimetabledLesson.Rows.Find(CurrentRow)["StudentNo"].ToString();
                    cboRoomNo.Text = DataAccess.dtTimetabledLesson.Rows.Find(CurrentRow)["RoomNo"].ToString();
                    cboBookingNo.Text = DataAccess.dtTimetabledLesson.Rows.Find(CurrentRow)["BookingNo"].ToString();
                    dtpLessonDateTime.Value = DateTime.MinValue.AddTicks(DateTime.Parse(DataAccess.dtTimetabledLesson.Rows.Find(CurrentRow)["DateLesson"].ToString()).Ticks);
                    nudLessonPeriod.Value = int.Parse(DataAccess.dtTimetabledLesson.Rows.Find(CurrentRow)["TimeLesson"].ToString());
                    cbxStudentPresent.Checked = bool.Parse(DataAccess.dtTimetabledLesson.Rows.Find(CurrentRow)["StudentPresent"].ToString());
                    cbxCancellation.Checked = bool.Parse(DataAccess.dtTimetabledLesson.Rows.Find(CurrentRow)["Cancellation"].ToString());
                    if (cbxCancellation.Checked)
                        txtCancellationReason.Text = DataAccess.dtTimetabledLesson.Rows.Find(CurrentRow)["CancellationReason"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying grid data on form: " + ex.Message);
            }
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

        private void DisplayTimetabledLessonDataOnGrid()
        {
            try
            {
                DataAccess.LoadDatabaseTimetabledLessonData();
                dgvTimetabledLessons.DataSource = null;
                dgvTimetabledLessons.DataSource = DataAccess.dtTimetabledLesson;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void ImportClassValuesToDataRow(DataRow r, TimetabledLesson tl)
        {
            r["TutorNo"] = tl.TutorNo;
            r["StudentNo"] = tl.StudentNo;
            r["RoomNo"] = tl.RoomNo;
            r["BookingNo"] = tl.BookingNo;
            r["DateLesson"] = tl.DateTimeLesson.Date;
            r["TimeLesson"] = tl.PeriodLesson;
            r["StudentPresent"] = tl.StudentPresent;
            r["Cancellation"] = tl.Cancellation;
            if (tl.Cancellation)
            {
                r["CancellationReason"] = tl.CancellationReason;
            }
            else
            {
                r["CancellationReason"] = DBNull.Value;
            }
        }

        private void PopulateComboBoxStudent()
        {
            cboStudentNo.Items.Clear();
            foreach (DataRow dr in DataAccess.dtStudent.Rows)
            {
                cboStudentNo.Items.Add(dr.ItemArray.GetValue(0));
            }
        }

        private void PopulateComboBoxTutor(string TuitionChoice)
        {
            cboTutorNo.Items.Clear();
            try
            {
                DataRow[] PotentialTutors = DataAccess.dtTutorTakes.Select("TuitionChoice = '" + TuitionChoice + "'");
                foreach (DataRow dr in PotentialTutors)
                {
                    cboTutorNo.Items.Add(dr.ItemArray.GetValue(1));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error populating tutor combobox - " + ex.Message);
            }
        }

        private void PopulateComboBoxRoom()
        {
            cboRoomNo.Items.Clear();
            foreach (DataRow dr in DataAccess.dtRoom.Rows)
            {
                cboRoomNo.Items.Add(dr.ItemArray.GetValue(0));
            }
        }

        private void PopulateComboBoxBooking()
        {
            cboBookingNo.Items.Clear();
            foreach (DataRow dr in DataAccess.dtBlockBooking.Rows)
            {
                cboBookingNo.Items.Add(dr.ItemArray.GetValue(0));
            }
        }

        private void SaveData()
        {
            try
            {
                TimetabledLesson tl = new TimetabledLesson();
                if (UpdateClassWVerification(tl))
                {
                    if ((bool)DataAccess.dtBlockBooking.Rows.Find(tl.BookingNo)["Paid"])
                    {
                        short NoOfWeeksBooked = (short)((int)(DataAccess.dtBlockBooking.Rows.Find(tl.BookingNo)["NoLessons"]));
                        DateTime TempDate = tl.DateTimeLesson;
                        if (UniqueSession(tl, NoOfWeeksBooked))
                        {
                            tl.DateTimeLesson = TempDate;
                            for (short week = 0; week < NoOfWeeksBooked; week++)
                            {
                                DataRow r = DataAccess.dtTimetabledLesson.NewRow();
                                ImportClassValuesToDataRow(r, tl);
                                DataAccess.dtTimetabledLesson.Rows.Add(r);
                                DataAccess.daTimetabledLesson.Update(DataAccess.ds.Tables["TimetabledLesson"]);
                                UpdateLabelForNumberOfRows();
                                tl.DateTimeLesson = tl.DateTimeLesson.AddDays(7);
                            }
                            MessageBox.Show(NoOfWeeksBooked + " new records created.", "Records Created");
                            DataAccess.LoadDatabaseTimetabledLessonData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Booking number " + tl.BookingNo + " cannot have lessons booked as it has not yet been paid for.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool UpdateClassWVerification(TimetabledLesson tl)
        {
            ErrP.Clear();
            bool ok = true;

            try
            {
                tl.TutorNo = int.Parse(cboTutorNo.Text);
            }
            catch (Exception ex)
            {
                ErrP.SetError(cboTutorNo, ex.Message);
                ok = false;
            }
            
            try
            {
                tl.StudentNo = int.Parse(cboStudentNo.Text);
            }
            catch (Exception ex)
            {
                ErrP.SetError(cboStudentNo, ex.Message);
                ok = false;
            }

            try
            {
                tl.RoomNo = int.Parse(cboRoomNo.Text);
            }
            catch (Exception ex)
            {
                ErrP.SetError(cboRoomNo, ex.Message);
                ok = false;
            }

            try
            {
                tl.BookingNo = int.Parse(cboBookingNo.Text);
            }
            catch (Exception ex)
            {
                ErrP.SetError(cboBookingNo, ex.Message);
                ok = false;
            }

            try
            {
                tl.PeriodLesson = Convert.ToByte(nudLessonPeriod.Value);
            }
            catch (Exception ex)
            {
                ErrP.SetError(nudLessonPeriod, ex.Message);
                ok = false;
            }

            try
            {
                tl.DateTimeLesson = dtpLessonDateTime.Value;
                if (tl.DateTimeLesson.Date.AddDays(7 * (int)(nudLessonPeriod.Value)) > DateTime.Now.Date.AddYears(5))
                {
                    ErrP.SetError(dtpLessonDateTime, "The requested booking exceeds the 5 year limit of pre-planned lessons.");
                    ok = false;
                }
                else
                {
                    if (tl.DateTimeLesson.Date.DayOfWeek == DayOfWeek.Saturday || tl.DateTimeLesson.Date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        ErrP.SetError(dtpLessonDateTime, "The requested booking is on a weekend. The school only oporates on weekdays.");
                        ok = false;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrP.SetError(dtpLessonDateTime, ex.Message);
                ok = false;
            }

            try
            {
                tl.Cancellation = cbxCancellation.Checked;
            }
            catch (Exception ex)
            {
                ErrP.SetError(cbxCancellation, ex.Message);
                ok = false;
            }

            try
            {
                if (tl.Cancellation)
                    tl.CancellationReason = txtCancellationReason.Text;
            }
            catch (Exception ex)
            {
                ErrP.SetError(txtCancellationReason, ex.Message);
                ok = false;
            }

            try
            {
                tl.StudentPresent = cbxStudentPresent.Checked;
            }
            catch (Exception ex)
            {
                ErrP.SetError(cbxStudentPresent, ex.Message);
                ok = false;
            }
            return ok;
        }

        private bool UniqueSession(TimetabledLesson tl, short NoOfWeeksBooked)
        {
            string ResponseString = "The following errors were encountered:\r\n\r\n";
            bool ok = true;
            for (short week = 0; week < NoOfWeeksBooked; week++)
            {
                if (!(DataAccess.dtTimetabledLesson.Select("TutorNo = " + tl.TutorNo + " AND TimeLesson = " + tl.PeriodLesson + " AND DateLesson = '" + tl.DateTimeLesson.Date.ToString() + "'").Count() == 0))
                {
                    ok = false;
                    ResponseString += "The desired tutor is not available on " + tl.DateTimeLesson.Date.ToString("dd/MM/yyyy") + " at period " + tl.PeriodLesson + ".\r\n\r\n";
                }
                if (!(DataAccess.dtTimetabledLesson.Select("RoomNo = " + tl.RoomNo + " AND TimeLesson = " + tl.PeriodLesson + " AND DateLesson = '" + tl.DateTimeLesson.Date.ToString() + "'").Count() == 0))
                {
                    ok = false;
                    ResponseString += "The desired room is not available on " + tl.DateTimeLesson.Date.ToString("dd/MM/yyyy") + " at period " + tl.PeriodLesson + ".\r\n\r\n";
                }
                if (!(DataAccess.dtTimetabledLesson.Select("StudentNo = " + tl.StudentNo + " AND TimeLesson = " + tl.PeriodLesson + " AND DateLesson = '" + tl.DateTimeLesson.Date.ToString() + "'").Count() == 0))
                {
                    ok = false;
                    ResponseString += "The desired student is not available on " + tl.DateTimeLesson.Date.ToString("dd/MM/yyyy") + " at period " + tl.PeriodLesson + ".\r\n\r\n";
                }
                tl.DateTimeLesson = tl.DateTimeLesson.AddDays(7);
            }
            if (!ok)
                MessageBox.Show(ResponseString, "The requested lesson time is not available");
            return ok;
        }

        private void UpdateLabelForNumberOfRows()
        {
            lblRowsNo.Text = "Number of timetabled lessons: " + DataAccess.dtTimetabledLesson.Rows.Count;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            DisplayGridDataOnForm();
        }

        private void dtpLessonDateTime_ValueChanged(object sender, EventArgs e)
        {
            CheckDayOfTheWeekForMaxNud();
        }
    }
}