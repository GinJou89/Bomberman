using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bomberman
{
    public class Bomb
    {
        Timer timer;
        int countSec = 4;
        PictureBox[,] mapPic;
        public Point bombPlace {get; private set;}
        deBoom boom;
        public Bomb(PictureBox[,] _mapPic, Point _bombPlace, deBoom _boom)
        {
            mapPic = _mapPic;
            bombPlace = _bombPlace;
            boom = _boom;
            CreateTimer();
            timer.Enabled = true;
        }
        private void CreateTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (countSec <= 0) 
            {
                timer.Enabled = false;
                boom(this);
                return;
            }
            WriteTimer(--countSec);
        }
        private void WriteTimer(int num)
        {
            mapPic[bombPlace.X, bombPlace.Y].Image = Properties.Resources.bomb;
            mapPic[bombPlace.X, bombPlace.Y].Refresh();

            using (Graphics gr = mapPic[bombPlace.X, bombPlace.Y].CreateGraphics())
            {
                PointF point = new PointF(
                    mapPic[bombPlace.X, bombPlace.Y].Size.Width/2-7,
                    mapPic[bombPlace.X, bombPlace.Y].Size.Height/2-12);
                gr.DrawString(
                    num.ToString(),
                    new Font("Arial", 15),
                    Brushes.White,
                    point);
            }
        }
        public void Reaction()
        {
            countSec = 0;
        }

    }
}
