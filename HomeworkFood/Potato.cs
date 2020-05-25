using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkFood
{
    public class Potato : Food
    {
        public int Weight { get; set; }
        public Potato()
        {
            Name = "potato";
        }
        public Potato(int weight)
        {
            Name = "potato";
            Weight = weight;
        }
    }
}
