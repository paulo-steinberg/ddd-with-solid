using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.SRP.Repository
{
    public class SupplierRepository : ISupplierRepository
    {
        public void Save(Supplier supplier)
        {
            Console.WriteLine("Saved");
        }
    }
}
