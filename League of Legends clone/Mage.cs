using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_of_Legends_clone
{
    class Mage : Legend
    {
        public Mage(string name)
        {
            _name = name;
            _max_health = 1500; _min_health = 800;
            _max_dmg = 300; _min_dmg = 200;
            _max_resistance = 30; _max_resistance = 10;
            _health = rd.Next((int)_min_health, (int)_max_health);

        }
        public override bool Block()
        {
            Random rd = new Random();
            int flash = rd.Next(1, 5);
            if (flash == 1)
            {
                return true;
            }
            else return false;
        }
    }
}
