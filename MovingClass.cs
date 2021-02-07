using System.Drawing;
using System.Windows.Forms;

namespace Bomberman
{
    class MovingClass
    {

        PictureBox player;
        PictureBox[,] mapPic;
        Sost[,] map;
        deAddBonus addBonus; 
        public MovingClass(PictureBox item, PictureBox[,] _mapPic, Sost[,] _map, deAddBonus _addBonus)
        {
            player = item;
            mapPic = _mapPic;
            map = _map;
            addBonus = _addBonus;
        }
        public void Move(int sx, int sy)
        {
            if (isEmpty(ref sx, ref sy))
            {
                player.Location = new Point(player.Location.X + sx, player.Location.Y + sy);
                Point myPlace = MyCurrentPossition();
                if (map[myPlace.X, myPlace.Y] == Sost.приз)
                {
                    //получение бонуса
                    addBonus(BonusClass.GetBonus());
                    map[myPlace.X, myPlace.Y] = Sost.пусто;
                    mapPic[myPlace.X, myPlace.Y].Image = Properties.Resources.ground;
                }
            }
        }
        public Point MyCurrentPossition()
        {
            Point point = new Point();
            {
                point.X = player.Location.X + player.Size.Width / 2;
                point.Y = player.Location.Y + player.Size.Height / 2;

            }
            for (int x = 0; x < mapPic.GetLength(0); x++)
                for (int y = 0; y < mapPic.GetLength(1); y++)
                {
                    if (mapPic[x, y].Location.X < point.X &&
                        mapPic[x, y].Location.Y < point.Y &&
                        mapPic[x, y].Location.X + mapPic[x, y].Size.Width > point.X &&
                        mapPic[x, y].Location.Y + mapPic[x, y].Size.Height > point.Y)
                        return new Point(x, y);
                }
            return point;
        }
        private bool isEmpty(ref int sx, ref int sy)
        {
            Point playerPoint = MyCurrentPossition();
            int playerRight = player.Location.X + player.Size.Width;
            int playerLeft = player.Location.X;
            int playerDown = player.Location.Y + player.Size.Height;
            int playerUp = player.Location.Y;

            int rightWallLeft = mapPic[playerPoint.X + 1, playerPoint.Y].Location.X;
            int leftWallright = mapPic[playerPoint.X - 1, playerPoint.Y].Location.X + mapPic[playerPoint.X - 1, playerPoint.Y].Size.Width;
            int downWallup = mapPic[playerPoint.X, playerPoint.Y + 1].Location.Y;
            int upWalldown = mapPic[playerPoint.X, playerPoint.Y - 1].Location.Y + mapPic[playerPoint.X, playerPoint.Y - 1].Size.Height;

            int rightUpWalldown = mapPic[playerPoint.X + 1, playerPoint.Y - 1].Location.Y + mapPic[playerPoint.X + 1, playerPoint.Y - 1].Size.Height;
            int rightDownWallup = mapPic[playerPoint.X + 1, playerPoint.Y + 1].Location.Y;
            int leftUpWalldown = mapPic[playerPoint.X - 1, playerPoint.Y - 1].Location.Y + mapPic[playerPoint.X - 1, playerPoint.Y - 1].Size.Height;
            int leftDownWallup = mapPic[playerPoint.X - 1, playerPoint.Y + 1].Location.Y;

            int rightUpWallleft = mapPic[playerPoint.X + 1, playerPoint.Y - 1].Location.X;
            int leftUpWallright = mapPic[playerPoint.X - 1, playerPoint.Y - 1].Location.X + mapPic[playerPoint.X - 1, playerPoint.Y - 1].Size.Width;
            int rightDownWallleft = mapPic[playerPoint.X + 1, playerPoint.Y + 1].Location.X;
            int leftDownWallright = mapPic[playerPoint.X - 1, playerPoint.Y + 1].Location.X + mapPic[playerPoint.X - 1, playerPoint.Y + 1].Size.Width;

            int offset = 3;

            if (sx > 0 &&
                (map[playerPoint.X + 1, playerPoint.Y] == Sost.пусто || 
                 map[playerPoint.X + 1, playerPoint.Y] == Sost.огонь ||
                 map[playerPoint.X + 1, playerPoint.Y] == Sost.приз))
            {
                if (playerUp < rightUpWalldown)
                    if (rightUpWalldown - playerUp > offset)
                        sy = offset;
                    else
                        sy = rightUpWalldown - playerUp;
                if (playerDown > rightDownWallup)
                    if (rightDownWallup - playerDown < -offset)
                        sy = -offset;
                    else
                        sy = rightDownWallup - playerDown;
                return true;
            }
            if (sx < 0 && 
               (map[playerPoint.X - 1, playerPoint.Y] == Sost.пусто || 
                map[playerPoint.X - 1, playerPoint.Y] == Sost.огонь ||
                map[playerPoint.X - 1, playerPoint.Y] == Sost.приз))
            {
                if (playerUp < leftUpWalldown)
                    if (leftUpWalldown - playerUp > offset)
                        sy = offset;
                    else
                        sy = leftUpWalldown - playerUp;
                if (playerDown > leftDownWallup)
                    if (leftDownWallup - playerDown > -offset)
                        sy = -offset;
                    else
                        sy = leftDownWallup - playerDown;
                return true;
            }
            if (sy > 0 && 
                (map[playerPoint.X, playerPoint.Y + 1] == Sost.пусто ||
                 map[playerPoint.X, playerPoint.Y + 1] == Sost.огонь ||
                 map[playerPoint.X, playerPoint.Y + 1] == Sost.приз))
            {
                if (playerRight > rightDownWallleft)
                    if (rightDownWallleft - playerRight < -offset)
                        sx = -offset;
                    else
                        sx = rightDownWallleft - playerRight;
                if (playerLeft < leftDownWallright)
                    if (leftDownWallright - playerLeft > offset)
                        sx = offset;
                    else
                        sx = leftDownWallright - playerLeft;
                return true;
            }
            if (sy < 0 && 
                (map[playerPoint.X, playerPoint.Y - 1] == Sost.пусто ||
                 map[playerPoint.X, playerPoint.Y - 1] == Sost.огонь ||
                 map[playerPoint.X, playerPoint.Y - 1] == Sost.приз))
            {
                if (playerRight > rightUpWallleft)
                    if (rightUpWallleft - playerRight < -offset)
                        sx = -offset;
                    else
                        sx = rightUpWallleft - playerRight;
                if (playerLeft < leftUpWallright)
                    if (leftUpWallright - playerLeft > offset)
                        sx = offset;
                    else
                        sx = leftUpWallright - playerLeft;
                return true;
            }


            if (sx > 0 && playerRight + sx > rightWallLeft)
                sx = rightWallLeft - playerRight;
            if (sx < 0 && playerLeft + sx < leftWallright)
                sx = leftWallright - playerLeft;
            if (sy > 0 && playerDown + sy > downWallup)
                sy = downWallup - playerDown;
            if (sy < 0 && playerUp + sy < upWalldown)
                sy = upWalldown - playerUp;

            return true;
        }
        
        
    }
}
