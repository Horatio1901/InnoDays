using System;

namespace Example.Service
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }

    public class NumberCreator
    {
        public List<string> Create(int[] numbers)
        {
            List<string> sNumbers = new List<string> { };

            for (int i = 0; i < numbers.Length; i++)
            {
                int modulo3 = numbers[i] % 3;
                int modulo5 = numbers[i] % 5;
                if (modulo3 == 0)
                {
                    sNumbers.Add("Foo");
                }
                else if (modulo5 == 0)
                {
                    sNumbers.Add("Bar");
                }
                else
                {
                    sNumbers.Add(numbers[i].ToString());
                }
            }


            return sNumbers;
        }
    }
}