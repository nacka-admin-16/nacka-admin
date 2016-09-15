using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExamples.interfaces
{
    public class Person : IPerson
    {
        public int GetAge()
        {
            return 25;
        }

        public string GetName()
        {
            return "Carl";
        }
    }
}
