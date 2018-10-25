using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitchell_School_of_Music
{
    static class DataAccess
    {
        //Create data adapters
        public static SqlDataAdapter daStudent;
        public static SqlDataAdapter daTutor;
        public static SqlDataAdapter daRoom;
        public static SqlDataAdapter daExamEntry;
        public static SqlDataAdapter daExternalExam;
        public static SqlDataAdapter daPayment;
        public static SqlDataAdapter daBlockBooking;
        public static SqlDataAdapter daTuitionChoice;
        public static SqlDataAdapter daTimetabledLesson;
        public static SqlDataAdapter daTutorTakes;

        //Create sql command builders
        public static SqlCommandBuilder cmbStudent;
        public static SqlCommandBuilder cmbTutor;
        public static SqlCommandBuilder cmbRoom;
        public static SqlCommandBuilder cmbExamEntry;
        public static SqlCommandBuilder cmbExternalExam;
        public static SqlCommandBuilder cmbPayment;
        public static SqlCommandBuilder cmbBlockBooking;
        public static SqlCommandBuilder cmbTuitionChoice;
        public static SqlCommandBuilder cmbTimetabledLesson;
        public static SqlCommandBuilder cmbTutorTakes;

        //Create dataset
        public static DataSet ds = new DataSet();

        //Create data tables
        public static DataTable dtStudent = new DataTable();
        public static DataTable dtTutor = new DataTable();
        public static DataTable dtRoom = new DataTable();
        public static DataTable dtExamEntry = new DataTable();
        public static DataTable dtExternalExam = new DataTable();
        public static DataTable dtPayment = new DataTable();
        public static DataTable dtBlockBooking = new DataTable();
        public static DataTable dtTuitionChoice = new DataTable();
        public static DataTable dtTimetabledLesson = new DataTable();
        public static DataTable dtTutorTakes = new DataTable();

        //Connection string to database
        public static string connectionString = @"Data Source = LOCALHOST; Initial Catalog=Music1; Integrated Security= true";

        //Load database student data
        public static void LoadDatabaseStudentData()
        {
            try
            {
                string sqlQuery = "select * from Student";
                daStudent = new SqlDataAdapter(sqlQuery, connectionString);
                cmbStudent = new SqlCommandBuilder(daStudent);
                daStudent.FillSchema(ds, SchemaType.Source, "Student");
                daStudent.Fill(ds, "Student");
                dtStudent = ds.Tables["Student"];
            }
            catch (Exception ex)
            {
                throw new SQLFailureException("There was a critical failure while attempting to load data from the student table: " + ex.Message);
            }
        }

        //Load database Tutor data
        public static void LoadDatabaseTutorData()
        {
            try
            {
                string sqlQuery = "select * from Tutor";
                daTutor = new SqlDataAdapter(sqlQuery, connectionString);
                cmbTutor = new SqlCommandBuilder(daTutor);
                daTutor.FillSchema(ds, SchemaType.Source, "Tutor");
                daTutor.Fill(ds, "Tutor");
                dtTutor = ds.Tables["Tutor"];
            }
            catch (Exception ex)
            {
                throw new SQLFailureException("There was a critical failure while attempting to load data from the Tutor table: " + ex.Message);
            }
        }

        //Load database Room data
        public static void LoadDatabaseRoomData()
        {
            try
            {
                string sqlQuery = "select * from Room";
                daRoom = new SqlDataAdapter(sqlQuery, connectionString);
                cmbRoom = new SqlCommandBuilder(daRoom);
                daRoom.FillSchema(ds, SchemaType.Source, "Room");
                daRoom.Fill(ds, "Room");
                dtRoom = ds.Tables["Room"];
            }
            catch (Exception ex)
            {
                throw new SQLFailureException("There was a critical failure while attempting to load data from the Room table: " + ex.Message);
            }
        }

        //Load database exam entry data
        public static void LoadDatabaseExamEntryData()
        {
            try
            {
                string sqlQuery = "select * from ExamEntry";
                daExamEntry = new SqlDataAdapter(sqlQuery, connectionString);
                cmbExamEntry = new SqlCommandBuilder(daExamEntry);
                daExamEntry.FillSchema(ds, SchemaType.Source, "ExamEntry");
                daExamEntry.Fill(ds, "ExamEntry");
                dtExamEntry = ds.Tables["ExamEntry"];
            }
            catch (Exception ex)
            {
                throw new SQLFailureException("There was a critical failure while attempting to load data from the Exam Entry table: " + ex.Message);
            }
        }

        //Load database external exam data
        public static void LoadDatabaseExternalExamData()
        {
            try
            {
                string sqlQuery = "select * from ExternalExam";
                daExternalExam = new SqlDataAdapter(sqlQuery, connectionString);
                cmbExternalExam = new SqlCommandBuilder(daExternalExam);
                daExternalExam.FillSchema(ds, SchemaType.Source, "ExternalExam");
                daExternalExam.Fill(ds, "ExternalExam");
                dtExternalExam = ds.Tables["ExternalExam"];
            }
            catch (Exception ex)
            {
                throw new SQLFailureException("There was a critical failure while attempting to load data from the External Exams table: " + ex.Message);
            }
        }

        //Load database payment data
        public static void LoadDatabasePaymentData()
        {
            try
            {
                string sqlQuery = "select * from Payment";
                daPayment = new SqlDataAdapter(sqlQuery, connectionString);
                cmbPayment = new SqlCommandBuilder(daPayment);
                daPayment.FillSchema(ds, SchemaType.Source, "Payment");
                daPayment.Fill(ds, "Payment");
                dtPayment = ds.Tables["Payment"];
            }
            catch (Exception ex)
            {
                throw new SQLFailureException("There was a critical failure while attempting to load data from the Payments table: " + ex.Message);
            }
        }

        //Load database Block booking data
        public static void LoadDatabaseBlockBookingData()
        {
            try
            {
                string sqlQuery = "select * from BlockBooking";
                daBlockBooking = new SqlDataAdapter(sqlQuery, connectionString);
                cmbBlockBooking = new SqlCommandBuilder(daBlockBooking);
                daBlockBooking.FillSchema(ds, SchemaType.Source, "BlockBooking");
                daBlockBooking.Fill(ds, "BlockBooking");
                dtBlockBooking = ds.Tables["BlockBooking"];
            }
            catch (Exception ex)
            {
                throw new SQLFailureException("There was a critical failure while attempting to load data from the Block Booking table: " + ex.Message);
            }
        }

        //Load database Tuition choice data
        public static void LoadDatabaseTuitionChoiceData()
        {
            try
            {
                string sqlQuery = "select * from TuitionChoice";
                daTuitionChoice = new SqlDataAdapter(sqlQuery, connectionString);
                cmbTuitionChoice = new SqlCommandBuilder(daTuitionChoice);
                daTuitionChoice.FillSchema(ds, SchemaType.Source, "TuitionChoice");
                daTuitionChoice.Fill(ds, "TuitionChoice");
                dtTuitionChoice = ds.Tables["TuitionChoice"];
            }
            catch (Exception ex)
            {
                throw new SQLFailureException("There was a critical failure while attempting to load data from the tuition choice table: " + ex.Message);
            }
        }

        //Lod database timetabled data
        public static void LoadDatabaseTimetabledLessonData()
        {
            try
            {
                string sqlQuery = "select * from TimetabledLesson";
                daTimetabledLesson = new SqlDataAdapter(sqlQuery, connectionString);
                cmbTimetabledLesson = new SqlCommandBuilder(daTimetabledLesson);
                daTimetabledLesson.FillSchema(ds, SchemaType.Source, "TimetabledLesson");
                daTimetabledLesson.Fill(ds, "TimetabledLesson");
                dtTimetabledLesson = ds.Tables["TimetabledLesson"];
            }
            catch (Exception ex)
            {
                throw new SQLFailureException("There was a critical failure while attempting to load data from the timetabled lessons table: " + ex.Message);
            }
        }

        //Load database tutor takes data
        public static void LoadDatabaseTutorTakesData()
        {
            try
            {
                string sqlQuery = "select * from TutorTakes";
                daTutorTakes = new SqlDataAdapter(sqlQuery, connectionString);
                cmbTutorTakes = new SqlCommandBuilder(daTutorTakes);
                daTutorTakes.FillSchema(ds, SchemaType.Source, "TutorTakes");
                daTutorTakes.Fill(ds, "TutorTakes");
                dtTutorTakes = ds.Tables["TutorTakes"];
            }
            catch (Exception ex)
            {
                throw new SQLFailureException("There was a critical failure while attempting to load data from the tutor takes table: " + ex.Message);
            }
        }
    }
}