using Raylib_cs;
using projektt;
using System.Numerics;
using System.ComponentModel;

Raylib.InitWindow(1920, 1080, "grej");
Raylib.SetTargetFPS(60);

Objekt ball = new Objekt();
List<Objekt> balls = new();

while (Raylib.WindowShouldClose() == false)
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.Blue);

    ball.Move();
    ball.Draw();

    if(Raylib.IsMouseButtonDown(MouseButton.Left))
    {
        balls.Add(new Objekt());
        balls.Last().OnClick();
    }
    
    foreach (Objekt b in balls)
    {
        b.DrawRel();
        b.Physics();
    }
    

    Raylib.EndDrawing();

}


