using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Assets.nsDeck
{
    public class Potion : Card
    {
        public int effect;
        public Potion(int cartCost, int cartEffect, TypePotion typePotion)
        {
            this.cost = cartCost;
            this.effect = cartEffect;
        }
    }
}
