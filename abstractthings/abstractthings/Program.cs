using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractthings
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Child c1=new Child();
         
        }
    }
    public class person
    {
        public int id;
        public string name;
        public int age;
        static double semesterfee;


        static person()
        {
            Console.WriteLine("This is person class Static Constructor");
        }
        public person()
        {
            Console.WriteLine("This is Person clss Default Constructor");
        }
        
    }

    class Child : person
    {
       static Child()
        {
            Console.WriteLine("This is Child class Static Constructor");
        }
        public Child()
        {
            Console.WriteLine("This is Child clss Default Constructor");
        }
      
      
    }
}
