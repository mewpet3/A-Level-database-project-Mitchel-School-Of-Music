using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitchell_School_of_Music
{
    class TutorTakes
    {
        private int tutorNo;
        private string tuitionChoice;
        private char teachUpTo;

        public int TutorNo
        {
            get { return tutorNo; }
            set
            {
                //check and set if valid
                if (Utilities.ValidNumber(value, int.MaxValue, 1))
                {
                    tutorNo = value;
                }
                else
                {
                    throw new InvalidDataException(value + " was not a valid number as specified.");
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
                    throw new InvalidDataException(value + " was not a valid set of characters as specified.");
                }
            }
        }

        public char TeachUpTo
        {
            get { return teachUpTo; }
            set
            {
                //check and set if valid
                if (Utilities.ValidChar(value))
                {
                    teachUpTo = value;
                }
                else
                {
                    throw new InvalidDataException(value + " was not a valid set of characters as specified.");
                }
            }
        }
    }
}
