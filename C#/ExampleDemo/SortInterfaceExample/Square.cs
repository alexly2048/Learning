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

        /// <summary>
        ///  CompareTo方法重载
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            Square square = obj as Square;
            if (square != null)
                return CompareTo(square);
            throw
                new ArgumentException("Both objects being compared must be of type Square.");
        }

        public override string ToString() => ($"Height :{this.Height}    Width: {this.Width}");

        /// <summary>
        /// 重写Equals()方法
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Square square = obj as Square;
            if (square != null)
                return this.Height == square.Height;
            return false;
        }

        /// <summary>
        ///  重写GetHashCode()方法
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.Height.GetHashCode() | this.Width.GetHashCode();
        }

        /// <summary>
        ///  重写运算符
        ///   重写 == 方法
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool operator ==(Square x,Square y) => x.Equals(y);
        public static bool operator !=(Square x,Square y)=> !(x==y);
        public static bool operator <(Square x,Square y)=> (x.CompareTo(y) < 0);
        public static bool operator >(Square x,Square y)=>(x.CompareTo(y)> 0);

        /// <summary>
        /// 调用IComparable,需实现CompareTo()方法
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Square other)
        {
            long area1 = this.Height * this.Width;
            long area2 = other.Height * other.Width;

            if (area1 == area2)
                return 0;
            else if (area1 > area2)
                return 1;
            else if (area1 < area2)
                return -1;
            else
                return -1;
        }
    }
}
