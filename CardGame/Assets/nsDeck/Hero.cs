using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Assets.nsDeck
{
    public class Hero : Card
    {
        private int _hp;
        private int _damage;
        static string _name;
        TypeHero typeHero;
        public Hero(int cardCost, int cardDamage, string nameHero, int cartHP = 100)
        {
            this.name = nameHero;
            this.cost = cardCost;
            this._damage = cardDamage;
            this._hp = cartHP;
        }

        public int HP
        {
            get => _hp; set => _hp = value;
        }
        public int Damage => _damage;
        public string Name => _name;
    }
}
