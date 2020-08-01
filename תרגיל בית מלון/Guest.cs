using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room
{
    public class Guest
    {
        private int _id;
        private string _name;
        public Guest(int id,string name)
        {
            this._id= id;
            this._name = name;
        }
        public int GetId()
        {
            return _id;
        }
        public string GetName()
        {
            return _name;
        }

        public override string ToString()
        {
            return $"Name : {_name}";
        }
    }
}
