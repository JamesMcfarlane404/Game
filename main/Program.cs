using Raylib_cs;
using ImGuiNET;
using rlImGui_cs;

using Game.main.server;
using Game.main.client;
class Program
{
    static void Main()
    {
        Raylib.InitWindow(1280, 720, "Raylib + ImGui.NET");
        Raylib.SetTargetFPS(-1);

        rlImGui.Setup(true);


        while (!Raylib.WindowShouldClose())
        {



            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.Brown);



            rlImGui.Begin();






            rlImGui.End();


            Raylib.DrawFPS(0, 0);
            Raylib.EndDrawing();
        }

        rlImGui.Shutdown();
        Raylib.CloseWindow();
    }
}