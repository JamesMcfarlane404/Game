using Game.main.core.net;
using ImGuiNET;

namespace Game.main.client.menu
{


    class MainMenu : ClientMenu
    {



        public override void render(float delta, INetInterface inter)
        {
            ImGui.Begin("Test");

            ImGui.Text("Hello World!");

            ImGui.End();
        }

    }


}