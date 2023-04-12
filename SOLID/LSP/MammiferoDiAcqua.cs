using System;
namespace SOLID.LSP
{
	public class MammiferoDiAcqua : Mammifero
	{
		public MammiferoDiAcqua()
		{
		}

        public virtual void nuota()
        {
            Console.WriteLine("nuota");
        }
    }
}

