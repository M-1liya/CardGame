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
            this._typeCard = typeCard;
            this._typePotion = typePotion;
            switch (typePotion)
            {
                case TypePotion.Health:
                    {
                        this.name = "Зелье лечения"; break;

                    }
                case TypePotion.Damage:
                    {
                        this.name = "Зелье урона"; break;
                    }
                default:
                    {
                        this.name = "НЕ ОБРАБОТАНЫЙ ТИП"; break;
                    }
            }
        }

        public TypePotion GetTypePotion => _typePotion;
        public int Cost => _cost;
        public int Effect => _effect;
        public string name { get => _name; set => _name = value; }
    }
}
