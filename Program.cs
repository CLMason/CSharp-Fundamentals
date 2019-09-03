using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a loop that prints all values from 1-255
            //FOR LOOP
            // for(int i=1; i<= 255; i++)
            // {
            //     Console.WriteLine(i);
            // }
            //WHILE LOOP
            // int i =1;
            // while (i <=255)
            // {
            //     Console.WriteLine(i);
            //     i = i+ 1;
            // }
            ///Create a new loop that prints all values from 1- 100 that are divisible by 3 or 5, but not both
            // for (int i = 1; i <= 100; i++)
            // {
            //     if (i % 3 == 0 && i % 5 == 0)
            //     {
            //         continue;
            //     }

            //     else if (i % 3 == 0 || i % 5 == 0)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }
            //Modify the previous loop to print "fizz" for multiplies of 3, "buzz" for multiples of 5, and "fizzbuzz" for numbers that are multiples of both
            for (int i =1; i <=100; i ++)
            {
                if (i % 3 ==0 && i % 5 ==0)
                {
                    Console.WriteLine("Fizzbuzz");
                }
                if (i % 5 ==0)
                {
                    Console.WriteLine ("Buzz");
                }
                else if (i % 3 ==0){
                    Console.WriteLine("Fizz");
                }
            }

        }
    }

}
