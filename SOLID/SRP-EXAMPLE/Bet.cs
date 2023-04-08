using System;
namespace SOLID.SRPEXAMPLE
{
	public class Bet
	{
		public Bet()
		{

		}

		public int takeBet()
		{
            Console.WriteLine("Punta su un numero");
            return int.Parse(Console.ReadLine());
        }
	}
}

