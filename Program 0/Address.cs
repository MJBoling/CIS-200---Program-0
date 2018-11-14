/**
 * Grading ID: C6643
 * Program 0
 * Due Date: Monday Sept. 11, 2017
 * CIS 200-01
 * This class takes various properties such as Name, address, city, state, and zip code in order to create address objects. **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    public class Address
    {
        public string Name { get; }     
        public string AddressLine1 { get; }
        public string AddressLine2 { get; }
        public string City { get; }
        public string State { get; }
        public int zipCode;

        // Address constructor which includes addressLine2
        public Address(string name, string addressLine1, string addressLine2, string city, string state, int zipCode)
        {
            Name = name;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        // Overloaded Constructor which does not include addressLine2
        public Address(string name, string addressLine1, string city, string state, int zipCode)
        {
            Name = name;
            AddressLine1 = addressLine1;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        // ZipCode Property
        public int ZipCode
        {
            // Precondition: None
            // Postcondition: zipCode has been returned
            get { return zipCode; }

            // Precondition: A zip code should be entered to fulfill the ZipCode property
            // Postcondition: If a zip code has been entered between 00000-99999 it will be assigned to value, if not 
            // an error message will pop up 
            set
            {
                if (value < 0 || value > 99999)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(ZipCode)} must be between 00000-99999");
                }
                else zipCode = value;
            }
        }

        // Precondition: None
        // Postcondition: The name, address, state, city, and zip code will be returned in a string format
        public override string ToString() =>
            $"{Name}\n" +
            $"{AddressLine1}\n" +
            $"{((string.IsNullOrWhiteSpace(AddressLine2)) ? $"{City}, {State} {ZipCode:D5}\n" : $"{AddressLine2}\n" + $"{City}, {State} {ZipCode:D5}\n")}";
     }
}

    

