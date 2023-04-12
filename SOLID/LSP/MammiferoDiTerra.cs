using System;
namespace SOLID.LSP
{
	public class MammiferoDiTerra : Mammifero
	{
		public MammiferoDiTerra()
		{
		}

        public virtual void cammina()
        {
            Console.Write("Il mammifero cammina a 4km/h");
        }
    }
}

