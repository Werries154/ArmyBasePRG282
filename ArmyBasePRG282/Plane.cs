using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyBasePRG282
{
    class Plane
    {
        private string name;
        private int topspeed;
        private int currentspeed;
        private int maxinventory;
        private int currentinventory;
        private int maxfuel;
        private int currentfuel;
        private int maxaltitude;
        private int currentaltitude;
        private int damage;
        private int hp;

        public int Topspeed { get => topspeed; set => topspeed = value; }
        public int Currentspeed { get => currentspeed; set => currentspeed = value; }
        public int Maxinventory { get => maxinventory; set => maxinventory = value; }
        public int Currentinventory { get => currentinventory; set => currentinventory = value; }
        public int Maxfuel { get => maxfuel; set => maxfuel = value; }
        public int Currentfuel { get => currentfuel; set => currentfuel = value; }
        public int Maxaltitude { get => maxaltitude; set => maxaltitude = value; }
        public int Currentaltitude { get => currentaltitude; set => currentaltitude = value; }
        public int Damage { get => damage; set => damage = value; }
        public int Hp { get => hp; set => hp = value; }
        public string Name { get => name; set => name = value; }

        public Plane()
        {
        }

        public Plane(string name, int topspeed, int currentspeed, int maxinventory, int currentinventory, int maxfuel, int currentfuel, int maxaltitude, int currentaltitude, int damage, int hp)
        {
            this.name = name;
            this.topspeed = topspeed;
            this.currentspeed = currentspeed;
            this.maxinventory = maxinventory;
            this.currentinventory = currentinventory;
            this.maxfuel = maxfuel;
            this.currentfuel = currentfuel;
            this.maxaltitude = maxaltitude;
            this.currentaltitude = currentaltitude;
            this.damage = damage;
            this.hp = hp;
        }
        public override string ToString()
        {
            return string.Format("Name: {0} TopSpeed: {1} MaxInventory:{2} MaxFuel: {3} MaxAltitude: {4} Damage: {5} HP: {6}",name,topspeed,maxinventory,maxfuel,maxaltitude,damage,hp);
        }
    }
}
