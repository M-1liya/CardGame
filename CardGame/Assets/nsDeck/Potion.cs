using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace CardGame.Assets.nsDeck
{
    [Serializable]
    public class Potion : Card
    {
        private int _effect;
        private Hero.ETypeHero _hero;
        private ETypePotion _typePotion;

        public Potion(ETypeCard typeCard ,int cardCost, int cardEffect, ETypePotion typePotion, Hero.ETypeHero hero)
            : base(typeCard, cardCost)
        {
            this._effect = cardEffect;
            this._typePotion = typePotion;
            this._hero = hero;
        }
        protected Potion(Potion potion)
            : base(potion)
        {
            this._effect = potion.Effect;
            this._typePotion = potion.TypePotion;
            this._hero = potion.Hero;
        }
        public enum ETypePotion { Health, Damage }
        public ETypePotion TypePotion {
            get => _typePotion;
            set => _typePotion = value;
        }
        public int Effect {
            get => _effect;
            set => _effect = value;
        }
        public Hero.ETypeHero Hero
        {
            get => _hero;
            set => this._hero = value;
        }
        public override string ToString() 
        {
            string statusEffect = (TypePotion == ETypePotion.Health) ? "+" : "-";
            return $"({Cost}) {TypePotion} Эффект: {statusEffect + Effect} HP";
        }
        public override object Clone()
        {
            return new Potion(this);
        }
    }
}
