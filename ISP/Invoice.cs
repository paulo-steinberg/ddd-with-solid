using System;
using Solid.ISP.Interfaces;

namespace Solid.ISP
{
    public class Invoice : IInvoice, IAddress
    {
        public DateTime CreatedAt { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public void CreateInvoice()
        {
            //Creates new invoice.
        }
    }
}