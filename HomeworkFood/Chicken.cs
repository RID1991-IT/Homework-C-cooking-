using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkFood
{
    public class Chicken : Food
    {
        public int Weight { get; set; }
        public Chicken()
        {
            Name = "chicken";
        }
        public Chicken(int weight)
        {
            Name= "chicken";
            Weight  =  weight;
        }
    }
}
