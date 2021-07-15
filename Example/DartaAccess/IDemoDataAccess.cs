using Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Example.DartaAccess
{
    public interface IDemoDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel InsertPerson(string firstName, string lastName);
    }
}
