using EticaretWFA.Entities;
using EticaretWFA.FakeDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretWFA.DAL
{
    public class PersonRepository
    {
        public void AddPerson(Person person)
        {
            person.PersonId = (++DataBase.PersonId);
            DataBase.people.Add(person);
        }
    }
}
