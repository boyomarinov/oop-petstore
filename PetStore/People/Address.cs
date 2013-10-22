using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.People
{
    public struct Address
    {
        public string city;
        public string street;
        public int streetNumber;

        public Address(string addressCity, string addressStreet, int addressStreetNumber = 1)
        {
            city = addressCity;
            street = addressCity;
            streetNumber = addressStreetNumber;
        }
    }
}
