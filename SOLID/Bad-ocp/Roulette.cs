using System;
namespace SOLID.Badocp
{
	public class Roulette
	{
		private Player player;

		public Roulette(Player player)
        {
			this.player = player;
		}

		public void play()
		{
			Console.WriteLine("Start roulette with" + player);
		}
	}
}

