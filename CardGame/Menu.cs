using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void StartNewGameBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists("Players.json"))
                File.Delete("Players.json");
            Form1 form = new Form1();
            form.ShowDialog();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void ContinueGameBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            this.Hide();
        }
    }
}
