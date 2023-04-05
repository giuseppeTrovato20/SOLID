namespace SOLID;
using SOLID.SCP;
class Program
{
    static void Main(string[] args)
    {
        ShapeRenderer shapeRenderer = new ShapeRenderer();
        
        shapeRenderer.RenderCircle(2);
        shapeRenderer.RenderTriangle(2, 5);
        shapeRenderer.RenderRectangle(2, 5);
    }
}

