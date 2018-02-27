using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beach
{
    public class Travel
    {
        public string Colors { get; set; }
        public int Num { get; set; }

        public Travel()
        {

        }
        
        //methods
        

        public virtual int ColorToNum(string colors)
        {
            if (colors == "black")
            {
                Num = 1;

            }

            else if (colors == "brown")
            {
                Num = 2;

            }
            else if (colors == "blue")
            {
                Num = 3;
            }
            else
            {
                Num = 4;
            }
            return Num;
        }



        public virtual void location(int num)
        {

        }
    }
}
