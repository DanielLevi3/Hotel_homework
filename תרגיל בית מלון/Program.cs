using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Room;

namespace Room
{
    class Program
    {
        static void Main(string[] args)
        {
            Guest dan = new Guest(1, "Daniel");
            Reception.CheckIn(dan);
            Guest cohenfamily = new Guest(2, "PapaCohen");
            Reception.CheckIn(cohenfamily);
         
          

        }
    }
}
