using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Products
{
    public interface IDataFactory
    {
        List<PetProduct> ExtactData();
    }
}
