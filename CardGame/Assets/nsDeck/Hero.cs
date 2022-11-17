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
        private TypeHero typeHero;
        //private string _name = "";
        public Hero(TypeCard typeCard, int cardCost, int cardDamage, TypeHero typeHero, int cartHP)
        {
            this.typeHero = typeHero;
            this._cost = cardCost;
            this._damage = cardDamage;
            this._hp = cartHP;
            this._typeCard = typeCard;
        }

        public int HP
        {
            get => _hp; set => _hp = value;
        }
        public int Damage => _damage;
        public string Name => _name;
        public int Cost => _cost;
        public TypeHero GetTypeHero => typeHero;

        public override string ToString() => $"({Cost}) {GetTypeHero} Атака: {Damage}  HP: {HP}";

    }
}
