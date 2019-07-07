using System;

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
