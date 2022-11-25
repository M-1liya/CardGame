using CardGame.Assets.nsDeck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Assets
{
    public class Player
    {
        public enum EBattleStatus { Attack = 1, Protection };
        private List<Card> _handCard;
        private List<Card> _cardsOnField;
        private List<Card> _cardsOnBattleground;
        private bool _move;

        private int _healthNexus;
        private int _mana;
        private EBattleStatus _battleStatus;
        public Player(EBattleStatus battleStatus, int heatNexus = 20, int mana = 1, bool move = false)
        {
            _healthNexus = heatNexus;
            _mana = mana;
            _handCard = new List<Card>();
            _cardsOnField = new List<Card>();
            _cardsOnBattleground = new List<Card>();
            _battleStatus = battleStatus;
            _move = move;
        }

        public bool IsDropOnField(Card playerCard)
        {
            return (playerCard.Cost <= _mana) ? true : false;
        }
        public List<Card> HandCard => _handCard;
        public List<Card> CardsOnField => _cardsOnField;
        public List<Card> CardsOnBattleground => _cardsOnBattleground;
        public int HealthNexus
        {
            get => _healthNexus;
            set => _healthNexus = value;
        }
        public int Mana
        {
            get => _mana;
            set => _mana = value;
        }
        public bool Move
        {
            get => _move;
            set => _move = value;
        }
        public EBattleStatus BattleStatus
        {
            get => _battleStatus;
            set => _battleStatus = value;
        }
    }
}
