using System;
using System.Diagnostics;

namespace MethodsExercise
{
    //[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi what's your name");
            var name = Console.ReadLine();
            Console.WriteLine($"Hi, {name}!  How are you?");
            Console.WriteLine("Hi what's your favortie color");
            var color = Console.ReadLine();
            Console.WriteLine($"Hi, {color}!");
            Console.WriteLine("Whats your favorite animal?");
            var animal = Console.ReadLine();
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine("Whats your favorite band?");
            var band = Console.ReadLine();
            Console.WriteLine($"Favorite Band: {band}");
            //Exercise ll
            Console.WriteLine("Hello World!");
            var sum = Console.ReadLine();

            var results = Add(10, 20);
            var times = Multiply(10, 20);
        }
        public static int Add(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }
        public static int Multiply(int num1, int num2)
        {
            var answer = num1 * num2;
            return answer;


        }
    }
}


