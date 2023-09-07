using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_of_Legends_clone
{
    class Battle
    {
        public static void StartFight(Legend l1, Legend l2)
        {
            Console.WriteLine("The First Fighter is: {0}\n  Health: {1}\n",
                l1.Get_name(),
                l1.Get_health());
            Console.WriteLine("The Second Fighter is: {0}\n  Health: {1}\n",
                l2.Get_name(),
                l2.Get_health());
            while (true)
            {
                if (GetAttackResult(l1, l2))
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (GetAttackResult(l2, l1))
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        public static bool GetAttackResult(Legend l1, Legend l2)
        {
            return l1.Attack(ref l2);
        }
    }
}
