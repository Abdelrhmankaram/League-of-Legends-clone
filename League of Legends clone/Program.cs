using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_of_Legends_clone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 1v1 League of Legends Terminal Version\n");
            Console.WriteLine("Choose your Champion and name them: ");
            Console.WriteLine(" 1-> Assasin");
            Console.WriteLine(" 2-> Mage");
            Console.WriteLine(" 3-> Bruiser");
            Console.WriteLine(" 4-> Tank");
            Console.WriteLine("First player to Choose: ");

            #region taking inputs
            char Player1, Player2;
            Player1 = Console.ReadLine()[0];
            while (true)
            {
                if (Player1 >= '1' && Player1 <= '4')
                {
                    break;
                }
                Console.Write("invalid choice, choose again: ");
                Player1 = Console.ReadLine()[0];
            }
            Console.WriteLine("First player choose a name: ");
            string n1 = Console.ReadLine();
            Console.WriteLine("Second player to Choose: ");
            Player2 = Console.ReadLine()[0];
            while (true)
            {
                if (Player2 >= '1' && Player2 <= '4')
                {
                    break;
                }
                Console.Write("invalid choice, choose again: ");
                Player2 = Console.ReadLine()[0];
            }
            Console.WriteLine("Second player choose a name: ");
            string n2 = Console.ReadLine();
            #endregion


            Legend Fighter1 = null, Fighter2 = null;

            #region init
            if (Player1 == '1')
            {
                Fighter1 = new Assassin(n1);
            }

            if (Player1 == '2')
            {
                Fighter1 = new Mage(n1);
            }

            if (Player1 == '3')
            {
                Fighter1 = new Bruiser(n1);
            }

            if (Player1 == '4')
            {
                Fighter1 = new Tank(n1);
            }

            if (Player2 == '1')
            {
                Fighter2 = new Assassin(n2);
            }

            if (Player2 == '2')
            {
                Fighter2 = new Mage(n2);
            }

            if (Player2 == '3')
            {
                Fighter2 = new Bruiser(n2);
            }

            if (Player2 == '4')
            {
                Fighter2 = new Tank(n2);
            }

            #endregion

            Battle.StartFight(Fighter1, Fighter2);
        }
    }
}
