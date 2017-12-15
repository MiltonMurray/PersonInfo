using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class College
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public State State { get; set; }
        public int Zip { get; set; }

        public College(int id, string name, string street, string city, State state, int zip)
        {
            ID = id;
            Name = name;
            Street = street;
            City = city;
            State = state;
            Zip = zip;
        }

        public College(System.Data.DataRow dr)
        {
            ID = (int)dr["CollegeID"];
            Name = dr["Name"].ToString();
            Street = dr["Street"].ToString();
            City = dr["City"].ToString();
            State = (State)Convert.ToInt32(dr["State"]);
            Zip = (int)dr["Zip"];
           
        }

       

        public College() { }

        public override string ToString()
        {
            return Name;
        }
    }
}
