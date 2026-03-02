namespace Game.main.core
{

    class ClientPhaseHandler
    {

        static ClientPhase phase;

        public static void start()
        {
            phase = ClientPhase.PRE_LOAD;

            assetLoad();
            showMain();

        }
        public static void assetLoad()
        {
            phase = ClientPhase.ASSET_LOAD;
        }
        public static void showMain()
        {
            phase = ClientPhase.MAIN_ENTRY;
        }





    }

    enum ClientPhase
    {

        //preload is first
        //asset load is when the assets are loading
        //main_entry is after asset load just before the main menu is shown
        PRE_LOAD, ASSET_LOAD, MAIN_ENTRY


    }

}