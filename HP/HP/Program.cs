using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write(
                        //x<y //01.jpg
                        //x==y //02.jpg
                        //x == 24-y //03.jpg
                        //x <= 29-y //04.jpg
                        //x == y/2 //05.jpg
                        //x < 10 || y<10 // 06.jpg
                        //x >15 & y>15 // 07.jpg
                        //x <1 || y < 1 //08.jpg
                        //y > x+ 10 || y < x - 10 //09.jpg
                        //y > x & y < 2 * x + 2 // 10.jpg
                        //x == 1 || x == 23 || y ==1 || y == 23 // 11.jpg
                        //y*y+x*x < 21*21 //12.jpg
                        //y >-x+19 & y<-x+29 //13.jpg
                        //(x-25)*(x-25)+(y-25)*(y-25) > 21*21 //14.jpg
                        //(y > x + 9 & y<x+21) || (y < x - 9 & y> x-21) //15.jpg
                        y>x-10 & y<x+10 & y >= -x +15& y<=-x+33 //16.jpg
                        ? "# " : ". ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
