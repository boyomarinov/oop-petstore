using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore.Animals;

namespace PetStore.People
{
    interface IVet
    {
        string ExamineAnimal(Animal animal);
        void HealAnimal(Animal animal);
    }
}
