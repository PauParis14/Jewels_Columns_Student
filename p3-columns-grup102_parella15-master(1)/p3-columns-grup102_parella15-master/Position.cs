using System;
using System.Collections.Generic;
using System.Text;

namespace Jewels_Columns_Student
{
    public struct Position:IComparable<Position>
    {
        public int row;
        public int col;
        
        public Position(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
        
        public static Position operator +(Position p1, Position p2)
        {
            return new Position(p1.row + p2.row, p1.col + p2.col);
        }
        
        public static Position operator -(Position p1, Position p2)
        {
            return new Position(p1.row - p2.row, p1.col - p2.col);
        }

        public static Position operator ++(Position p)
        {
            return p++;
        }

        public static Position operator --(Position p)
        {
            return p--;
        }

        public int CompareTo(Position other)
        {
            if (this.row > other.row)
            {
                return 1;
            }
            else if (this.row < other.row)
            {
                return -1;
            }
            else
                return 0;
        }
    }
}
