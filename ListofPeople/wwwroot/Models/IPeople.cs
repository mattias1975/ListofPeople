using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListofPeople.Models
{
    public interface IPeople
    {
      People Create(String name, string cities);
        List<IPeople> AllPeople();
        People FindByID(int id);
        People Update(People people);
        bool Delete(int id);

    }
}
