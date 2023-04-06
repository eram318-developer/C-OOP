using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fullname fname = new Fullname();
            fname.Firstname = "Eram";
            fname.Middlename = "Bin";
            fname.Lastname = "Tanbir";

            Console.WriteLine(fname.fullname());
        }
    }
    class Fullname{
        private string firstname;
        public string Middlename;
        public string Lastname;

        public string Firstname { get => firstname; set => firstname = value; }
        public string fullname()
        {
            string fullname = firstname + " " + Middlename + " " + Lastname;
            return fullname;
        }

    }
}
