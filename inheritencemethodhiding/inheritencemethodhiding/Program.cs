using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritencemethodhiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent p1=new Parent();
            Child1 c1=new Child1();
            Child2 c2 = new Child2();

            p1.firstname = "Eram";
            p1.secondname = "Bin Tanbir";

            c1.firstname = "Eku";
            c1.secondname = "Chowdhury";
            //child1 er object create korlam though ekhane parent er referencce ache 
            //But c1 ke call dile Eku Chowdhury print korbe.I mean though parent er reference
            //create hocce but eikhne child er jinish print hocce. I mean parent er method hide thaktese
            //etai method hiding.

            c2.firstname = "Jashim";
            c2.secondname = "Uddin";

            c1.fullname();
            
        }
    }

    class Parent
    {
        public string firstname;
        public string secondname;
        
        public void fullname()
        {
            string fullname = firstname + " " + secondname;
            Console.WriteLine( fullname );
        }
    }
    class Child1 : Parent
    {
        public new void fullname()
        {
            base.fullname();//Jodi child class er object call kore parent er jinish call dite chai
            string fullname = firstname + " " + secondname + " " + "Child1";
            Console.WriteLine(fullname);
        }
    }
    class Child2 : Parent
    {
        public new void fullname()
        {
            string fullname = firstname + " " + secondname + " " + "Child2";
            Console.WriteLine(fullname);
        }
    }
}
