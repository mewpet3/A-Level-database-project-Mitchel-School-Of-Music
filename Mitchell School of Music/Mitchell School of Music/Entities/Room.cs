using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitchell_School_of_Music
{
    class Room
    {
        //fields
        string roomType;
        ushort capacity;
        bool inUse;
        
        //properties
        public string RoomType
        {
            get { return roomType; }
            set
            {
                //check and set if valid
                if (Utilities.ValidString(value, 1, 20))
                {
                    roomType = value;
                }
                else
                {
                    throw new InvalidDataException("The room type must not be longer than 20 characters, a shortened word or phrase may be used instead");
                }
            }
        }
        public ushort Capacity
        {
            get { return capacity; }
            set
            {
                //check and set if valid
                if (Utilities.ValidNumber(value, 1000, 1))
                {
                    capacity = value;
                }
                else
                {
                    throw new InvalidDataException("The capacity entered is not a valid capacity. The maximum capacity allowed is 1000.");
                }
            }
        }
        public bool InUse
        {
            get { return inUse; }
            set
            {
                //check and set if valid
                if (Utilities.ValidBool(value))
                {
                    inUse = value;
                }
                else
                {
                    throw new InvalidDataException("");
                }
            }
        }
    }
}
