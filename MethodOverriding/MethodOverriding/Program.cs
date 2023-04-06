using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person c1=new Child();
            //parent class e virtual keyword laganor fole jkhn amra Person class er reference create
            //korchi tokhon eta Person class e jabe but virtual keyword laganor fole eta overriden
            //class e jabe. But virtual keyword na lagale eta person er method ke call korbe
            c1.getcon();
        }
    }

    class Person
    {
        public virtual void getcon()
        {
            Console.WriteLine("This is Parent Class");
        }
    }
    class Child : Person
    {
        public override void getcon() 
        {
            Console.WriteLine("This is Child Class");
        }
    }
}
