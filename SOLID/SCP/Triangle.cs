using System;
namespace SOLID.SCP
{
	public class Triangle : IShape
	{
		public int b { get; set; }
		public int height { get; set; }
		public string name { get; set; }

		public Triangle()
		{
			name = "Triangle";
		}

		public int calculateArea()
		{
			return (b * height) / 2;
		}
	}
}

