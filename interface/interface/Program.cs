using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    internal class Program
    {
        static void Main(string[] args)
        {           
          //pp1 pp1= new pp1();
          //pp1.print1();
          //pp1.print2();
          //pp1.print3();

         i2 myinterface= new pp1();
         //myinterface.print1();
         myinterface.print2();
         //myinterface.print3();
        }
    }
    interface i1
    {
        void print1();
    }
    interface i2
    {
        void print2();
    }
    interface i3:i1,i2
    {
        void print3();
    }
    class pp1:i3
    {
     public void print1() 
        {
            Console.WriteLine("Holla");
        }
    public void print2()
        {
            Console.WriteLine("Eram");
        }
    public void print3()
        {
            Console.WriteLine("Bin Tanbir");
        }
    }
}
