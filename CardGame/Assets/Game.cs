using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.Assets.nsDeck;

namespace CardGame.Assets
{
    static class Game
    {
        static int currentRound = 1;
        static Deck DeckP1, Deck2;
        static int ElexirP1, ElexirP2;

        public static void Start()
        {
            DeckP1 = new Deck();
        }
    }
}
