using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            CoreEngine.GameMaster.StartGame();

            Console.WriteLine(CoreEngine.GameMaster.EndGame());
            Console.ReadKey();
        }
    }
}
