namespace SOLID;
using SOLID.SCP;
class Program
{
    static void Main(string[] args)
    {
        ShapeRenderer shapeRenderer = new ShapeRenderer();
        Triangle triangle1 = new Triangle();

        shapeRenderer.render(triangle1);

    }
}

