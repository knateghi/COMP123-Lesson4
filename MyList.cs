using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson4
{
    class MyList:List<int>
    {
        public void Print()
        {
            Console.WriteLine("I'm printing");
        }
    }
}
