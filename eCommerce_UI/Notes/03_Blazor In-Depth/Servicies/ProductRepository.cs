using eCommerce_UI.Notes._03_Blazor_In_Depth.Model;
using System.Collections.Generic;
using System.Linq;

namespace eCommerce_UI.Notes._03_Blazor_In_Depth
{
    public class PersonRepository : IPersonRepository
    {
        private readonly List<Person> Persons;
        public PersonRepository()
        {
            Persons = new()
            {
                new Person() { Id = 1, FullName = "Vieriu Alexandru" },
                new Person() { Id = 2, FullName = "Dumitrascu Alexandru" },
                new Person() { Id = 3, FullName = "Cercel Cristian" }
            };
        }

        public List<Person> GetPersonsByFilter(string filter = null)
        {
            if (string.IsNullOrWhiteSpace(filter))
                return Persons;

            var personsFiltered = Persons.Where(q => q.FullName.ToLower().Contains(filter.ToLower())).ToList();

            return personsFiltered;
        }

        public Person GetPersonbyId(int Id)
        {
            return Persons.Where(q => q.Id == Id).FirstOrDefault();
        }
    }
}
