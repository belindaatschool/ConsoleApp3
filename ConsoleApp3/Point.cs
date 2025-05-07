using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Point
    {
        //תכונות המחלקה
        private int x;
        private int y;

        //פעולה בונה
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //Getters and Setters
        public int GetX()
        {
            return this.x;
        }
        public void SetX(int x)
        {
            this.x = x;
        }

        public int GetY()
        {
            return this.y;
        }
        public void SetY(int y)
        {
            this.y = y;
        }

        
        public override string ToString()
        {
            return  "(" + this.x + ", " + this.y + ")";
        }
    }
}
