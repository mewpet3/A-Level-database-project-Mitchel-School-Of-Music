using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitchell_School_of_Music
{
    class ExternalExam
    {
        //fields
        string examBoard;
        string titleExam;
        char grade;
        DateTime examDateTime;
        float examFee;
        bool acceptingEntries;
        
        //properties
        public string ExamBoard
        {
            get { return examBoard; }
            set
            {
                //check and set if valid
                if (Utilities.ValidString(value, 1, 30))
                {
                    examBoard = value;
                }
                else
                {
                    throw new InvalidDataException("Examination board name must be between 1 and 30 characters long.");
                }
            }
        }

        public string TitleExam
        {
            get { return titleExam; }
            set
            {
                //check and set if valid
                if (Utilities.ValidString(value, 1, 30))
                {
                    titleExam = value;
                }
                else
                {
                    throw new InvalidDataException("Title of exam must be between 1 and 30 characters long.");
                }
            }
        }

        public char Grade
        {
            get { return grade; }
            set
            {
                //check and set if valid
                if (Utilities.ValidChar(value))
                {
                    grade = value;
                }
                else
                {
                    throw new InvalidDataException("Grade entered is not a valid grade expected for this field.");
                }
            }
        }

        public string ExamDateStringInOut
        {
            get { return examDateTime.Date.ToString(); }
            set
            {
                //check and set if valid
                if (Utilities.ValidDate(value, DateTime.Now.AddYears(5), DateTime.Now))
                {
                    examDateTime = DateTime.Parse(value);
                }
                else
                {
                    throw new InvalidDataException("The date and time of the exam must be after " + DateTime.Now + " and within 5 years advance of today (" + DateTime.Now.AddYears(5) + ").");
                }
            }
        }

        public string ExamTimeStringInOut
        {
            get { return examDateTime.TimeOfDay.ToString(); }
            set
            {
                //check and set if valid
                if (Utilities.ValidTime(value))
                {
                    examDateTime = examDateTime.AddHours(double.Parse(value.Substring(0, 2)));
                    examDateTime = examDateTime.AddMinutes(double.Parse(value.Substring(3, 2)));
                }
                else
                {
                    throw new InvalidDataException("The entered time must be in a valid 24hour format.");
                }
            }
        }

        public DateTime ExamDateTimeInOut
        {
            get { return examDateTime; }
            set
            {
                //check and set if valid
                if (Utilities.ValidDate(value, DateTime.Now.AddYears(5), DateTime.Now))
                {
                    examDateTime = value;
                }
                else
                {
                    throw new InvalidDataException("The date and time of the exam must be after " + DateTime.Now + " and within 5 years advance of today (" + DateTime.Now.AddYears(5) + ").");
                }
            }
        }

        public float ExamFee
        {
            get
            { return examFee; }
            set
            {
                //check and set if valid
                if (Utilities.ValidNumber(value, 1000.00, 0.00))
                {
                    examFee = value;
                }
                else
                {
                    throw new InvalidDataException("The price cannot be beyond the £1000 payment point and can also not be below £0.");
                }
            }
        }

        public bool AcceptingEntries
        {
            get { return acceptingEntries; }
            set
            {
                //check and set if valid
                if (Utilities.ValidBool(value))
                {
                    acceptingEntries = value;
                }
                else
                {
                    throw new InvalidDataException("The value entered for accepting entries is not a valid true or false.");
                }
            }
        }
    }
}
