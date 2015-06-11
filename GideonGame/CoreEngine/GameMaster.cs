using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreEngine
{
    public class GameMaster
    {
        private Objects.GameState _currentState;

        public Objects.GameState CurrentState
        {
            get { return _currentState; }
        }



        public static void StartGame()
        {
            //This is a comment
        }

        public Objects.GameState ProcessTurn()
        {
            Objects.GameState currentState = CurrentState;

            //todo: add update logic

            return currentState;
        }

        /// <summary>
        /// This is the method that fires at the end of the game
        /// </summary>
        /// <returns>Game over Message</returns>
        public static string EndGame()
        {
            return "End of the Game";
        }
    }
}
