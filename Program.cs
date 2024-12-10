using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace homeWorkStringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputUserName;
            string inputUserZodiac;
            int inputUserAge;

            Console.Write("Hello, state your name plaese: ");
            inputUserName = Console.ReadLine();
            Console.Write("Ok, state your zodiac sign plaese: ");
            inputUserZodiac = Console.ReadLine();
            Console.Write("And, now state your age please: ");
            inputUserAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Plese waiting you're data is moving ... move datind is 30%");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Plese waiting you're data is moving ... ... move datind is 60%");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Plese waiting you're data is moving ... .... ... move datind is 90%");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Your name is {inputUserName},you're " +
                $"{inputUserAge} years old and you're zodiac sig is " +
                $"{inputUserZodiac}, thank's for you time!)");
        }
    }
}
