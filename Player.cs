using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bomberman
{
    public delegate void deAddBonus(Prize p);
    enum Arrows 
    {
        left,
        right,
        up,
        down
    }
    class Player
    {
        PictureBox player;
        int step;
        MovingClass moving;
        public List<Bomb> bombs {get; private set;}
        int countBomb;
        public int lenFire { get; private set; }
        Label score;
        public Player(PictureBox _player, PictureBox[,] _mapPic, Sost[,] _map, Label lbScore)

        {
            player = _player;
            step = 3;
            score = lbScore;
            countBomb = 3;
            lenFire = 3;
            bombs = new List<Bomb>();
            moving = new MovingClass(_player, _mapPic, _map, AddBonus);
            ChangeScore();
        }
        public void MovePlayer(Arrows arrow)
        {
            switch (arrow)
            {
                case Arrows.left:
                    player.Image = Properties.Resources.Character_left;
                    moving.Move(-step, 0);
                    break;
                case Arrows.right:
                    player.Image = Properties.Resources.Character_right;
                    moving.Move(step, 0);
                    break;
                case Arrows.up:
                    player.Image = Properties.Resources.Character_up;
                    moving.Move(0, -step);
                    break;
                case Arrows.down:
                    player.Image = Properties.Resources.Character_down;
                    moving.Move(0, step);
                    break;
                default:
                    break;
            }
        }
        public Point MycurrentPossion()
        {
            return moving.MyCurrentPossition();
        }
        public bool PutBomb(PictureBox[,] mapPic, deBoom boom) 
        {
            if (bombs.Count >= countBomb) return false;
            player.Image = Properties.Resources.Character;
            Bomb bomb = new Bomb(mapPic, MycurrentPossion(), boom);
            bombs.Add(bomb);
            return true;
        }
        public void RemoveBomb(Bomb bomb)
        {
            bombs.Remove(bomb);  
        }
        private void ChangeScore(string alarm = "")
        {
            if (score == null) return;
            score.Text = "Скорость: " + step + ", кол-во бомб: " + countBomb + ", сила бомб: " + lenFire + " " + alarm; 
        }
        private void AddBonus(Prize prize)
        {
            switch (prize)
            {
                case Prize.бомба_плюс:
                    countBomb++;
                    ChangeScore("+1 бомба");
                    break;
                case Prize.бомба_минус:
                    countBomb = countBomb == 1 ? 1 : countBomb-1;
                    ChangeScore("-1 бомба");
                    break;
                case Prize.огонь_плюс:
                    lenFire++;
                    ChangeScore("+1 к силе бомбы");
                    break;
                case Prize.огонь_минус:
                    lenFire = lenFire == 1 ? 1 : lenFire-1;
                    ChangeScore("-1 к силе бомбы");
                    break;
                case Prize.бег_плюс:
                    step++;
                    ChangeScore("+1 к скорости");
                    break;
                case Prize.бег_минус:
                    step = step == 1 ? 1 : step-1;
                    ChangeScore("-1 к скорости");
                    break;
                default:
                    break;
            }
        }

    }
}
