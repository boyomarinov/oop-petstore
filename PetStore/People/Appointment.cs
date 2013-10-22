using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.People
{
    public struct Appointment
    {
        public Customer customer;
        public DateTime date;

        public Appointment(Customer c, DateTime d)
        {
            customer = c;
            date = d;
        }
    }
}
