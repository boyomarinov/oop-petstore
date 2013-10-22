using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.People
{
    public struct PhoneNumber
    {
        public string emergencyLine;
        public string mobile;
        public string home;

        public PhoneNumber(string line, string m = "", string h = "")
        {
            emergencyLine = line;
            mobile = m;
            home = h;
        }
    }
}
