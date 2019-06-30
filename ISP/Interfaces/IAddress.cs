namespace Solid.ISP.Interfaces
{
    public interface IAddress
    {
        string City { get; set; }
        string State { get; set; }
        string Country { get; set; }
    }
}