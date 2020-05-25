using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkFood
{
    public delegate void MessageCheck(string msg);
    public class Menu
    {
        public event MessageCheck Info;
        public void ChickenSoup(ref Chicken chicken, ref Egg egg, ref Potato potato)
        {
            if(chicken.Weight >= 250 && egg.Count >= 1 && potato.Weight >= 150)
            {
                chicken.Weight -= 250;
                egg.Count -= 1;
                potato.Weight -= 150;
                Info?.Invoke(" Суп Готов! ");
            }
            else
            {
                if (chicken.Weight < 250)
                {
                    Info?.Invoke("Не хватает курицы!");
                }
                if (egg.Count < 1)
                {
                    Info?.Invoke(" Не хватает яйца! ");
                }
                if (potato.Weight < 150)
                {
                    Info?.Invoke("Не хватает картофеля!");
                }
            }
        }
    }
}
