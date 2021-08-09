using System;

namespace RPSLS_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new RPSGame();
            char response;

            Console.WriteLine("Would you like to play a game of rock, paper, scissors (y or n)?");
            response = Convert.ToChar(Console.ReadLine());

            while (player.ValidateResponse(response) == false)
            {
                Console.WriteLine("Invalid imput. Plase re-enter your selection");
                response = Convert.ToChar(Console.ReadLine());
            }

            if (response == 'Y' || response == 'y')
            {
                Console.Clear();
                player.PlayGame();
            }

            Console.WriteLine("Good bye");
            Console.ReadLine();
        }
    }
}
