using Roll_Dice_Game_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roll_Dice_Game_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Logic l = new Logic();

            PrintInfo();
        }

        public static void PrintInfo()
        {
            int count = 1, total = 0;
            Console.WriteLine("Turn : " + count);
            Console.WriteLine("Run or Hold..? (R/H)");
            char input = Convert.ToChar(Console.ReadLine().ToLower());

            switch(input)
            {
                case 'r':
                    RunOrHold(total, count);
                    break;
                default :
                    Console.WriteLine("Invalid Input...!");
                    break;
            }
        }

        public static void RunOrHold(int total, int count)
        {
            System.Random random = new System.Random();
            int randomnum = random.Next(1, 6);

            Console.WriteLine(randomnum);
            total += randomnum;

            if (randomnum == 1 && total >= 20)
            {
                Console.WriteLine("Turn Over...!" + "\nTotal Score : " + total);
            }
            else if (randomnum == 1 && total < 20)
            {
                total = 0;
                Console.WriteLine("Score Reset to : " + total);
                Play(total, count);
            }
            else
            {
                Play(total, count);
            }
        }

        public static void Play(int total, int count)
        {
            char input;

            Console.WriteLine("Roll or Hold...(R/H) ? ");
            input = Convert.ToChar(Console.ReadLine().ToLower());
            if (input == 'r' && total < 20)
            {
                RunOrHold(total, count);
            }
            else if (input == 'h' && total < 20)
            {
                count++;
                Console.WriteLine("Turn : " + count);
                RunOrHold(total, count);
            }
            else
            {
                Console.WriteLine("Turn Over...!" + "\nTotal Score : " + total);
                return;
            }
        }
    }
}
