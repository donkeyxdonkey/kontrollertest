using System;

namespace kontrollertest
{
    class Testa
    {
        public PlayerControls Controls = new PlayerControls();
        public string move = "W"; //temp


        public void LetsGo()
        {
            Console.WriteLine("-------");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Commands:> NORTH[{Controls.North}] WEST[{Controls.West}] SOUTH[{Controls.South}] EAST[{Controls.East}] BACKPACK[B][EXIT]");
                Console.WriteLine("-------");

                //test
                if (move == "NORTH" || move == Controls.North) Console.WriteLine($"ja alternative controls funkar {i}");                

                Controls.AlternativeControls();
            }

            Console.ReadLine();

        }
    }
}
