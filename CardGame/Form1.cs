using CardGame.Assets;
using CardGame.Assets.nsDeck;
using System.Security.Cryptography.Pkcs;

namespace CardGame
{
    public partial class Form1 : Form
    {
        private Player P1 = new Player();
        private Player P2 = new Player();
        private Game game = new Game();
        public Deck decks = new Deck();
        public Form1()
        {
            InitializeComponent();

            //Присоздании окна начинается игра
            game.Start(P1, P2);
            RoundСounter.Text = $"Раунд {game.getCurrentRound.ToString()}"; 


                                        /* Выдаём игрокам карты*/
            //Первый игрок
            foreach(Card card in P1.handCard)
            {
                HandDeckP1.Items.Add(card.ToString());

            }

            //Второй игрок
            foreach (Card card in P2.handCard)   //Как я хорош, как я хорош. Одна строчка вместо кучи кода
            {
                HandDeckP2.Items.Add(card.ToString());
            }
        }

        private void HandDeckP1_TextChanged(object sender, EventArgs e)
        {

            foreach (Card card in P1.handCard)
            {


                if (HandDeckP1.SelectedItem.ToString() == card.ToString())
                {
                    if(card is Hero)
                    {
                        DropOnTheFieldButtonP1.Visible = true;      //НАЗВАНИЯ У ТЕБЯ ТОП БАЗАРУ ЗИРО
                    }
                    else
                    {
                        DropOnTheFieldButtonP1.Visible = false;
                    }
                }
            }

        }

        private void DropOnTheFieldButtonP1_Click(object sender, EventArgs e)
        {
            foreach (Card card in P1.handCard)
            {
                if (HandDeckP1.SelectedItem.ToString() == card.ToString())
                {
                    P1.handCard.Remove(card);
                    break;
                }
            }
            HeroesOnTheFieldP1.Items.Add(HandDeckP1.SelectedItem.ToString());       //
            game.RerenderList(HandDeckP1, P1);                                      //
            HeroesOnTheFieldP1.SelectedItem = HeroesOnTheFieldP1.Items[0];          //ЗАЧЕМ Я ЭТО УВИДЕЛ
            DropOnTheFieldButtonP1.Visible = false;                                 //
        }
    }
}