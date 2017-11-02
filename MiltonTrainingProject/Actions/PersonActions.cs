using MiltonTrainingProject.Model;
using MiltonTrainingProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltonTrainingProject.Actions
{
    public class PersonActions : IPersonInterface<Person>
    {
        int IPersonInterface<Person>.Add(Person add)
        {
            throw new NotImplementedException();
        }

        void IPersonInterface<Person>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        void IPersonInterface<Person>.Update(Person update)
        {
            throw new NotImplementedException();
        }
    }
}
