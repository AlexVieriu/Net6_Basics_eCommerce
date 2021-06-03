using eCommerce_UI.Notes._03_Blazor_In_Depth.Model;
using System.Collections.Generic;

namespace eCommerce_UI.Notes._03_Blazor_In_Depth
{
    public interface IPersonRepository
    {
        List<Person> GetPersonsByFilter(string filter = null);
        Person GetPersonbyId(int id);
    }
}