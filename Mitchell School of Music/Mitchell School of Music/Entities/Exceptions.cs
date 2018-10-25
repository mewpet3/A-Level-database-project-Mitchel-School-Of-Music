using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitchell_School_of_Music
{
    public class InvalidDataException : Exception
    {
        public InvalidDataException()
        {

        }

        public InvalidDataException(string Message) : base(Message)
        {

        }
    }

    class SQLFailureException : Exception
    {
        public SQLFailureException()
        {

        }

        public SQLFailureException(string Message) : base(Message)
        {

        }
    }
}
