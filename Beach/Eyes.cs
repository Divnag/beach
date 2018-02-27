using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beach
{
    public class Eyes : Travel
    {


        public Eyes()
        {
            this.Colors = Colors;
        }

        public override int ColorToNum(string colors)
        {
            int num =base.ColorToNum( colors);
            location(num);
                return num;
        }

        public override void location(int num)
        {
            if(num==1)
            {
                Console.WriteLine("You are going to Miami beach");
            }
           else if (num == 2)
            {
                Console.WriteLine("You are going to West Palm beach");
            }
            else if (num == 3)
            {
                Console.WriteLine("You are going to Key West beach");
            }
            else
            {
                Console.WriteLine("your eye color is unique you are gng to Myrtle beach");
            }
        }
    }
}
