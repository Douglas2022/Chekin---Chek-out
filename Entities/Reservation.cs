using System;

namespace ConsoleApp1.Entities
{
    public class Reservation
    {
        public int RoomNunber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime CheckOut { get; set; }
       
        public Reservation()
        {
        }
        public Reservation(int roomNunber, DateTime checkin, DateTime checkOut)
        {
            RoomNunber = roomNunber;
            Checkin = checkin;
            CheckOut = checkOut;
        }
        public int Duration()
        {
            TimeSpan durantion = CheckOut.Subtract(Checkin);
            return (int)durantion.TotalDays;
        }
        public override string ToString()
        {
            return " Room "
                + RoomNunber
                + " , Checkin "
                + Checkin.ToString(" dd/mm/yyyy: " )
                + " , Chekout "
                + CheckOut.ToString(" dd/mm/yyyy: " )
                + " , "
                + Duration()
                + " Night";
        }

    }
}
