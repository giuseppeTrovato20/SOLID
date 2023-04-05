using System;
namespace SOLID.Badocp
{
	public class Client
	{
		public Client()
		{
		}

		public void startGame(Player player, string GameType)
		{

			switch(GameType)
			{
				case "blackjack":
					BlackJack blackJack = new BlackJack(player);
					blackJack.play();
					break;

                case "Roulette":
					Roulette roulette = new Roulette(player);
                    roulette.play();
                    break;
            }

		}
	}
}

