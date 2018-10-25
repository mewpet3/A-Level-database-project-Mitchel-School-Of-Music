using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitchell_School_of_Music
{
    class ExamEntry
    {
        //fields
        int examNo;
        int studentNo;
        DateTime dateEntry;
        float fee;
        bool paid;
        DateTime datePaid;

        //properties
        public int ExamNo
        {
            get { return examNo; }
            set
            {
                //check and set if valid
                if (Utilities.ValidNumber(value, int.MaxValue, 1))
                {
                    examNo = value;
                }
                else
                {
                    throw new InvalidDataException("Exam number must be between 1 and " + int.MaxValue + " characters long.");
                }
            }
        }

        public int StudentNo
        {
            get { return studentNo; }
            set
            {
                //check and set if valid
                if (Utilities.ValidNumber(value, int.MaxValue, 1))
                {
                    studentNo = value;
                }
                else
                {
                    throw new InvalidDataException("Student number must be between 1 and " + int.MaxValue + " characters long.");
                }
            }
        }

        public DateTime DateEntry
        {
            get { return dateEntry; }
            set
            {
                //check and set if valid
                if (Utilities.ValidDate(value, DateTime.Now.AddYears(5), DateTime.Now.Date))
                {
                    dateEntry = value;
                }
                else
                {
                    throw new InvalidDataException("The entry date for the exam must be within 5 years of now (" + DateTime.Now.Date + " - " + DateTime.Now.AddYears(5) + ").");
                }
            }
        }

        public float Fee
        {
            get { return fee; }
            set
            {
                //check and set if valid
                if (Utilities.ValidNumber(value, 1000.00, 0.00))
                {
                    fee = value;
                }
                else
                {
                    throw new InvalidDataException("Fee must be no more than £1000.00 and no less than £0.00.");
                }
            }
        }

        public bool Paid
        {
            get { return paid; }
            set
            {
                //check and set if valid
                if (Utilities.ValidBool(value))
                {
                    paid = value;
                }
                else
                {
                    throw new InvalidDataException("Payment state can only be true or false");
                }
            }
        }

        public string DatePaid
        {
            get { return datePaid.ToString(); }
            set
            {
                //check and set if valid
                if (Utilities.ValidDate(value, DateTime.Now, DateTime.Now.AddYears(-3)))
                {
                    datePaid = DateTime.Parse(value);
                }
                else
                {
                    throw new InvalidDataException("The payment must have been recieved before ths can be created, payment must have been made within the last 3 years. (" + DateTime.Now + " - " + DateTime.Now.AddYears(-3) + ").");
                }
            }
        }
    }
}
