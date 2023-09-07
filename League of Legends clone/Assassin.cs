using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_of_Legends_clone
{
    class Assassin : Legend
    {
        public Assassin(string name)
        {
            _name = name;
            _max_health = 2000; _min_health = 1500;
            _max_dmg = 280; _min_dmg = 180;
            _max_resistance = 30; _max_resistance = 10;
            _health = rd.Next((int)_min_health, (int)_max_health);
        }

        public override bool Attack(ref Legend l2)
        {
            int dmg = rd.Next(_min_dmg, _max_dmg);
            int res = rd.Next(l2._min_resistance, l2._max_resistance);
            int dmgTOl2 = dmg - res;

            if (l2.Block() == true)
            {
                Console.WriteLine("{0} Flashed and took No Damage\n\n",
                        l2.Get_name());
                return false;
            }
            else
            {
                if (dmgTOl2 > 0)
                {
                    l2.Take_dmg(dmgTOl2);
                }
                else dmgTOl2 = 0;
                Console.Write("{0} Attacks {1} and Deals {2} Damage",
                    Get_name(),
                    l2.Get_name(),
                    dmgTOl2);
                Random rd = new Random();
                int Crit_chance = rd.Next(1, 5);
                if (Crit_chance <= 2 && dmgTOl2 > 0)
                {
                    Console.WriteLine(" And Additional {0} Damage\n",
                    dmg / 2);
                    l2.Take_dmg(dmgTOl2);
                }
                else Console.WriteLine();
                if (l2.Get_health() < 0)
                {
                    l2.set_health(0);
                }
                Console.WriteLine("{0} Has {1} Health\n\n",
                    l2.Get_name(),
                    l2.Get_health());
                if (l2.Get_health() < 0)
                {
                    l2.set_health(0);
                }
                if (l2.Get_health() == 0)
                {
                    Console.WriteLine("\n\n{0} Has Died and {1} is Vicorious\n\n", l2.Get_name(), Get_name());
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
