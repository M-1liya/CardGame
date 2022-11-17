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
        public Hero(TypeCard typeCard, int cardCost, int cardDamage, TypeHero typeHero, int cartHP)
        {
            this.typeHero = typeHero;
            this._cost = cardCost;
            this._damage = cardDamage;
            this._hp = cartHP;
            this._typeCard = typeCard;
            switch (typeHero)
            {
                case TypeHero.Dragon:
                    {
                        this.name = "Дракон"; break;
                    }
                case TypeHero.Knight:
                    {
                        this.name = "Рыцарь"; break;
                    }
                case TypeHero.Osel:
                    {
                        this.name = "Осел"; break;
                    }
                case TypeHero.Shrek:
                    {
                        this.name = "Шрек"; break;
                    }
                case TypeHero.Princess:
                    {
                        this.name = "Принцесса"; break;
                    }
                default:
                    {
                        this.name = "НЕ ОБРАБОТАНЫЙ ТИП"; break;
                    }
            }
        }

        public int HP
        {
            get => _hp; set => _hp = value;
        }
        public int Damage => _damage;
        public string Name => _name;
        public int Cost => _cost;
        public TypeHero GetTypeHero => typeHero;
    }
}
