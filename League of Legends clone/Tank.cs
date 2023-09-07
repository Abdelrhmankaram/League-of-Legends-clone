using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_of_Legends_clone
{
    class Tank : Legend
    {
        public Tank(string name)
        {
            _name = name;
            _max_health = 12000; _min_health = 8000;
            _max_dmg = 50; _min_dmg = 30;
            _max_resistance = 100; _max_resistance = 80;
            _health = rd.Next((int)_min_health, (int)_max_health);
        }
    }
}
