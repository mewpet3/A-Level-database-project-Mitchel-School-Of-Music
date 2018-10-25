using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitchell_School_of_Music
{
    class Tutor
    {
        //fields
        string firstName;
        string surname;
        string address;
        string town;
        string postCode;
        string email;
        DateTime dOB;
        bool gender;
        bool disability;
        string contactTelNo;
        string nextOfKin;
        DateTime dateJoined;
        DateTime dateLeft;
        bool currentTutor;

        //properties
        public string FirstName
        {
            get { return firstName; }
            set
            {
                //check and set if valid
                if (Utilities.ValidString(value, 1, 30))
                {
                    firstName = value;
                }
                else
                {
                    throw new InvalidDataException("Firstname must be between 1 and 30 characters long.");
                }
            }
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                //check and set if valid
                if (Utilities.ValidString(value, 1, 30))
                {
                    surname = value;
                }
                else
                {
                    throw new InvalidDataException("Surname must be between 1 and 30 characters long.");
                }
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                //check and set if valid
                if (Utilities.ValidString(value, 6, 30))
                {
                    address = value;
                }
                else
                {
                    throw new InvalidDataException("Address must be between 6 and 30 characters long.");
                }
            }
        }

        public string Town
        {
            get { return town; }
            set
            {
                //check and set if valid
                if (Utilities.ValidString(value, 1, 30))
                {
                    town = value;
                }
                else
                {
                    throw new InvalidDataException("Town must be between 1 and 30 characters long.");
                }
            }
        }

        public string PostCode
        {
            get { return postCode; }
            set
            {
                //check and set if valid
                if (Utilities.ValidString(value, 6, 9))
                {
                    //check and set if valid
                    if (Utilities.ValidPostcode(value))
                    {
                        postCode = value;
                    }
                    else
                    {
                        throw new InvalidDataException("Postcode must be a valid postcode.");
                    }
                }
                else
                {
                    throw new InvalidDataException("Postcode must be between 6 and 9 characters long.");
                }
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                //check and set if valid
                if (Utilities.ValidString(value, 5, 50))
                {
                    email = value;
                }
                else
                {
                    throw new InvalidDataException("Email must be between 5 and 50 characters long.");
                }
            }
        }

        public string DOB
        {
            get { return dOB.ToString(); }
            set
            {
                //check and set if valid
                if (Utilities.ValidDate(value, DateTime.Now, DateTime.Now.AddYears(-100)))
                {
                    dOB = DateTime.Parse(value);
                }
                else
                {
                    throw new InvalidDataException("Date of birth must be a valid date between the years " + DateTime.Now.Year + " and " + DateTime.Now.AddYears(-100) + ".");
                }
            }
        }

        public bool Gender
        {
            get { return gender; }
            set
            {
                //check and set if valid
                if (Utilities.ValidBool(value))
                {
                    gender = value;
                }
                else
                {
                    throw new InvalidDataException("Please enter a value for gender.");
                }
            }
        }

        public bool Disability
        {
            get { return disability; }
            set
            {
                //check and set if valid
                if (Utilities.ValidBool(value))
                {
                    disability = value;
                }
                else
                {
                    throw new InvalidDataException("Please enter a value for disability.");
                }
            }
        }

        public string ContactTelNo
        {
            get { return contactTelNo; }
            set
            {
                //check and set if valid
                if (Utilities.ValidString(value, 13, 13))
                {
                    if (Utilities.ValidTelNo(value))
                    {
                        contactTelNo = value;
                    }
                    else
                    {
                        throw new InvalidDataException("Telephone number must be a valid telephone number.");
                    }
                }
                else
                {
                    throw new InvalidDataException("Telephone number must be a valid number between 8 and 12 characters long.");
                }
            }
        }

        public DateTime DateJoined
        {
            get { return dateJoined; }
            set
            {
                //check and set if valid
                if (Utilities.ValidDate(value, DateTime.Now.Date, DateTime.Now.Date))
                {
                    dateJoined = value;
                }
                else
                {
                    throw new InvalidDataException("Date joined is in an incorrect format.");
                }
            }
        }

        public string DateLeft
        {
            get { return dateLeft.ToString(); }
            set
            {
                //check and set if valid
                if (Utilities.ValidDate(value, DateTime.Now, dateJoined))
                {
                    dateLeft = DateTime.Parse(value);
                }
                else
                {
                    throw new InvalidDataException("Date left must be between either " + DateTime.Now + " and the date the person joined (" + dateJoined + ").");
                }
            }
        }

        public bool CurrentTutor
        {
            get { return currentTutor; }
            set
            {
                //check and set if valid
                if (Utilities.ValidBool(value))
                {
                    currentTutor = value;
                }
                else
                {
                    throw new InvalidDataException("Input a value for wheather this is a current tutor.");
                }
            }
        }

        public string NextOfKin
        {
            get { return nextOfKin; }
            set
            {
                //check and set if valid
                if (Utilities.ValidString(value, 3, 60))
                {
                    nextOfKin = value;
                }
                else
                {
                    throw new InvalidDataException("Next of kin name must be between 3 and 60 characters long.");
                }
            }
        }
    }
}