using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_of_Legends_clone
{
    abstract class Legend
    {
        protected string _name;
        public int _max_resistance, _min_resistance,
                     _max_dmg, _min_dmg,
                     _max_health, _min_health;
        protected int _health;
        protected Random rd = new Random();

        public void set_health(int h)
        {
            _health = h;
        }

        public virtual bool Attack(ref Legend l2)
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
                Console.WriteLine("{0} Attacks {1} and Deals {2} Damage\n",
                    Get_name(),
                    l2.Get_name(),
                    dmgTOl2);
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

        public virtual bool Block()
        {
            return false;
        }

        public virtual void Take_dmg(int dmg)
        {
            _health -= dmg;
        }

        public virtual int Get_health()
        {
            return _health;
        }
        public string Get_name()
        {
            return _name;
        }

        //so every time i create an instance of a legend, the program randomly choose amount between the max and min of this amount
        // max and min are passed by the constructor of this class to the derived from them
    }
}
