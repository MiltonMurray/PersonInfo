using MiltonTrainingProject.Model;
using MiltonTrainingProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltonTrainingProject.Actions
{
    public class PersonActions : IPersonInterface<Model.Person>
    {
        int IPersonInterface<Model.Person>.Add(Model.Person add)
        {
            throw new NotImplementedException();
        }

        void IPersonInterface<Model.Person>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        void IPersonInterface<Model.Person>.Update(Model.Person update)
        {
            throw new NotImplementedException();
        }
    }
}
