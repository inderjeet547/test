using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roll_Dice_Game_App.Model
{
    class Logic
    {
        int total = 0, count = 1;
        char input;
        public void RunOrHold()
        {
            System.Random random = new System.Random();
            int randomnum = random.Next(1, 6);

            Console.WriteLine(randomnum);
            total += randomnum;

            if (randomnum == 1)
            {
                if(total >= 20)
                {
                    Console.WriteLine("Turn Over...!" + "\nTotal Score : " + total);
                }
            }
            else if(randomnum == 1 && total < 20)
            {
                total = 0;
                Console.WriteLine("Score Reset to : " + total);
                Play();
            }
            else
            {
                Play();
            }
        }

        public void Play()
        {
            Console.WriteLine("Roll or Hold...(R/H) ? ");
            input = Convert.ToChar(Console.ReadLine().ToLower());
            if (input == 'r' && total < 20)
            {
                RunOrHold();
            }
            else if (input == 'h' && total < 20)
            {
                count++;
                Console.WriteLine("Turn : " + count);
                RunOrHold();
            }
            else
            {
                Console.WriteLine("Turn Over...!" + "\nTotal Score : " + total);
                return;
            }
        }
    }
}
