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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open Students form
            frmStudent NewForm = new frmStudent();
            Utilities.OpenNewForm(this, NewForm, false);
        }

        private void examsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open Exams form
            frmExternalExam NewForm = new frmExternalExam();
            Utilities.OpenNewForm(this, NewForm, false);
        }

        private void pastPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open Past payments form
            frmPaymentHistory NewForm = new frmPaymentHistory();
            Utilities.OpenNewForm(this, NewForm, false);
        }

        private void examEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open ExamEntries form
            frmExamEntry NewForm = new frmExamEntry();
            Utilities.OpenNewForm(this, NewForm, false);
        }

        private void bookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open bookings form
            frmBlockBooking NewForm = new frmBlockBooking();
            Utilities.OpenNewForm(this, NewForm, false);
        }

        private void timetabledLessonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open TimeTabled Lessons form
            frmTimetabledLesson NewForm = new frmTimetabledLesson();
            Utilities.OpenNewForm(this, NewForm, false);
        }

        private void lessonTimetableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open Lesson Timetable form
            frmLessonTimetable NewForm = new frmLessonTimetable();
            Utilities.OpenNewForm(this, NewForm, false);
        }

        private void tutorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open Tutors form
            frmTutor NewForm = new frmTutor();
            Utilities.OpenNewForm(this, NewForm, false);
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open Rooms form
            frmRoom NewForm = new frmRoom();
            Utilities.OpenNewForm(this, NewForm, false);
        }

        private void studentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Open Students report form
            frmStudentReport NewForm = new frmStudentReport();
            Utilities.OpenNewForm(this, NewForm, false);
        }

        private void tutorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Open Tutors report form
            frmTutorReport NewForm = new frmTutorReport();
            Utilities.OpenNewForm(this, NewForm, false);
        }

        private void bookingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Open Bookings report form
            frmBlockBookingReport NewForm = new frmBlockBookingReport();
            Utilities.OpenNewForm(this, NewForm, false);
        }

        private void paymentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Open Payments report form
            frmPaymentHistoryReport NewForm = new frmPaymentHistoryReport();
            Utilities.OpenNewForm(this, NewForm, false);
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Shut down application when menu is closed
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}