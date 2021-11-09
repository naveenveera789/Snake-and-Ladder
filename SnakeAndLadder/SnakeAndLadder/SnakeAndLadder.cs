using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    public class SnakeAndLadder
    {
        public const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        public int playerPosition = 0;
        Random random = new Random();
        public int DieRoll()
        {
            int roll = random.Next(1, 7);
            return roll;
        }
        public void PlayerCheck()
        {
            int dieRoll = this.DieRoll();
            int option = random.Next(0, 3);
            switch (option)
            {
                case NO_PLAY:
                    break;
                case LADDER:
                    this.playerPosition += dieRoll;
                    break;
                case SNAKE:
                    this.playerPosition -= dieRoll;
                    break;
            }
            //Console.WriteLine(this.playerPosition);
        }
    }
}
