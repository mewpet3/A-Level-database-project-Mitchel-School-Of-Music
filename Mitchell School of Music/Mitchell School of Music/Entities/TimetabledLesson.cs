using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitchell_School_of_Music
{
    class TimetabledLesson
    {
        //fields
        private int tutorNo;
        private int studentNo;
        private int roomNo;
        private int bookingNo;
        private DateTime dateTimeLesson;
        private byte periodLesson;
        private bool studentPresent;
        private bool cancellation;
        private string cancellationReason;

        //properties
        public int TutorNo
        {
            get { return tutorNo;}
            set
            {
                //check and set if valid
                if (Utilities.ValidNumber(value, int.MaxValue, 1))
                {
                    tutorNo = value;
                }
                else
                {
                    throw new InvalidDataException("Entered number is not a valid number.");
                }
            }
        }

        public int StudentNo
        {
            get { return studentNo;}
            set
            {
                //check and set if valid
                if (Utilities.ValidNumber(value, int.MaxValue, 1))
                {
                    studentNo = value;
                }
                else
                {
                    throw new InvalidDataException("Entered number is not a valid number.");
                }
            }
        }

        public int RoomNo
        {
            get { return roomNo;}
            set
            {
                //check and set if valid
                if (Utilities.ValidNumber(value, int.MaxValue, 1))
                {
                    if (bool.Parse(DataAccess.dtRoom.Rows.Find(value)[3].ToString()) == false)
                    {
                        roomNo = value;
                    }
                    else
                    {
                        throw new InvalidDataException("The room selected is in-use and cannot be chosen.");
                    }
                }
                else
                {
                    throw new InvalidDataException("Entered number is not a valid number.");
                }
            }
        }

        public int BookingNo
        {
            get { return bookingNo;}
            set
            {
                //check and set if valid
                if (Utilities.ValidNumber(value, int.MaxValue, 1))
                {
                    bookingNo = value;
                }
                else
                {
                    throw new InvalidDataException("Entered number is not a valid number.");
                }
            }
        }

        public DateTime DateTimeLesson
        {
            get { return dateTimeLesson;}
            set
            {
                //check and set if valid
                if (Utilities.ValidDate(value, DateTime.Now.AddYears(5), DateTime.Parse("01/01/2017")))
                {
                    dateTimeLesson = value;
                }
                else
                {
                    throw new InvalidDataException("Your first lesson must be within 5 years from today.");
                }
            }
        }

        public byte PeriodLesson
        {
            get { return periodLesson;}
            set
            {
                //check and set if valid
                if (Utilities.ValidNumber(value, byte.MaxValue, 1))
                {
                    periodLesson = value;
                }
                else
                {
                    throw new InvalidDataException("There is a limit of " + byte.MaxValue + " and a minimum of 1.");
                }
            }
        }

        public bool StudentPresent
        {
            get { return studentPresent;}
            set
            {
                //check and set if valid
                if (Utilities.ValidBool(value))
                {
                    studentPresent = value;
                }
                else
                {
                    throw new InvalidDataException("Student present value was not recieved or was invalid, please try again. (value recieved = " + value + ").");
                }
            }
        }

        public bool Cancellation
        {
            get { return cancellation;}
            set
            {
                //check and set if valid
                if (Utilities.ValidBool(value))
                {
                    cancellation = value;
                }
                else
                {
                    throw new InvalidDataException("Cancellation value was not recieved or was invalid, please try again. (value recieved = " + value + ").");
                }
            }
        }

        public string CancellationReason
        {
            get { return cancellationReason;}
            set
            {
                //check and set if valid
                if (Utilities.ValidString(value, 0, 1000))
                {
                    cancellationReason = value;
                }
                else
                {
                    throw new InvalidDataException("The reason for cancelling must be at most 1000 characters.");
                }
            }
        }
    }
}