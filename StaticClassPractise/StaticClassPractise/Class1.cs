using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassPractise
{

    internal class Class1
    {
        public string sname;
        public string at;
        //public int scount;
        public static int scount;

        public Class1(String songname,String author,int songcount) {
            sname = songname;
            at = author;
            scount = songcount;
        }
        public int GetSongCount()
        {
            return scount;
        }
    }
}
