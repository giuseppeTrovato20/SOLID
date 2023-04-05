using System;
namespace SOLID.SRPEXAMPLE
{
	public class Roulette
	{
		private Random random;

		public Roulette()
		{
            random = new Random();
        }

        public int spinForNumber()
		{
			return random.Next(1, 33);
        }
    }
}

