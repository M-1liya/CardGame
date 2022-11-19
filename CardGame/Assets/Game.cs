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
        private int _turnOrder;
        public Game(int currentRound = 1, int turnOrder = 1) { 
            this._currentRound = currentRound;
            this._turnOrder = turnOrder;
        }
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
        public int getTurnOrder => _turnOrder;
        public void setCurrentRound(int currentRound) { this._currentRound = currentRound; }
        public void resetTurnOrder(int countPlayers) { 
            this._turnOrder = (_turnOrder >= countPlayers) ? 1: ++_turnOrder; 
        }
    }
}

