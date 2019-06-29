using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.SRP.Repository
{
    public interface ISupplierRepository
    {
        void Save(Supplier supplier);
    }
}
