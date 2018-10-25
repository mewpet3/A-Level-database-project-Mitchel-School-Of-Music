using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitchell_School_of_Music
{
    public class Payment
    {
        int refNo;
        int studentNo;
        string description;
        DateTime datePaid;
        float amountPaid;
        string paymentMethod;
        string responsibleEmplyee;
        string sponsor;
        string sponsorOwner;
        bool paid;

        public int RefNo
        {
            get { return refNo; }
            set
            {
                //check and set if valid
                if (Utilities.ValidNumber(value, int.MaxValue, 1))
                {
                    refNo = value;
                }
                else
                {
                    throw new InvalidDataException("Reference number entered is not a valid reference number.");
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
                    throw new InvalidDataException("Student number used is not a valid student number.");
                }
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                //check and set if valid
                if (Utilities.ValidString(value, 1, 50))
                {
                    description = value;
                }
                else
                {
                    throw new InvalidDataException("The description of the payment must be a valid description, explaining the reason for payment.");
                }
            }
        }

        public DateTime DatePaid
        {
            get { return datePaid; }
            set
            {
                //check and set if valid
                if (Utilities.ValidDate(value, DateTime.Now.Date, DateTime.Now.Date))
                {
                    datePaid = value.Date;
                }
                else
                {
                    throw new InvalidDataException("The date of the payment is not a valid date.");
                }
            }
        }

        public float AmountPaid
        {
            get { return amountPaid; }
            set
            {
                //check and set if valid
                if (Utilities.ValidNumber(value, 1000, 0))
                {
                    amountPaid = value;
                }
                else
                {
                    throw new InvalidDataException("The amount paid is not a valid amount of currency.");
                }
            }
        }

        public string PaymentMethod
        {
            get { return paymentMethod; }
            set
            {
                //check and set if valid
                if (Utilities.ValidString(value, 1, 50))
                {
                    paymentMethod = value;
                }
                else
                {
                    throw new InvalidDataException("The entered method of payment is not a valid method of payment.");
                }
            }
        }

        public string ResponsibleEmployee
        {
            get { return responsibleEmplyee; }
            set
            {
                //check and set if valid
                if (Utilities.ValidString(value, 1, 60))
                {
                    responsibleEmplyee = value;
                }
                else
                {
                    throw new InvalidDataException("The responsible employees name can be at most 60 characters, initials or recognisable signature names may be used.");
                }
            }
        }

        public string Sponsor
        {
            get { return sponsor; }
            set
            {
                //check and set if valid
                if (Utilities.ValidString(value, 1, 60))
                {
                    sponsor = value;
                }
                else
                {
                    throw new InvalidDataException("The name of a sponsor must be at most 60 characters long, a shortened name may be used if necessary.");
                }
            }
        }

        public string SponsorOwner
        {
            get { return sponsorOwner; }
            set
            {
                //check and set if valid
                if (Utilities.ValidString(value, 1, 60))
                {
                    sponsorOwner = value;
                }
                else
                {
                    throw new InvalidDataException("The owner of the sponsor, must be at most 60 characters long, a shortened name may be used if necessary.");
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
                    throw new InvalidDataException("The payments success must be indicated with the appropriate variable.");
                }
            }
        }
    }
}
