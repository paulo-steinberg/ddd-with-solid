using System;

namespace Solid.ISP.Interfaces
{
    public interface IInvoice
    {
        DateTime CreatedAt { get; set; }
        void CreateInvoice();
    }
}