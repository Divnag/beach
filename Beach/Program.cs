using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beach
{
    class Program
    {
        static void Main(string[] args)
        {
            Eyes eyes = new Eyes();
            Hotel hotel = new Hotel();
            Console.WriteLine("Enter the color of your eyes to decide the beach you are going");
            string color = Console.ReadLine().ToLower();
            Console.WriteLine("Enter your shoe size");
            double size = double.Parse(Console.ReadLine());
            eyes.ColorToNum(color);
            hotel.location(hotel.Place(color,size));
            
            
            }
    }
}
