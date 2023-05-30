using System;

namespace BlackJack_21
{
    class Program
    {
        static void Main(string[] args)
        {
           


            string text = "here is some text";
            File.WriteAllText(@"C:Users\tamar\Logs\log.txt", text);
            const string casinoHall = "Black Jack World";

            Console.WriteLine("Welcome to the {0}. Lets start by telling me your Name: ", casinoHall);
            string playerName = Console.ReadLine();
            Console.WriteLine("How much do you want to bet? ");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Helllo, {0}. Would you like to join a new Black Jack Game right now? ", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player newPlayer = new Player(playerName, bank);
                Player.Id = Guid.newGuid();
                using (StreamWriter file = new StreamWriter(@"C\users\tamar\Logs\log.txt", true))
                {
                    file.Write(player.Id)
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing with us! ");
            }
            Console.WriteLine("Feel free to look around the Casino. Bye for now.");
            Console.Read();
        }
    }
}


    
