using System;
using Solid.SRP;
using Solid.SRP.Repository;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SRP
            Supplier supplier = new Supplier();
            supplier.ChangeName("Paulo Steinberg");

            ISupplierRepository repository = new SupplierRepository();
            repository.Save(supplier);
            #endregion


        }
    }
}
