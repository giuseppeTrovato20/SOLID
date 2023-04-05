using System;
namespace SOLID.SRPEXAMPLE
{
	public class RouletteGame
	{
        private Roulette roulette;

		public RouletteGame()
		{
            roulette = new Roulette();
		}

		public void play()
		{

            int spin = roulette.spinForNumber();

            Console.WriteLine("Punta su un numero");

            int guess = int.Parse(Console.ReadLine());
            

            if (guess == spin)
            {
                Console.WriteLine("Hai vinto");
            }
            else
            {
                Console.WriteLine("Hai perso, il numero era: {0}.", spin);
            }
        }

	}
}

