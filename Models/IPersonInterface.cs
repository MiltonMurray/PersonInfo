using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IPersonInterface<T>
    {
        void Add(T add);
        void Delete(int id);
        void Update(T update);
    }
}
