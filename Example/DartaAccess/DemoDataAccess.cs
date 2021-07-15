using Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.DartaAccess
{
    public class DemoDataAccess : IDemoDataAccess
    {
        private List<PersonModel> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "Onur", LastName = "Akkose" });
            people.Add(new PersonModel { Id = 1, FirstName = "Akkose", LastName = "Onur" });
        }
        public List<PersonModel> GetPeople()
        {
            return people;
        }
        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel p = new() { FirstName = firstName, LastName = lastName };
            p.Id = people.Max(x => x.Id) + 1;
            people.Add(p);
            return p;

        }
    }

}
