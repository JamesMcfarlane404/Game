using System;
namespace Game.main.core.data
{

    //the client should never create/modify this struct
    //sent from the server, readonly on client
    public struct TroopData
    {

        //a value given to the troop from the server when the troop is created
        //on a team each troops id is unique
        public int troop_id;
        public float center_x;
        public float center_y;

        public float radius;



        public int health;

        public int damage;

        //health drain = this.health - (other.damage * health_mod)
        //can have the troop take less/more damage
        public float health_mod;


        public float damage_mod;


        public float getDamageAmount()
        {
            //damage can't be zero
            //should find the best min/max
            float d_mod = (float)Math.Clamp(this.damage_mod, 0.01, 100);
            float d = Math.Clamp(this.damage, 0, 999);
            return (d * d_mod);
        }


    }




}
