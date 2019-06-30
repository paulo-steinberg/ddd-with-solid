using System;
using Solid.LSP;
using Solid.OCP;
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

            #region OCP
            Person person = new Person("Paulo");
            person.ChangeName("Paulo Steinberg");

            NaturalPerson nPerson = new NaturalPerson("Paulo Steinberg", "123.123.123.12");
            #endregion

            #region LSP
            Car car = new Car();
            car.TurnOn();
            car.SpeedUp();
            #endregion
        }
    }
}
