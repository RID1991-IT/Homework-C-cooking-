using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkFood
{
    public class Egg : Food
    {
        public int Count { get; set; }
        public Egg()
        {
            Name = "egg";
        }
        public Egg(int count)
        {
            Name = "egg";
            Count = count;
        }
    }
}
