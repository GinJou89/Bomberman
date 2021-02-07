using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bomberman
{
    public delegate void deClear();
    
    public partial class FormGame : Form
    {
        MainBoard board;
        int level = 1;
        ModalWindow mw;
        public FormGame()
        {
            mw = new ModalWindow(this);
            InitializeComponent();
            NewGame();
        }
        private void NewGame()
        {
            board = new MainBoard(panelGame, StartClear, labelScore);
            ChangeLevel(level);
            mw.ShowDialog();
            timerGameOver.Enabled = true;

        }
        private void обавтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GinJou", "Об авторе");
        }
        private void обИгреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Клон популярной игры NES", "Описание игры");
        }
        private void panelGame_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FormGame_Load(object sender, EventArgs e)
        {

        }
        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (timerGameOver.Enabled)
                switch (e.KeyCode)
                {
                    case Keys.Left: board.MovePlayer(Arrows.left); break;
                    case Keys.Right: board.MovePlayer(Arrows.right); break;
                    case Keys.Up: board.MovePlayer(Arrows.up); break;
                    case Keys.Down: board.MovePlayer(Arrows.down); break;
                    case Keys.Space: board.PutBomb(); break;
                }

        }
        private void timerFireClear_Tick(object sender, EventArgs e)
        {
            board.ClearFire();
            timerFireClear.Enabled = false;
        }
        private void StartClear()
        {
            timerFireClear.Enabled = true;
        }
        private void timerGameOver_Tick(object sender, EventArgs e)
        {
            if (board.GameOver())
            {
                timerGameOver.Enabled = false;
                DialogResult dr = MessageBox.Show("Хотите начать заново?", "Конец игры", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    NewGame();
                }
                else
                    this.Close();
            }
        }
        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ChangeLevel(int _level)
        {
            level = _level;
            board.SetMobLevel(level);
        }
        private void глупыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLevel(1);
        }
        private void умныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLevel(2);
        }
        private void самыйУмныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLevel(3);
        }
    }
}
