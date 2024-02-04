using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Player> players = new List<Player>();

            /*
            Player player1 = new Player("Chad");
            Player player2 = new Player("Steve");
            Player player3 = new Player("Karen");
            */

            players.Add(new Player("Chad"));
            players.Add(new Player("Steve"));
            players.Add(new Player("Karen"));

            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }


            Console.ReadKey();
        }
    }

    class Player
    {
        public string username;

        public Player(string username)
        {
            this.username = username;
        }
        public override string ToString()
        {
            return username;
        }
    }
}