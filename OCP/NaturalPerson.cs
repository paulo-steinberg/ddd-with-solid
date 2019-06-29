namespace Solid.OCP
{
    public class NaturalPerson : Person
    {
        //CPF is the brazilian's social security.
        public string CPF { get; private set; }

        public NaturalPerson(string name, string cpf) : base(name) => CPF = cpf;
    }
}