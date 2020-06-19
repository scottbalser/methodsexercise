using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("Where do you live?");
            string userHome = Console.ReadLine();

            Console.WriteLine("Whats your favorite sport?");
            string userSport = Console.ReadLine();

            Console.WriteLine("Whats your favorite team?");
            string userFavteam = Console.ReadLine();

            Console.WriteLine($"{userName} lives in {userHome}");
            Console.WriteLine($"{userName} loves to watch {userSport}");
            Console.WriteLine($" GO {userFavteam}");






        }
    }
}
