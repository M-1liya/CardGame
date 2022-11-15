using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Assets.nsDeck
{
    public abstract class Card
    {
        public int cost;
        public enum TypeHero { Dragon, Princess, Shrek, Osel };
        public enum TypePotion { Health, Damage };
    }
}
