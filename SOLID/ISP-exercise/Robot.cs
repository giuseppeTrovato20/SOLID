using System;
namespace SOLID.ISPexercise
{
    // applica l'interface segregation principle
    // e il liskow substitution principle insieme

    public interface IWorker
    {
        void Work();

        //Mangia
        void Eat();
    }

    public class HumanWorker : IWorker
    {
        public void Work()
        {
            // work
        }

        public void Eat()
        {
            // Eat lunch
        }
    }

    public class RobotWorker : IWorker
    {
        public void Work()
        {
            // work
        }

        public void Eat()
        {
            // Robots don't eat
        }
    }
}

