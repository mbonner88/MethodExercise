using System;

namespace MethodExercise
{
    class Program

    {
        //I would have appreciated an explanation of the bonus steps in the exercise video. They were confusing.

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static decimal Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static decimal Modulus(int num1, int num2)
        {
            return num1 % num2;
        }

        static void Main(string[] args)
        {

            var eggs = Add(1, 2);
            var bagels = Subtract(2, 1);
            var baconStrips = Multiply(2, 2);
            var sausageLinks = Divide(4, 2);
            var coffee = Modulus(13, 12);
         
                Console.WriteLine("Hi there, welcome to this exercise in methods in C#. What's your first name?");
                string userName = Console.ReadLine();
       
                Console.WriteLine($"Nice to meet you, {userName}. What's your favorite color?");
                string favoriteColor = Console.ReadLine();

            
                 Console.WriteLine($"I also like {favoriteColor}. Do you have a favorite animal?");
                string favoriteAnimal = Console.ReadLine();

        
                Console.WriteLine("A fine choice! For my final question, what's your favorite band?");
                string favoriteBand = Console.ReadLine();
            

                Console.WriteLine($"Thanks for your answers, {userName}. Now predicting your near future...");

                Console.WriteLine($"One day, {userName} found themselves strolling through the woods, when they heard a faint sound." +
                    $"They wandered aimlessly in search, trying to follow their ears..." +
                    $"Eventually the sound grew closer, and {userName} accelerated from a stroll to a run." +
                    $"Finally, they discovered the source: a {favoriteColor} {favoriteAnimal} singing their favorite tune by {favoriteBand}!" +
                    $"Then, all of a sudden, a bright flash! And {userName} woke up...");
            }
        }
}