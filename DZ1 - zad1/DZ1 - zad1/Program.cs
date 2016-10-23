using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1___zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerList list = new IntegerList();
            list.initList();
            IntegerList.ListExample(list);

            Console.Read();

        }

    }
}

