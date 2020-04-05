using System;

namespace ToCode.Software.TextAdventure
{
    public class Game
    {
        public void Start()
        {
            Loop();
        }


        private void Loop()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "quit" || input == "exit")
                {
                    EndGame();
                    return;
                }

            }
        }


        private void EndGame()
        {

        }
    }
}