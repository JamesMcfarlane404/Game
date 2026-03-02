namespace Game.main.core.net
{

    interface INetInterface
    {

        public void sendPacket<T>(Side to_send, Packet<T> p);

        public void addListener<T>(PacketListener<T> listener);

        public Side getCurrentSide();

    }

    interface PacketListener<T>
    {
        void listen(Side s, Packet<T> p);
    }


}