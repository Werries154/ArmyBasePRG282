using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyBasePRG282
{
    class EnemyBuilding
    {
        private string name;
        private int hp;
        private int priority;

        public string Name { get => name; set => name = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Priority { get => priority; set => priority = value; }

        public EnemyBuilding()
        {

        }

        public EnemyBuilding(string name, int hp, int priority)
        {
            this.name = name;
            this.hp = hp;
            this.priority = priority;
        }
    }
}
