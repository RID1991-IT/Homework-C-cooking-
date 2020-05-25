using System;

namespace HomeworkFood
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu menu = new Menu();
            menu.Info += ShowInfo;
            IO.InputFood(out Chicken chicken, out Egg egg, out Potato potato);
            menu.ChickenSoup(ref chicken,  ref egg,  ref potato);
            IO.OutputFood(chicken, egg, potato);
        }
        static void ShowInfo(string massege)
        {
            Console.WriteLine(massege);
        }
    }
}
