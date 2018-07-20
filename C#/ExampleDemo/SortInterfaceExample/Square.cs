using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortInterfaceExample
{
    public class Square : IComparable<Square>
    {
        public Square() { }

        public Square(int height,int width)
        {
            this.Height = height;
            this.Width = width;
        }

        public int Height { get; set; }
        public int Width { get; set; }

        public int CompareTo(object obj)
        {
            Square square = obj as Square;
            if (square != null)
                return CompareTo(square);
            throw
                new ArgumentException("Both objects being compared must be of type Square.");
        }

        public override string ToString() => ($"Height :{this.Height}    Width: {this.Width}");

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Square square = obj as Square;
            if (square != null)
                return this.Height == square.Height;
            return false;
        }
    }
}
