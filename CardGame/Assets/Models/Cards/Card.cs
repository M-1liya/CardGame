namespace CardGame.Assets.Model.Cards
{
    public abstract class Card
    {
        protected int _cost;
        protected Card(int _cost)
        {
            this._cost = _cost;
        }
        abstract public override string ToString();
        public bool IsHero(Card card) { return card is Hero; }
        public int Cost
        {
            get => _cost;
            set => _cost = value;
        }
    }
}
