using System;
namespace SOLID.DIPExercise2
{

    public interface ICasino
    {
        public void deal();
    }

    public class RouletteGame : ICasino
    {
        public void deal()
        {
            // Logic for dealing cards in a Blackjack game
        }
    }

    public class BlackjackGame : ICasino
    {
        public void deal()
        {
            // Logic for dealing cards in a Blackjack game
        }
    }

    public class Casino
    {
        private readonly ICasino blackjackGame;

        public Casino(ICasino blackjackGame)
        {
            this.blackjackGame = blackjackGame;
        }

        public void PlayGame()
        {
            blackjackGame.deal();
        }
    }
}

