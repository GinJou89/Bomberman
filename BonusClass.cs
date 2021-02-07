using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    public enum Prize
    {
        пусто,
        бомба_плюс,
        бомба_минус,
        огонь_плюс,
        огонь_минус,
        бег_плюс,
        бег_минус
    }
    public static class BonusClass
    {
        static Dictionary<Prize, int> percent;
        static List<Prize> listbonus;
        static Random rand = new Random();
        static int countBonus = 7;
        public static void Prepare()
        {
            PreparePercent();
            PrepareBonus();
        }
        private static void PreparePercent()
        {
            percent = new Dictionary<Prize, int>();
            percent.Add(Prize.бомба_плюс, 90);
            percent.Add(Prize.бомба_минус, 30);
            percent.Add(Prize.огонь_плюс, 50);
            percent.Add(Prize.огонь_минус, 20);
            percent.Add(Prize.бег_плюс, 80);
            percent.Add(Prize.бег_минус, 10);
        }
        private static void PrepareBonus()
        {
            listbonus = new List<Prize>();
            int sum = 0;
            foreach (int item in percent.Values)
            {
                sum += item;
            }
            do
            {
                int nomBonus = rand.Next(0, sum);
                int tBonus = 0;
                foreach (Prize prize in percent.Keys)
                {
                    tBonus += percent[prize];
                    if (nomBonus < tBonus)
                    {
                        listbonus.Add(prize);
                        break;
                    }
                }
            } while (listbonus.Count < countBonus);
        }
        public static Prize GetBonus()
        {
            if (listbonus.Count == 0) return Prize.пусто;
            Prize prize = listbonus[0];
            listbonus.Remove(prize);
            return prize;
        }

    }
}
