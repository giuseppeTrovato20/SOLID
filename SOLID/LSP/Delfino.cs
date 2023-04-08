using System;
namespace SOLID.LSP
{
	public class Delfino : MammiferoDiAcqua
	{
		public Delfino()
		{
		}

        public override void nuota()
        {
            Console.WriteLine("nuota");
        }
    }
}

