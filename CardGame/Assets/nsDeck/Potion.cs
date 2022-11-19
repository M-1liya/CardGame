using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace CardGame.Assets.nsDeck
{
    public class Potion : Card
    {
        private int _effect;
        private TypePotion _typePotion;

        public Potion(TypeCard typeCard ,int cartCost, int cartEffect, TypePotion typePotion)
        {
            this._effect = cartEffect;
            if(typePotion == Potion.TypePotion.Damage && cartEffect > 0) this._effect = -cartEffect;

            this._cost = cartCost;
            this._typeCard = typeCard;
            this._typePotion = typePotion;

        }

        public enum TypePotion { Health, Damage }
        public TypePotion GetTypePotion => _typePotion;
        public int Cost => _cost;
        public int Effect => _effect;

        public override string ToString() 
        {
            string statusEffect = (Effect > 0) ? "+" : "";
            return $"({Cost}) {GetTypePotion} Эффект: {statusEffect + Effect} HP";
        }
    }
}
