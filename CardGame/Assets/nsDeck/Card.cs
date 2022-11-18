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
        protected string _name = "";
        protected TypeCard _typeCard;

        public enum TypeCard { Hero, Potion }
        public TypeCard GetTypeCard => _typeCard;

        abstract public override string ToString();
        public bool isHero(Card card) { return card is Hero; }
    }
}
