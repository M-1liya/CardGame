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
        private TypeHero _typeHero;
        public Hero(TypeCard typeCard, int cardCost, int cardDamage, TypeHero typeHero, int cartHP)
        {
            this._typeHero = typeHero;
            this._cost = cardCost;
            this._damage = cardDamage;
            this._hp = cartHP;
            this._typeCard = typeCard;
        }

        public int HP // Нужно поменять на heatpoint
        {
            get => _hp; set => _hp = value;
        }
        public enum TypeHero { Dragon, Princess, Shrek, Donkey, Knight, osel }
        public int getDamage => _damage;
        public string getName => _name;
        public int getCost => _cost;
        public TypeHero GetTypeHero => _typeHero;
        public override string ToString() => $"({getCost}) {GetTypeHero} Атака: {getDamage}  HP: {HP}";

    }
}
