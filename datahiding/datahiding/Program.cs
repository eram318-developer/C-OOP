using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datahiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstname = Console.ReadLine();
            Fullname fullname = new Fullname();
            fullname.setfirstname(firstname);
            string name=fullname.getname();
            Console.WriteLine(name);
            fullname.middlename = "Bin";
            fullname.lastname = "Tanbir";

            Console.WriteLine(fullname.getfullname());
        }
    }
    class Fullname
    {
        private string firstname;
        public string middlename;
        public string lastname;


        public void setfirstname(string firstname) {
            if (firstname.Length >= 2)
            {
                this.firstname = firstname;
            }
        }

        public string getname()
        {
            return firstname;
        }
        public string getfullname()
        {
            string fname = firstname + " " + middlename + " " + lastname;
            return fname;
        }
    }
}
