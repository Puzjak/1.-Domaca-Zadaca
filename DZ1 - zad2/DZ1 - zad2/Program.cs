using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1___zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            IGenericList<string> stringList = new GenericList<string>();
            stringList.Add(" Hello ");
            stringList.Add(" World ");
            stringList.Add("!");
            Console.WriteLine(stringList.GetElement(0) + stringList.GetElement(1) + stringList.GetElement(2));
            stringList.Clear();
            stringList.Add("1");
            stringList.Add("2");
            stringList.Add("3");
            stringList.Add("4");
            stringList.Add("5");
            stringList.Add("6");
            stringList.RemoveAt(4);
            stringList.Remove("1");
            Console.WriteLine(stringList.GetElement(0) + stringList.GetElement(1) + stringList.GetElement(2) + stringList.GetElement(3));
            Console.Read();

        }
    }
}
