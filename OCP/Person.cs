
using System;

namespace Solid.OCP
{
    public class Person
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Person(string name)
        {
            if (name.Length <= 3)
                throw new Exception("Person's name is invalid.");
        }

        public void ChangeName(string newName)
        {
            if (newName.Length <= 3)
                throw new Exception("Person's name is invalid.");
            Name = newName;
        }

    }
}