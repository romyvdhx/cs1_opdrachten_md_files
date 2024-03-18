﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOpdracht4
{
    internal class GameRenderer
    {
        private GameScreen screen;
        
        public GameRenderer(GameScreen screen)
        {
            this.screen = screen;
        }
        //maak hier een constructor aan!, kijk of je this nodig hebt (zie GameScreen voor hints en patronen)

        internal void SetScreen(GameScreen screen)
        {
            //zorg ervoor dat de waarde van screen in currentScreen komt (gebruik =)
            this.screen = screen;
        }

            

        internal void Render()
        {
            Console.Clear();

            Console.ForegroundColor= ConsoleColor.Green;
            foreach(string line in screen.GetScreenLines())
            {
                Console.WriteLine(line);
            }

        }
    }
}
