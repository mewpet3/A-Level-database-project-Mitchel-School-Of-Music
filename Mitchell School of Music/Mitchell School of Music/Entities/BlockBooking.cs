using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitchell_School_of_Music
{
    class BlockBooking
    {
        //fields
        private int studentNo;
        private DateTime dateBooking;
        private string tuitionChoice;
        private char abilityLevel;
        private Int16 noLessons;
        private byte discountRate;
        private float lessonRate;
        private float totalDue;
        private bool paid;
        private bool waitingList;

        //properties
        //StudentNo property
        public int StudentNo
        {
            get { return studentNo; }
            set
            {
                try
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
                catch (Exception ex) when (!(ex is InvalidDataException))
                {

                }
            }
        }

        //Date property
        public DateTime DateBooking
        {
            get { return dateBooking; }
            set
            {
                //check and set if valid
                if (Utilities.ValidDate(value, DateTime.Now, DateTime.MinValue.Date))
                {
                    dateBooking = value;
                }
                else
                {
                    throw new InvalidDataException("The date specified is not valid.");
                }
            }
        }

        public string TuitionChoice
        {
            get { return tuitionChoice; }
            set
            {
                //check and set if valid
                if (Utilities.ValidString(value, 1, 50))
                {
                    tuitionChoice = value;
                }
                else
                {
                    throw new InvalidDataException("The entered set of characters must be a valid set within the range of 1 - 50 characters.");
                }
            }
        }

        public char AbilityLevel
        {
            get { return abilityLevel; }
            set
            {
                //check and set if valid
                if (Utilities.ValidChar(value))
                {
                    abilityLevel = value;
                }
                else
                {
                    throw new InvalidDataException("Entered ability level is not one of the ability levels available. Please enter an appropriate ability level.");
                }
            }
        }

        public Int16 NoLessons
        {
            get { return noLessons; }
            set
            {
                //check and set if valid
                if (Utilities.ValidNumber(value, Int16.MaxValue, 3))
                {
                    noLessons = value;
                }
                else
                {
                    throw new InvalidDataException("The number of lessons planned must be between 3 and " + Int16.MaxValue + ".");
                }
            }
        }

        public byte DiscountRate
        {
            get { return discountRate; }
            set
            {
                //check and set if valid
                if (Utilities.ValidNumber(value, 100, 0))
                {
                    discountRate = value;
                }
                else
                {
                    throw new InvalidDataException("The rate of discount goes beyond the percentage range of a discount (0 - 100).");
                }
            }
        }

        public float LessonRate
        {
            get { return lessonRate; }
            set
            {
                //check and set if valid
                if (Utilities.ValidNumber(value, float.MaxValue, 0))
                {
                    lessonRate = value;
                }
                else
                {
                    throw new InvalidDataException("The Lesson rate specified goes beyond the allowed range (" + float.MaxValue + " - " + 0 + ").");
                }
            }
        }

        public float TotalDue
        {
            get { return totalDue; }
            set
            {
                //check and set if valid
                if (Utilities.ValidNumber(value, float.MaxValue, 0))
                {
                    totalDue = value;
                }
                else
                {
                    throw new InvalidDataException("The total due value is not an acceptable value within the range of " + float.MaxValue + " - 0.");
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
                    throw new InvalidDataException("Error occured with the state of the payment.");
                }
            }
        }

        public bool WaitingList
        {
            get { return waitingList; }
            set
            {
                //check and set if valid
                if (Utilities.ValidBool(value))
                {
                    waitingList = value;
                }
                else
                {
                    throw new InvalidDataException("Error occured with the state of the payment.");
                }
            }
        }
    }
}
