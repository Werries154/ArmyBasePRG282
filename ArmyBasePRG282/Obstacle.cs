using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyBasePRG282
{
    class Obstacle
    {
        private int shootrange;
        private int damage;
        private string name;
        private int shootheight;

        public int Shootrange { get => shootrange; set => shootrange = value; }
        public int Damage { get => damage; set => damage = value; }
        public string Name { get => name; set => name = value; }
        public int Shootheight { get => shootheight; set => shootheight = value; }
        public Obstacle()
        {

        }

        public Obstacle(int shootrange, int damage, string name, int height, int shootheight)
        {
            this.shootrange = shootrange;
            this.damage = damage;
            this.name = name;
            this.shootheight = shootheight;
        }
    }
}
