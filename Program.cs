using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Room Number: " );
            int Number = int.Parse( Console.ReadLine() );
            Console.Write("  Checkin date ( dd/mm/yyyy ) : ");
            DateTime chekin = DateTime.Parse(Console.ReadLine());
            Console.Write("Check Out ( dd/mm/yyyy ) ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            if( checkout <= chekin)
            {
                Console.WriteLine(" Error in reservation; Check - out date must be after checkin  date ");
            }
            else
            {
                Reservation reservation = new Reservation(Number, chekin, checkout);
                Console.WriteLine("Reservation " + reservation);
            }

           

        }
    }
}
