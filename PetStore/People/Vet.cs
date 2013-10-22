using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore.Animals;

namespace PetStore.People
{
    public class Vet : Person, IVet
    {
        private Specialization specialization;
        private PhoneNumber phone;
        private List<Appointment> appointments;

        #region Constructor
        public Vet(string name, uint age, int specialization, PhoneNumber phone)
            : base(name, age)
        {
            this.Specialization = (Specialization)specialization;
            this.Phone = phone;
        }

        //optimized constructor for one phone string
        public Vet(string name, uint age, int specialization, string phone)
            : base(name, age)
        {
            this.Specialization = (Specialization)specialization;
            this.phone.mobile = phone;
        }
        #endregion

        #region Properties
        public Specialization Specialization
        {
            get { return specialization; }
            set { specialization = value; }
        }

        public PhoneNumber Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        internal List<Appointment> Appointments
        {
            get { return appointments; }
            set { appointments = value; }
        }
        #endregion

        public void AddAppointment(Appointment appointment)
        {
            this.Appointments.Add(appointment);
        }

        public void RemoveAppointment(Appointment appointment)
        {
            this.Appointments.Remove(appointment);
        }

        public string ExamineAnimal(Animal animal)
        {
            //TODO: Examine animal and return diagnose as text
            return "";
        }

        public void HealAnimal(Animal animal)
        {
            //TODO: Heal Animal with magic powers
        }

    }
}
