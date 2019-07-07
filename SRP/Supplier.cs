namespace Solid.SRP
{
    public class Supplier
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public void ChangeName(string name)
        {
            Name = name;
        }

    }
}
