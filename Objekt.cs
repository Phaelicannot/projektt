namespace projektt;
using System.Numerics;
using System.Security.Principal;
using Raylib_cs;
public class Objekt
{
    private int speed = 5;
    private int gravity = 1;
    public float posY;
    public float posX;
    public float relPosY;
    public float relPosX;

    public void Move()
    {
        posY = Raylib.GetMousePosition().Y;
        posX = Raylib.GetMousePosition().X;
            
    }
    public void Draw()
    {
        Raylib.DrawRectangle
        ((int)posX, (int)posY, 10, 10, Color.Red);
        Console.WriteLine(posX);
    }   

    public void OnClick()
    {
        if (Raylib.IsMouseButtonDown(MouseButton.Left))
        {
            speed = 5;
            relPosY = Raylib.GetMousePosition().Y;
            relPosX = Raylib.GetMousePosition().X;
            Console.WriteLine(relPosX);
        }
        
    }
    public void Physics()
    {
        if (relPosY !>= 1000)
        {
            return;
        }
        else if (speed <= 25)
        {
            speed = speed + gravity;
            relPosY = relPosY + speed;
        }
        else
        {
            relPosY = relPosY + speed;
        }
    }
    public void DrawRel()
    {
        Raylib.DrawRectangle
        ((int)relPosX, (int)relPosY, 10, 10, Color.Red);
    }   
}
