using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Assets.nsDeck
{
    public abstract class Card: ICloneable
    {
        protected int _cost;
        protected ETypeCard _typeCard;
        protected Card(ETypeCard _typeCard, int _cost)
        {
            this._typeCard = _typeCard;
            this._cost = _cost;
        }
        protected Card(Card obj)
        {
            this._typeCard = obj.TypeCard;
            this._cost = obj.Cost;
        }
        public enum ETypeCard { Hero, Potion }
        public ETypeCard TypeCard
        {
            get => _typeCard;
            set => _typeCard = value;
        }
        abstract public override string ToString();
        public bool IsHero(Card card) { return card is Hero; }
        abstract public Object Clone();
        public int Cost
        {
            get => _cost;
            set => _cost = value;
        }
    }
}
