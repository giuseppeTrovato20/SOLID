using System;
namespace SOLID.SCP
{

    interface IShape
    {
        string name;
        int calculateArea();
    }

    public class Triangle: IShape;
    {
        calculateArea()
    }

	public class ShapeRenderer
	{
		public ShapeRenderer()
		{

		}

        public void render(IShape shape) {
            Console.WriteLine(shape.name, shape.calculateArea());
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

