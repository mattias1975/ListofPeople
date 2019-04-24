using System.Collections.Generic;

namespace ListofPeople.Controllers
{
    public interface IPeopleRespontity
    {
        People Create(string name, string phone, string cities);
        List<People> AllPeople();
        People FindByID(int id);
        People update(People people);
        bool Delete(int id);


    }
}