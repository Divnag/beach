using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beach
{
    class Hotel:Travel
    {
       


        public Hotel()
        {

        }

        public int Place(string eyecolor,double size)
        {
            if((eyecolor=="black")&& (size <= 6.5))
            {
                Num= 1;
            }
            if ((eyecolor == "black") && (size > 6.5))
            {
                Num= 2;
            }
            if ((eyecolor == "brown") && (size <= 6.5))
            {
                Num = 1;
            }
            if ((eyecolor == "brown") && (size > 6.5))
            {
                Num = 2;
            }
            if ((eyecolor == "blue") && (size <= 6.5))
            {
                Num = 1;
            }
            if ((eyecolor == "blue") && (size > 6.5))
            {
                Num = 2;
            }
            return Num;
            
        }
        
        public override void location(int num)
        {
           if(num==1)
                Console.WriteLine("You stay in Beach View Hotel" );
            if(num==2)
                Console.WriteLine("You stay in Luxury Beach Resort and Spa Hotel");
        }
    }
}
