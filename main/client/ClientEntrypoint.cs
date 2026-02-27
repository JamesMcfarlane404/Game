using LiteNetLib;


namespace Game.main.client;

class ClientEntrypoint
{

    private EventBasedNetListener listener = new EventBasedNetListener();
    private NetManager client;

    int port;
    string ip;
    public ClientEntrypoint(int port, string ip)
    {
        this.port = port;
        this.ip = ip;
        client = new NetManager(listener);
    }

    public void start()
    {
        client.Start();
        client.Connect(ip /* host IP or name */, port /* port */, "key" /* text key or NetDataWriter */);
        listener.NetworkReceiveEvent += (fromPeer, dataReader, deliveryMethod, channel) =>
        {

            Console.WriteLine("We got: {0}", dataReader.GetString(100 /* max length of string */));
            dataReader.Recycle();
        };
    }
    public void update()
    {

        client.PollEvents();


    }
    public void end()
    {
        client.DisconnectAll();
    }

}
