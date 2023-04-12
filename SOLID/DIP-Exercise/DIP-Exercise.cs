using System;
namespace SOLID.DIPExercise
{
    public interface ISlotMachine
    {
        string theme { get; set; }
        void spin();
    }

    public abstract class SlotMachine: ISlotMachine
    {
        public string theme { get; set; }

        public void spin()
        {
            // Logic for spinning the slot machine
        }

    }

    public class SlotMachineSummer: ISlotMachine
    {
        public string theme { get; set; }

        public void spin()
        {
            // Logic for spinning the slot machine
        }
    }

    public class SlotMachineLasVegas: ISlotMachine
    {
        public string theme { get; set; }

        public void spin()
        {
            // Logic for spinning the slot machine
        }
    }

    public class CasinoClient
    {
        public ISlotMachine slotMachine;

        public CasinoClient(ISlotMachine slotMachine)
        {
            this.slotMachine = slotMachine;
        }

        public void PlayGame()
        {
            slotMachine.spin();
        }
    }
}

