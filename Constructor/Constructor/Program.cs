using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Eram", "CSE", 011191182);
            Student.getinfo();
            Student st1 = new Student("Jashim", "CSE", 011191183);
            Student.getinfo();
        }
    }
    public class Student{

        public String stname;
        public String stdept;
        public int stid;
        
        public Student(String name,String dept,int id)
        {
            stname = name;
            stdept = dept;
            stid = id;
        }

        public static void getinfo()
        {
            Console.WriteLine(stname + " " + stdept + " " + stid);
        }
   }
}
