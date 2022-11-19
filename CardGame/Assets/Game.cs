using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.Assets.nsDeck;

namespace CardGame.Assets
{
    public class Game
    {
        private int currentRound;
        static Deck deck = new Deck();

        public Game(int currentRound = 1) { this.currentRound = currentRound; }
        public void Start(Dictionary<string, Player> Players)
        {
            foreach (var player in Players)
                for(int i = 0; i < 5; i++)
                   player.Value.getHandCard.Add(deck.GetCard());
        }
    
        public int getCurrentRound => currentRound;
        public void setCurrentRound(int currentRound) { this.currentRound = currentRound; }
    }
}

