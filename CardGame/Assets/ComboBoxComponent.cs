using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.Assets.nsDeck;

namespace CardGame.Assets
{
    public class ComboBoxComponent
    {
        public string Text;
        public Card Value;
        public ComboBoxComponent(string Text, Card Value)
        {
            this.Text = Text;
            this.Value = Value;
        }
    }
}
