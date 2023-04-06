using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class1
    {
        public string tt;
        public string at;
        private string rt;
        public Class1(String title,String author,String rating) 
        {
            tt = title;
            at = author;
            rt = rating;
        }
        public string printifo
        {
            get { return rt; }
            
            set
            { 
              if(value == "Good"|| value == "Better" || value == "Best" || value == "Bad")
                {
                    rt = value;
                }
                else
                {
                    rt= "N/A";
                }
            }           
        }
    }
}
