

using System.Net.Sockets;
using LiteNetLib;
using LiteNetLib.Utils;
namespace Game.main.server
{

    class GameServer
    {

        private EventBasedNetListener listener = new EventBasedNetListener();

        private NetManager manager;
        int port;

        public GameServer(int port)
        {
            this.port = port;

            this.manager = new NetManager(listener);

        }

        public void start()
        {
            this.manager.Start(port);

            listener.ConnectionRequestEvent += request =>
            {
                if (manager.ConnectedPeersCount < 10 /* max connections */)
                    request.AcceptIfKey("key");
                else
                    request.Reject();
            };

            listener.PeerConnectedEvent += peer =>
{
    Console.WriteLine("We got connection: {0}", peer);  // Show peer IP
    var writer = new NetDataWriter();         // Create writer class
    writer.Put("Hello client!");                        // Put some string
    peer.Send(writer, DeliveryMethod.ReliableOrdered);  // Send with reliability
};


        }


        public void update()
        {

            manager.PollEvents();


        }
        public void end()
        {
            manager.DisconnectAll();
        }

        public void send(string i)
        {
            var writer = new NetDataWriter();         // Create writer class
            writer.Put(i);                        // Put some string
            manager.SendToAll(writer, DeliveryMethod.ReliableOrdered);
        }

    }




}
