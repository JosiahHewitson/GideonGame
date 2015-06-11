using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreEngine
{
    public class GameMaster
    {
        public static void StartGame()
        {
            //This is a comment
        }

        /// <summary>
        /// This is the method that fires at the end of the game
        /// </summary>
        /// <returns>Game over Message</returns>
        public static string EndGame()
        {
            return "Game Over";
        }
    }
}
