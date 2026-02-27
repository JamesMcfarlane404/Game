using System;
using Raylib_cs;
using ImGuiNET;
using rlImGui_cs;

class Program
{
    static void Main()
    {
        Raylib.InitWindow(1280, 720, "Raylib + ImGui.NET");
        Raylib.SetTargetFPS(60);

        rlImGui.Setup(true);

        float sliderValue = 0.5f;
        bool showDemo = true;

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.Brown);

            rlImGui.Begin();

            ImGui.Begin("My ImGui Window");
            ImGui.Text("Hello from ImGui.NET!");
            ImGui.SliderFloat("Float Slider", ref sliderValue, 0f, 1f);
            ImGui.Text($"Value: {sliderValue:F2}");
            ImGui.Checkbox("Show Demo Window", ref showDemo);
            ImGui.End();

            if (showDemo)
                ImGui.ShowDemoWindow(ref showDemo);

            rlImGui.End();

            Raylib.DrawText("Raylib running underneath ImGui!", 20, 680, 20, Color.White);

            Raylib.EndDrawing();
        }

        rlImGui.Shutdown();
        Raylib.CloseWindow();
    }
}