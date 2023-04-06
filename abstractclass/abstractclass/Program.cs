using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Student st1=new Student();
            Dummy dm=new Dummy1();
            dm.pp();

            
        }
    }

    abstract class Person
    {
        public int id;
        public string name;
        public int age;


        public abstract void printdetails();
    }
    class Student : Person
    {
        public override void printdetails()
        {
         
        }
    }

    class Dummy
    {
        public virtual void pp()
        {
            Console.WriteLine("This is Parent Class");
        }
    }

    class Dummy1 : Dummy
    {
        public override void pp() 
        {
            Console.WriteLine("This is child class");
        }
    }
   
}
