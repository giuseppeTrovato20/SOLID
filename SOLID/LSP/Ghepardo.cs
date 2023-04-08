using System;
namespace SOLID.LSP
{
    public class Ghepardo : MammiferoDiTerra
    {

        public Ghepardo()
        {

        }

        public override void cammina()
        {
            Console.WriteLine("il ghepardo cammina a 8km/h");
        }

        void corri()
        {
            Console.WriteLine("Corre");
        }
    }
}


