using System;
namespace SOLID.Check
{
	public abstract class Input
	{

		InputTypes type;

		string value;

		public Input(InputTypes type, string value)
		{
			this.type = type;
			this.value = value;
		}

		public abstract bool check();

	}
}

