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
        public Game(int currentRound = 1) { 
            this._currentRound = currentRound;
        }
        public void Start(Dictionary<string, Player> Players)
        {
            distributionPlayersCards(Players);
            resetPlayersMana(Players);
        }
        public void distributionPlayersCards(Dictionary<string, Player> Players)
        {
            foreach (var player in Players)
                for (int i = 0; i < 5; i++)
                    player.Value.HandCard.Add(_deck.Cards);
        }
        public void resetPlayersMana(Dictionary<string, Player> Players)
        {
            foreach (var player in Players)
                    player.Value.Mana = _currentRound;
        }
        public int CurrentRound
        {
            get => _currentRound;
            set => _currentRound = value;
        }
    }
}

