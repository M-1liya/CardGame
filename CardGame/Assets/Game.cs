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
        private int _currentRound;
        static Deck _deck = new Deck();
        public Game(int currentRound = 1) { this._currentRound = currentRound; }
        public void Start(Dictionary<string, Player> Players)
        {
            cardDistribution(Players);
        }
        public void cardDistribution(Dictionary<string, Player> Players)
        {
            foreach (var player in Players)
                for (int i = 0; i < 5; i++)
                    player.Value.getHandCard.Add(_deck.GetCard());
        }
        public int getCurrentRound => _currentRound;
        public void setCurrentRound(int currentRound) { this._currentRound = currentRound; }
    }
}

