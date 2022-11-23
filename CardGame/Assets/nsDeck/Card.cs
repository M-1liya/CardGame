using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Assets.nsDeck
{
    public abstract class Card
    {
        protected int _cost;
        protected TypeCard _typeCard;
        protected Card(TypeCard _typeCard, int _cost)
        {
            this._typeCard = _typeCard;
            this._cost = _cost;
        }
        public enum TypeCard { Hero, Potion }
        public TypeCard GetTypeCard => _typeCard;
        abstract public override string ToString();
        public bool IsHero(Card card) { return card is Hero; }
        public int Cost => _cost;
    }
}
