/** 
 * Grading ID: C6643
 * Program 0
 * Due Date: Monday Sept. 11, 2017
 * CIS 200-01
 * This program creates objects of type address and type letter, which is derived from class parcel, and outputs them to a list. **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Address home = new Address("Matthew Boling", "2912 Saratoga Ct.", "Owensboro", "Kentucky", 42303);  // Address for home
            Address apartment = new Address("Logan Payton", "631 Bellamy Circle", "Apt. 204",                   // Address for apartment
                "Louisville", "Kentucky", 42303);
            Address work = new Address("Buffalo Wild Wings", "1112 Veterans Parkway", "Clarksville", "Indiana", 41729); // Address for work
            Address mom = new Address("Nanci Boling", "1200 East Byers Ave", "Apt E524",                                // Address for mom
                "Owesnboro", "Kentucky", 42303);

            Letter paycheck = new Letter(work, home, 20.00m);   // paycheck letter
            Letter rent = new Letter(apartment, home, 5.75m);   // rent letter
            Letter w2 = new Letter(work, mom, 15.50m);          // w2 letter

            // Outputs letters into a list 
            List<Parcel> parcelList = new List<Parcel>();
            {
                Console.WriteLine(paycheck);
                Console.WriteLine(rent);
                Console.WriteLine(w2);
            }
          
            


        }
    }
}
