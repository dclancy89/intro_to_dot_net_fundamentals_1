using System;

namespace Fundamentals_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Print all values from 1-255
            for(int i = 1; i < 256; i++) {
                Console.WriteLine(i);
            }
            // Print all values 1-100 divisible by 3 or 5
            // but not both
            for(int i = 1; i <= 100; i++) {
                if(i % 3 == 0 && i % 5 == 0) {
                    continue;
                } 
                else if(i % 3 == 0 || i % 5 == 0) {
                    Console.WriteLine(i);
                }
            }

            // fizz buzz
            for(int i = 1; i <= 100; i++) {
                if(i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine("FizzBuzz");
                } 
                else if(i % 3 == 0) {
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0) {
                    Console.WriteLine("Buzz");
                }
                else {
                    Console.WriteLine(i);
                }
            }

            // 10 random numbers fizz buzz
            Random rand = new Random();
            int num;
            for(var i = 1; i <= 10; i++) {
                num = rand.Next();
                if(i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine("{0}, FizzBuzz", num);
                } 
                else if(i % 3 == 0) {
                    Console.WriteLine("{0}, Fizz", num);
                }
                else if(i % 5 == 0) {
                    Console.WriteLine("{0}, Buzz", num);
                }
                else {
                    Console.WriteLine(num);
                }
            }

        }
    }
}
