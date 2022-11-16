using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Assets.nsDeck
{
    public class Potion : Card
    {
        private int _effect;
        private TypePotion _typePotion;
        public Potion(TypeCard typeCard ,int cartCost, int cartEffect, TypePotion typePotion)
        {
            this._cost = cartCost;
            this._effect = cartEffect;
            //this._name = potionName;
            this._typeCard = typeCard;
            this._typePotion = typePotion;
        }

        public TypePotion GetTypePotion => _typePotion;
        public int Cost => _cost;
        public int Effect => _effect;
    }
}
