using System;
using System.IO;
using static Raylib_cs.Raylib;

namespace AtYourCreate;
class Program
{
    static void Main(string[] args)
    {
        const int screenWidth = 1800;
        const int screenHeight = 1200;
        InitWindow(screenWidth, screenHeight, "P2ND");

        while(!WindowShouldClose())
        {
            BeginDrawing();
                ClearBackground(Raylib_cs.Color.Black);
                DrawText("Hello world", 100, 100, 110, Raylib_cs.Color.White);
            EndDrawing();        
            
        }
    }
}
