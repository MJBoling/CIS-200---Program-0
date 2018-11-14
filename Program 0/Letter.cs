/** 
 * Grading ID: C6643
 * Program 0
 * Due Date: Monday Sept. 11, 2017
 * CIS 200-01
 * This class uses the origin address and destination address from the Parcel class and adds a fixed cost property. **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    public class Letter : Parcel
    {
        public decimal FixedCost { get; }

        // Letter Constructor
        public Letter (Address originAddress, Address destinationAddress, decimal fixedCost)
            : base(originAddress,destinationAddress)
        {
            FixedCost = fixedCost;
        }
        
        public override decimal CalcCost()
        {
            return FixedCost;
        }

        // Precondition: None
        // Postcondition: The parcel's address and fixed cost of the letter are both returned as string values
        public override string ToString() =>
         $"{base.ToString()}" +
            $"Cost: {FixedCost:C}\n";


        
    }
}
