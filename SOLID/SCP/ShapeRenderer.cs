using System;
namespace SOLID.SCP
{
	public class ShapeRenderer
	{
		public ShapeRenderer()
		{

		}

        public void render(IShape shape)
        {
            Console.WriteLine(shape.name + " " + shape.calculateArea());
        }

    }
}

