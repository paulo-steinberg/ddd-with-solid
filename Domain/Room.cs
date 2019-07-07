using System;
using System.Collections.Generic;

namespace Solid.Domain
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Room(String name)
        {
            if(String.IsNullOrEmpty(name))
                throw new Exception("Nome inválido");
            Name = name;
        }

        public void Book(DateTime startDate, DateTime endDate, List<DateTime> books)
        {

            if (books.Contains(startDate))
                throw new Exception("Sala já reservada neste horário");


        }
    }
}