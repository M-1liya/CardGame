using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Assets.nsDeck
{
    public class Hero : Card
    {
        private int _health;
        private int _damage;
        private ETypeHero _typeHero;
        public Hero(ETypeCard typeCard, int cardCost, int cardDamage, ETypeHero typeHero, int cardHealth)
            : base(typeCard, cardCost)
        {
            this._typeHero = typeHero;
            this._damage = cardDamage;
            this._health = cardHealth;
        }

        protected Hero(Hero hero)
            : base(hero)
        {
            this._typeHero = hero.TypeHero;
            this._damage = hero.Damage;
            this._health = hero.Health;
        }
        public int Health
        {
            get => _health;
            set => _health = value;
        }
        public enum ETypeHero { Dragon, Princess, Shrek, Donkey, Knight }
        public int Damage
        {
            get => _damage;
            set => _damage = value;
        }
        public ETypeHero TypeHero{
            get => _typeHero;
            set => _typeHero = value;
        }
        public override string ToString() => $"({Cost}) {TypeHero} Атака: {Damage}  HP: {Health}";
        public override object Clone()
        {
            return new Hero(this);
        }
    }
}
