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
        private int _healthNexus;
        private int _mana;
        private EBattleStatus _battleStatus;
        public Player(EBattleStatus battleStatus, int heatNexus = 20, int mana = 1)
        {
            _healthNexus = heatNexus;
            _mana = mana;
            _handCard = new List<Card>();
            _battleStatus = battleStatus;
        }

       public bool DropOnField(Card playerCard)
        {
            return (playerCard.Cost <= _mana) ? true : false;
        }
        public List<Card> HandCard => _handCard;
        public void addHandCard(Card card) { _handCard.Add(card); }
        public void removeHandCard(Card card) { _handCard.Remove(card); }
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
        public EBattleStatus BattleStatus
        {
            get => _battleStatus;
            set => _battleStatus = value;
        }
    }
}
