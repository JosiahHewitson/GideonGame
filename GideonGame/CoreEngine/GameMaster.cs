using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreEngine.World;

namespace CoreEngine
{
    public class GameMaster
    {
        private static Objects.GameState _currentState;
        private static List<Province> _world;


        public static Objects.GameState CurrentState
        {
            get { return _currentState; }
        }

        public static List<Province> World { get { return _world; } }

        public static void StartGame()
        {
            //This is a comment
            WorldGenerator generator= new WorldGenerator();

            generator.Height = 100;
            generator.Width = 100;
            _world = generator.GenerateWorld();

        }

        public static Objects.GameState ProcessTurn()
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
