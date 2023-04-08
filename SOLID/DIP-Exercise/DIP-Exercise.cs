using System;
namespace SOLID.DIPExercise
{
    public class SlotMachine
    {

        public void Spin()
        {
            // Logic for spinning the slot machine
        }

        public void RandomNumberGenerator()
        {
            // logic for generating the random numbers for each column
        }

        public void SlotTheme()
        {
            // Logic for spinning the slot machine
        }
    }

    public class CasinoClient
    {
        private SlotMachine slotMachine;

        public CasinoClient()
        {
            this.slotMachine = new SlotMachine();
        }

        public void PlayGame()
        {
            slotMachine.Spin();
        }
    }
}

