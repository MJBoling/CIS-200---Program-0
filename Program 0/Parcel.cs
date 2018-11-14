/** 
 * Grading ID: C6643
 * Program 0
 * Due Date: Monday Sept. 11, 2017
 * CIS 200-01
 * This class creates an object, parcel, which has address objects Origin Address and Destination Address. **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    public abstract class Parcel
    {
        // Backing fields
        private Address originAddress;
        private Address destinationAddress;

        // Parcel Constructor
        public Parcel (Address originAddress, Address destinationAddress)
        {
            OriginAddress = originAddress;
            DestinationAddress = destinationAddress;
        }

        // OriginAddress Property
        public Address OriginAddress
        {
            // Precondition: None
            // Postcondition: originAddress is returned
            get { return originAddress;}

            // Precondition: None
            // Postcondition: originAddress is set to value
            set { originAddress = value; }
        }

        // DestinationAddress Property
        public Address DestinationAddress
        {
            // Precondition: None
            // Postcondition: destinationAddress is set to value
            get { return destinationAddress;}
            set { destinationAddress = value;}
        }

        public abstract decimal CalcCost();

        // Precondition: None
        // Postcondition: Origin Address and Destination Address are returned as string values
        public override string ToString() =>
            $"Origin Address:\n" +
            $"{originAddress}\n" +
            $"Destination Address:\n"+
            $"{destinationAddress}\n";


    }
}

