using System.Runtime.InteropServices;

namespace UnionStructExample
{
    /// <summary>
    ///  通过预留字段来“补齐”内存分配
    /// </summary>
    public class StructExample
    {
        public byte b1;
        public char c2;
        public int i3;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] reserved;
    }
    /// <summary>
    ///  MSDN   StructLayoutAttribute主题
    /// </summary>
    [StructLayoutAttribute(LayoutKind.Explicit)]
    struct SignedNumber
    {
        [FieldOffsetAttribute(0)]
        public sbyte Num1;
        [FieldOffsetAttribute(0)]
        public short Num2;
        [FieldOffsetAttribute(0)]
        public int Num3;
        [FieldOffsetAttribute(0)]
        public long Num4;
        [FieldOffsetAttribute(0)]
        public float Num5;
        [FieldOffsetAttribute(0)]
        public double Num6;
    }

    /// <summary>
    ///  可以创建混合类型的联合结构体
    ///  但不能把一种引用类型叠加到一种数值类型上
    /// </summary>
    [StructLayoutAttribute(LayoutKind.Explicit)]
    struct SignedNumberWithText
    {
        [FieldOffsetAttribute(0)]
        public sbyte Num1;
        [FieldOffsetAttribute(0)]
        public short Num2;
        [FieldOffsetAttribute(0)]
        public int Num3;
        [FieldOffsetAttribute(0)]
        public long Num4;
        [FieldOffsetAttribute(0)]
        public float Num5;
        [FieldOffsetAttribute(0)]
        public double Num6;
        [FieldOffsetAttribute(16)]
        public string Text1;
    }

}
