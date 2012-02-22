﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MultiplayerGame;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var game = new ExampleGame(new GameSettings() { NetworkingMode = NetworkingModeTypes.Server }))
            {
                game.Run();
            }
        }
    }
}
