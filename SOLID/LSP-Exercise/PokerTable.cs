using System;
namespace SOLID.LSPExercise
{
    //Applica il Liskow Substitution principle

	public class Player
	{
		public string nickname;
		public double balance;
		public int rank;

		public Player(string nickname, double balance, int rank)
		{
			this.nickname = nickname;
			this.balance = balance;
			this.rank = rank;
		}
	}

	public abstract class PokerTable
	{
        private Player[] players { get; set; }

		public PokerTable(Player[] players)
		{
            this.players = players;
		}

        public virtual void play()
		{
            //distribute cards
            //first bet
            //ecc..
        }
    }

    // tavolo dove non si spendono soldi
    // e dove non si perde rank
    public abstract class CasualPlayTable : PokerTable
    {
        private Player[] players { get; set; }

        public CasualPlayTable(Player[] players) : base(players)
        {
            this.players = players;
        }

        public override void play()
        {
  			//distribute cards
			//first bet
			//ecc..
        }
    }

    // Tavolo per principianti dove si possono
    // perdere o guadagnare sia soldi che rank
    // si può entrare con qualsiasi punteggio di rank
    public abstract class BeginnersTable: PokerTable
	{
        private Player[] players { get; set; }

        public BeginnersTable(Player[] players) : base(players)
        {
            this.players = players;
        }

        public void increaseRank(Player winnerPlayer)
        {
            //each time a player wins a round, increase its rank
        }

        public void changeBalance(Player player)
        {
            //remove or add money to the selectedPlayer
        }

        public override void play()
		{
            //distribute cards
            //first bet
            //ecc..
        }
	}

    // Tavolo per esperti dove si possono
    // perdere o guadagnare sia soldi che rank
    // si può entrare solamente con 1000 di rank
    public abstract class MastersTable: PokerTable
	{
        private Player[] players { get; set; }

        public MastersTable(Player[] players) : base(players)
        {
            this.players = players;
        }

        public void increaseRank(Player winnerPlayer)
        {
            //each time a player wins a round, increase its rank
        }

        public void changeBalance(Player player)
        {
            //remove or add money to the selectedPlayer
        }

        public override void play()
        {
            foreach(Player player in players)
			{
				if(player.rank <= 1000)
				{
					throw new Exception("Player should have at least 1000 point of rank");
				}
			}

            //distribute cards
            //first bet
            //ecc..
        }

    }

}


