using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 sng = new Class1("Hello", "Eram", 2);
            Class1 sng1 = new Class1("Hello", "Eram", 3);
            /*Console.WriteLine(sng.GetSongCount());
            Console.WriteLine(sng1.GetSongCount());*/

            Console.WriteLine(Class1.scount);
        }
    }
}
