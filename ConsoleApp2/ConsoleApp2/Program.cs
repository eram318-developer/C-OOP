using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int i,sum=0;
             int[] arr = new int[5]; 

             for (i = 0; i < 5; i++)
             {
                 Console.Write("\nEnter your number:\t");
                 arr[i] = Convert.ToInt32(Console.ReadLine());
             }
             Console.WriteLine("\n\n");

             foreach(int ff in arr)
             {
                 sum += ff;
             }
             Console.WriteLine(sum);
             Console.ReadLine();*/

            Class1 cls1 = new Class1("Harry Potter", "J.K Rowling","");
            cls1.printifo = "Good";
            Console.WriteLine(cls1.printifo);
        }
        
    }
}
