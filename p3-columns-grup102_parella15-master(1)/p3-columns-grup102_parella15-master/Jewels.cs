using System;
using System.Collections.Generic;
using System.Text;

namespace Jewels_Columns_Student
{
    //falta implementar mètode Equals
    abstract class Jewels:IEquatable<Jewels>
    {
        private static Random rnd;
        protected ConsoleColor color;

        public Jewels(ConsoleColor color)
        {
            
        }

        public abstract void Draw();

        public static Jewels GenerateRandomType()
        {
            return ;
        }

        public bool Equals(Jewels other)
        {
            return ;
        }
    }
}
