using CardGame.Assets.Model.Cards.CardType;

namespace CardGame.Assets.Model.Cards
{
    public class Hero : Card
    {
        private int _health;
        private int _damage;
        private HeroType _typeHero;
        public Hero(int cardCost, int cardDamage, HeroType typeHero, int cardHealth)
            : base(cardCost)
        {
            _typeHero = typeHero;
            _damage = cardDamage;
            _health = cardHealth;
        }

        public int Health
        {
            get => _health;
            set => _health = value;
        }
        public int Damage
        {
            get => _damage;
            set => _damage = value;
        }
        public HeroType TypeHero
        {
            get => _typeHero;
            set => _typeHero = value;
        }
        public override string ToString() => $"({Cost}) {TypeHero} Атака: {Damage}  HP: {Health}";

    }
}
