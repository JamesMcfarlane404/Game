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

        float sliderValue = 0.5f;
        bool showDemo = true;

        GameServer s = new GameServer(5555);
        ClientEntrypoint ci = new ClientEntrypoint(5555, "localhost");

        int c_p = 0;
        int s_p = 0;

        string host = "localhost";
        string send = "";
        while (!Raylib.WindowShouldClose())
        {



            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.Brown);



            rlImGui.Begin();

            ImGui.Begin("Client");

            ImGui.InputInt("client Port", ref c_p);
            ImGui.InputText("client ip", ref host, 256);

            if (ImGui.Button("Start Client"))
            {

                ci.start();

            }


            ImGui.End();


            ImGui.Begin("Server");


            ImGui.InputInt("server Port", ref s_p);

            ImGui.InputText("Send", ref send, 256);

            if (ImGui.Button("Send Data"))
            {
                s.send(send);
                send = "";
            }

            if (ImGui.Button("Start Server"))
            {
                s.start();
            }

            ImGui.End();

            rlImGui.End();

            ci.update();
            s.update();

            Raylib.DrawFPS(0, 0);
            Raylib.EndDrawing();
        }

        rlImGui.Shutdown();
        Raylib.CloseWindow();
    }
}