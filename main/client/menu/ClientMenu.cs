using Game.main.core.net;
using LiteNetLib;

namespace Game.main.client.menu
{


    class ClientMenu
    {



        public void render(float delta, INetInterface inter)
        {

        }

        public void onShow()
        {

        }
        public void onHide()
        {

        }



        public static Dictionary<string, ClientMenu> menus = new Dictionary<string, ClientMenu>();

        public static ClientMenu current = null;

        public static void createMenu(string name, ClientMenu menu)
        {
            Console.WriteLine("Created new Menu: " + name);
            menus.Add(name, menu);


        }

        private static void hideCurrent()
        {
            if (current != null)
            {
                current.onHide();
            }
        }
        private static void showCurrent()
        {
            if (current != null)
            {
                current.onShow();
            }
        }
        public static void show(string name)
        {
            if (menus.TryGetValue(name, out ClientMenu menu))
            {
                if (menu != null)
                {
                    hideCurrent();
                    current = menus[name];
                    showCurrent();


                }


            }
        }

        public static void renderCurrent(float delta, INetInterface inter)
        {

            if (current != null)
            {
                current.render(delta, inter);
            }


        }



    }
}
