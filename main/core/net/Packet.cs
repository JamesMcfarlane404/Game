using LiteNetLib.Utils;

namespace Game.main.core.net
{

    class Packet<T> : INetSerializable
    {
        T data;

        Side current;
        public Packet()
        {

        }
        public Packet(T to_send)
        {
            this.data = to_send;
        }




        //called when the packet is recieved on client side (current = Side.CLIENT)
        public void onClient()
        {

        }

        public void onServer()
        {

        }

        public void Deserialize(NetDataReader reader)
        {
            throw new NotImplementedException();
        }

        public void Serialize(NetDataWriter writer)
        {
            throw new NotImplementedException();
        }
    }



}

