using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace Bomberman
{
    public delegate void deBoom(Bomb b);
    enum Sost 
    { 
        пусто,
        стена,
        кирпич,
        бомба,
        огонь,
        приз
    }
    class MainBoard
    {
        Panel panelGame;
        PictureBox[,] mapPic;
        Sost[,] map;
        int sizeX = 17;
        int sizeY = 11;
        static Random rand = new Random();
        Player player;
        List<Mob> mobs;
        deClear needClear;
        Label score;

        public MainBoard(Panel panel, deClear _clear, Label _score)
        {
            panelGame = panel;
            needClear = _clear;
            score = _score;
            mobs = new List<Mob>();

            int boxSize;
            if ((panelGame.Width / sizeX) < (panelGame.Height / sizeY))
                boxSize = panelGame.Width / sizeX;
            else
                boxSize = panelGame.Height / sizeY;
            InitStartMap(boxSize);
            InitStartPlayer(boxSize);
            for (int i = 0; i < 3; i++)
            {
                InitMob(boxSize);
            }
            BonusClass.Prepare();

        }
        private void InitStartPlayer(int boxSize)
        {
            int x = 1; int y = 1;
            PictureBox picture = new PictureBox
            {
                Location = new Point(x * (boxSize - 1), y * (boxSize - 1)),
                Size = new Size(boxSize - 2, boxSize - 2),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            picture.Image = Properties.Resources.Character;
            picture.BackgroundImage = Properties.Resources.ground;
            picture.BackgroundImageLayout = ImageLayout.Stretch;
            panelGame.Controls.Add(picture);
            picture.BringToFront();
            player = new Player(picture, mapPic, map, score);
        }
        private void InitStartMap(int boxSize)
        {
            mapPic = new PictureBox[sizeX, sizeY];
            map = new Sost[sizeX, sizeY];

            panelGame.Controls.Clear();

            for (int x = 0; x < sizeX; x++)
                for (int y = 0; y < sizeY; y++)
                {
                    if (x == 0 || y == 0 || x == sizeX - 1 || y == sizeY - 1)
                        CreatePlace(new Point(x, y), boxSize, Sost.стена);
                    else if (x % 2 == 0 && y % 2 == 0)
                        CreatePlace(new Point(x, y), boxSize, Sost.стена);
                    else if (rand.Next(3) == 0)
                        CreatePlace(new Point(x, y), boxSize, Sost.кирпич);
                    else
                        CreatePlace(new Point(x, y), boxSize, Sost.пусто);
                }
            ChangeSost(new Point(1, 1), Sost.пусто);
            ChangeSost(new Point(2, 1), Sost.пусто);
            ChangeSost(new Point(1, 2), Sost.пусто);

        }
        private void CreatePlace(Point point, int boxSize, Sost sost)
        {
            PictureBox picture = new PictureBox
            {
                Location = new Point(point.X * (boxSize - 1), point.Y * (boxSize - 1)),
                Size = new Size(boxSize, boxSize),
                //BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            mapPic[point.X, point.Y] = picture;
            ChangeSost(point, sost);
            panelGame.Controls.Add(picture);
        }
        private void ChangeSost(Point point, Sost newSost)
        {
            switch (newSost)
            {
                case Sost.стена:
                    mapPic[point.X, point.Y].Image = Properties.Resources.wall;
                    break;
                case Sost.кирпич:
                    mapPic[point.X, point.Y].Image = Properties.Resources.brick;
                    break;
                case Sost.бомба:
                    mapPic[point.X, point.Y].Image = Properties.Resources.bomb;
                    break;
                case Sost.огонь:
                    mapPic[point.X, point.Y].Image = Properties.Resources.explosiv;
                    break;
                case Sost.приз:
                    mapPic[point.X, point.Y].Image = Properties.Resources.coin;
                    break;
                default:
                    mapPic[point.X, point.Y].Image = Properties.Resources.ground;
                    break;
            }
            map[point.X, point.Y] = newSost;
        }
        public void MovePlayer(Arrows arrow)
        {
            if (player == null) return;
            player.MovePlayer(arrow);
        }
        private void InitMob(int boxSize)
        {
            //int x = 15; int y = 9;
            FindEmptyPlace(out int x, out int y);
            PictureBox picture = new PictureBox
            {
                Location = new Point(x * (boxSize - 1), y * (boxSize - 1)),
                Size = new Size(boxSize - 2, boxSize - 2),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            picture.Image = Properties.Resources.mob;
            picture.BackColor = Color.Transparent;
            picture.BackgroundImage = Properties.Resources.ground;
            picture.BackgroundImageLayout = ImageLayout.Stretch;
            panelGame.Controls.Add(picture);
            picture.BringToFront();
            mobs.Add(new Mob(picture, mapPic, map, player));
        }
        public void PutBomb()
        {
            Point playerPoint = player.MycurrentPossion();
            if (map[playerPoint.X, playerPoint.Y] == Sost.бомба) return;
            if (player.PutBomb(mapPic, Boom))
                ChangeSost(playerPoint, Sost.бомба);
        }
        private void FindEmptyPlace(out int x, out int y)
        {
            int loop = 0;
            do
            {
                x = rand.Next(map.GetLength(0) / 2, map.GetLength(0));
                y = rand.Next(1, map.GetLength(1));
            } while (map[x, y] != Sost.пусто && loop++ < 100);
        }
        private void Boom(Bomb bomb)
        {
            ChangeSost(bomb.bombPlace, Sost.огонь);
            Flame(bomb.bombPlace, Arrows.left);
            Flame(bomb.bombPlace, Arrows.right);
            Flame(bomb.bombPlace, Arrows.up);
            Flame(bomb.bombPlace, Arrows.down);
            player.RemoveBomb(bomb);
            Blaze();
            needClear();


        }
        private void Flame(Point bombPlace, Arrows arrow)
        {
            int sx = 0, sy = 0;

            switch (arrow)
            {
                case Arrows.left:
                    sx = -1;
                    break;
                case Arrows.right:
                    sx = 1;
                    break;
                case Arrows.up:
                    sy = -1;
                    break;
                case Arrows.down:
                    sy = 1;
                    break;
                default:
                    break;
            }

            bool isNotDone = true;
            int x = 0, y = 0;
            do
            {
                x += sx; y += sy;
                if (Math.Abs(x) > player.lenFire || Math.Abs(y) > player.lenFire) break;
                if (isFire(bombPlace, x, y))
                    ChangeSost(new Point(bombPlace.X + x, bombPlace.Y + y), Sost.огонь);
                else
                    isNotDone = false;
            } while (isNotDone);
        }
        private bool isFire(Point place, int sx, int sy)
        {
            switch (map[place.X + sx, place.Y + sy])
            {
                case Sost.пусто:
                    return true;
                case Sost.стена:
                    return false;
                case Sost.кирпич:
                    if (rand.Next(0,2)>0)
                        ChangeSost(new Point(place.X + sx, place.Y + sy), Sost.приз);
                    else
                        ChangeSost(new Point(place.X + sx, place.Y + sy), Sost.огонь);
                    return false;
                case Sost.бомба:
                    foreach (Bomb bomb in player.bombs)
                    {
                        if (bomb.bombPlace == new Point(place.X + sx, place.Y + sy))
                            bomb.Reaction();
                    }
                    return false;
                default:
                    return true;
            };
        }
        private void Blaze()
        {
            List<Mob> delMobs = new List<Mob>();
            foreach (Mob mob in mobs)
            {
                Point mobPoint = mob.MycurrentPossition();
                if (map[mobPoint.X, mobPoint.Y] == Sost.огонь)
                    delMobs.Add(mob);
            }
            for (int x = 0; x < delMobs.Count; x++)
            {
                mobs.Remove(delMobs[x]);
                panelGame.Controls.Remove(delMobs[x].mob);
                delMobs[x] = null;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        public void ClearFire()
        {
            for (int x = 0; x < map.GetLength(0); x++)
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    if (map[x, y] == Sost.огонь)
                        ChangeSost(new Point(x, y), Sost.пусто);
                }
        }
        public bool GameOver()
        {
            Point myPoint = player.MycurrentPossion();
            if (map[myPoint.X, myPoint.Y] == Sost.огонь)
                return true;
            if (mobs.Count == 0) return true;
            foreach (Mob mob in mobs)
            {
                if (myPoint == mob.MycurrentPossition()) return true ;
            }
            return false;
        }
        public void SetMobLevel(int level) 
        {
            foreach (Mob mob in mobs)
            {
                mob.SetLevel(level);
            }
        }
        
    }
}
