using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCollatz
{
    //The following iterative sequence is defined for the set of positive integers:
    //n → n/2 (n is even)
    //n → 3n + 1 (n is odd)
    //Using the rule above and starting with 13, we generate the following sequence:
    //13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
    //It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proven yet, it is thought that all starting numbers finish at 1.
    //Which starting number, under one thousand, produces the longest chain?
    //NOTE: Once the chain starts the terms are allowed to go above one thousand.
    class Program
    {    //i        x
        //13 * 3 = 39 ODD
        //39 + 1 = 40 EVEN
        //40 / 2 = 20
        //20 / 2 = 10
        //10 / 2 = 5
        //5 * 3 + 1 = 16 ODD
        //16 / 2 = 8
        //8 / 2 = 4
        //4 / 2 = 2
        //2 / 2 = 1


        //if n % 2 = then divide it by 2
        //if !n % 2 = then *3 + 1
        static void Main(string[] args)
        { 
            //int i = 1;
            //int x = 0; 

            //do
            //{
            //    //x++;
            //    if (x==1)//the chain is ended
            //    {

            //    }
            //    else if (i % 2 == 0)
            //    {
            //       x = i / 2;
            //    }
            //    else
            //    {
            //        x = (i * 3) + 1;
            //    }
            //    i = x;

            //} while (x < 1000);


            //int x = 0;

            //for (int i = 0; i <= 1000; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        x = i;
            //    }
            //    else
            //    {
            //        x = (i * 3) + 1;
            //    }

            //}
            //Console.WriteLine(x);


            //do
            //{
            //    x = a - b;
            //    //start at 1000/2 = 500/2 = 250/2 = 125 -1 (124/2) = 62/2 = 31 -1 (30/2) = 15 - 1 (14/2) = 7 - 1 (6/2) = 3 -1 (2/1) = 1
            //    if (a % 2 == 0)
            //    {
            //        b = a;
            //    }
            //    else
            //    {
            //        b = (b - 1) / 2;
            //    }

            //} while (x < 1000);
            //Console.WriteLine(x);
        }
    }
}
