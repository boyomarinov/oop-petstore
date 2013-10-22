using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    class StoreAPI
    {
        private Store store;
        
        public StoreAPI(Store store)
        {
            this.Store = store;
        }

        public Store Store
        {
            get { return store; }
            set { store = value; }
        }

        public void InitStore()
        {
            
        }

    }
}
