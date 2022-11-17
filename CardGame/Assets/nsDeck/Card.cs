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

        public enum TypeCard { Hero, Potion}
        public enum TypeHero { Dragon, Princess, Shrek, Osel, Knight }
        public enum TypePotion { Health, Damage }

        public TypeCard GetTypeCard => _typeCard;
        public string name { get { return _name; } set { _name = value; } }
        public int cost => _cost;
    }
}
