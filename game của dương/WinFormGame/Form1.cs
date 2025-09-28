using System;
using System.Windows.Forms;
using Game;   // lấy Class1 và GameState từ project Game

namespace WinFormGame
{
    public partial class Form1 : Form
    {
        private Class1 game;

        public Form1()
        {
            InitializeComponent();
            game = new Class1();
            UpdateUI(game.GetState(null));
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string input = txtWord.Text.Trim();
            GameState state = game.GetState(input);
            txtWord.Text = "";
            UpdateUI(state);
        }

        private void UpdateUI(GameState state)
        {
            lblScore.Text = "Điểm: " + state.Score.ToString();
            lstEnemies.Items.Clear();
            foreach (string enemy in state.Enemies)
            {
                lstEnemies.Items.Add(enemy);
            }
        }
    }
}
