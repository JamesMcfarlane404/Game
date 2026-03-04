using Raylib_cs;
using ImGuiNET;
using rlImGui_cs;

using Game.main.server;
using Game.main.client;

using Game.main.client.menu;
class Program
{
    static void Main()
    {
        Raylib.InitWindow(1280, 720, "Raylib + ImGui.NET");
        Raylib.SetTargetFPS(-1);

        rlImGui.Setup(true);
        ClientMenu.createMenu("main", new MainMenu());
        ClientMenu.show("main");
        while (!Raylib.WindowShouldClose())
        {



            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.Brown);



            rlImGui.Begin();



            ClientMenu.renderCurrent(0, null);


            rlImGui.End();


            Raylib.DrawFPS(0, 0);
            Raylib.EndDrawing();
        }

        rlImGui.Shutdown();
        Raylib.CloseWindow();
    }
}