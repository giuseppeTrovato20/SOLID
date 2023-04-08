using System;
namespace SOLID.LSP
{
	public class Tigre : MammiferoDiTerra
	{

		public Tigre()
		{
		
		}

        public override void cammina()
        {
            Console.WriteLine("la tigre cammina a 5km/h");
        }

        void mordi()
		{
			Console.WriteLine("morde");
		}
	}
}

