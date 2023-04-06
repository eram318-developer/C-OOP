using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractproperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.Name = "Eram";
            st1.stuid = 011191182;
            Console.WriteLine(st1.Name + " " + st1.id);
        }
    }
    abstract class Person
    {
        public abstract int stuid { get; set; }
        public abstract string Name { get; set; }
    }
    class Student : Person
    {
        public string name;
        public int id;
        public override int stuid
        {
            get
            {
                return id;
            }
            set
            {
                this.id = value;  
            }
        }

        public override string Name {
            get 
            {
                return name;
            }
            set 
            {
                this.name = value;
            }
        }

    }
}
