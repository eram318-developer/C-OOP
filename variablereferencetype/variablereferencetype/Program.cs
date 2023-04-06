using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variablereferencetype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fullname p1 = new Fullname();
            Fullname p2 = new Fullname();
            p1.firstname = "Eram";
            p1.mname = "Bin";
            p1.lname = "Tanbir";
            p2 = p1;
            Console.WriteLine(p1.getfullname());
           
            Console.WriteLine(p2.getfullname());

            //int fnum = 100;
            //int sname = fnum;
            //fnum = 300;
            //Console.WriteLine(sname);
        }
    }
    class Fullname{ 
       
        public string firstname; 
        public string mname;
        public string lname;

        public string getfullname() { 
        
           string fullname=firstname+" "+mname+" "+lname;
           return fullname;
        }
    }
}
