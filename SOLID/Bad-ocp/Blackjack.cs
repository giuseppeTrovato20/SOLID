using System;
namespace SOLID.Badocp
{
    public class BlackJack
    {
        private Player player;

        public BlackJack(Player player)
        {
            this.player = player;
        }

        public void play()
        {
            Console.WriteLine("Start blackjack with" + player);
        }
    }
}


