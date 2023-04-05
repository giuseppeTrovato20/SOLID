namespace SOLID;
using SOLID.SCP;
using SOLID.SRPEXAMPLE;
class Program
{
    static void Main(string[] args)
    {
        ShapeRenderer shapeRenderer = new ShapeRenderer();
        
        shapeRenderer.RenderCircle(2);
        shapeRenderer.RenderTriangle(2, 5);
        shapeRenderer.RenderRectangle(2, 5);


        Game game = new Game();
    }
}

