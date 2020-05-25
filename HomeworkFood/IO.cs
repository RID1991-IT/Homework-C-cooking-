using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HomeworkFood
{
    static class IO
    {
        public static void InputFood (out Chicken chicken,out Egg egg,out Potato potato)
        {
            Write("Введите вес ципленка -");
            int weightChicken = Convert.ToInt32(ReadLine());
            Write("Введите количество яиц -");
            int countEgg = Convert.ToInt32(ReadLine());
            Write("Введите вес картофеля -");
            int weightPotato = Convert.ToInt32(ReadLine());
            chicken = new Chicken(weightChicken);
            egg = new Egg(countEgg);
            potato = new Potato(weightPotato);
        }
        public static void OutputFood(Chicken chicken, Egg egg, Potato potato)
        {
            WriteLine("У вас осталось:");
            WriteLine($"{chicken.Weight} грамм курицы.");
            WriteLine($"{egg.Count} ед. яиц.");
            WriteLine($"{potato.Weight} грамм картофеля.");
        }
    }
}
