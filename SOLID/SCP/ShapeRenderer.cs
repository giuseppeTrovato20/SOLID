using System;
namespace SOLID.SCP
{
	public class ShapeRenderer
	{
		public ShapeRenderer()
		{

		}

		public void RenderCircle(int r)
		{
            Console.WriteLine("circle " + ((Math.Pow(r, 2) * 3.14) / 2));
		}

        public void RenderTriangle(int b, int height)
        {
            Console.WriteLine("triangle " +(b*height) / 2);
        }

        public void RenderRectangle(int b, int height)
        {
            Console.WriteLine("rectangle " + b * height);
        }
    }
}

