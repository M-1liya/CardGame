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
            string[] FilesName = { "Players.json", "Round.json" };
            foreach (var fileName in FilesName)
                if (File.Exists(fileName))
                    File.Delete(fileName);
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();

        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void ContinueGameBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }
    }
}
