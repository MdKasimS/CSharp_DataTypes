Console.WriteLine("----------------------------------------------------------------------------");
Console.Write("{0, -8} {1,-4} ",
                arg0: "Type",
                arg1: "Byte(s) of memory");

Console.WriteLine("{0, 17} {1,31}",
                arg0: "Min",
                arg1: "Max");
Console.WriteLine("----------------------------------------------------------------------------");


Console.Write("{0, -8} {1, -4}",
                arg0:"sbyte",
                arg1:sizeof(sbyte));
Console.WriteLine("{0,31} {1,31}",
                    arg0: sbyte.MinValue,
                    arg1: sbyte.MaxValue);

Console.Write("{0, -8} {1, -4}" , 
                arg0:"byte",
                arg1: sizeof(byte));
Console.WriteLine("{0, 31} {1, 31}" , 
                arg0: byte.MinValue,
                arg1: byte.MaxValue);

Console.Write("{0, -8} {1,-4 }" , 
                arg0: "short",
                arg1: sizeof(short));
Console.WriteLine("{0, 31} {1, 31}" , 
                arg0: short.MinValue,
                arg1: short.MaxValue);

Console.Write("{0, -8} {1, -4}" , 
                arg0: "ushort",
                arg1: sizeof(ushort));
Console.WriteLine("{0, 31} {1, 31}" , 
                arg0: ushort.MinValue,
                arg1: ushort.MaxValue);

Console.Write("{0, -8} {1, -4}" , 
                arg0: "int",
                arg1: sizeof(int));
Console.WriteLine("{0, 31} {1,31 }" , 
                arg0: int.MaxValue,
                arg1: int.MinValue);

Console.Write("{0, -8} {1, -4}" , 
                arg0: "unit",
                arg1: sizeof(uint));
Console.WriteLine("{0,31 } {1, 31}" , 
                arg0: uint.MinValue,
                arg1: uint.MaxValue);

Console.Write("{0, -8} {1,-4 }" , 
                arg0: "long",
                arg1: sizeof(long));
Console.WriteLine("{0,31 } {1, 31}" , 
                arg0: long.MinValue,
                arg1: long.MaxValue);

Console.Write("{0, -8} {1,-4 }" , 
                arg0: "ulong",
                arg1: sizeof(ulong));
Console.WriteLine("{0, 31} {1,31 }" , 
                arg0: ulong.MinValue,
                arg1: ulong.MaxValue);

Console.Write("{0, -8} {1,-4 }" , 
                arg0: "float",
                arg1: sizeof(float));
Console.WriteLine("{0, 31} {1, 31}" , 
                arg0: float.MinValue,
                arg1: float.MinValue);

Console.Write("{0, -8} {1, -4}" , 
                arg0: "double",
                arg1: sizeof(double));
Console.WriteLine("{0, 31} {1, 31}" , 
                arg0: double.MinValue,
                arg1: double.MaxValue);

Console.Write("{0, -8} {1,-4 }" , 
                arg0: "decimal",
                arg1: sizeof(decimal));
Console.WriteLine("{0, 31} {1,31 }" , 
                arg0: decimal.MaxValue,
                arg1: decimal.MinValue);
Console.WriteLine("----------------------------------------------------------------------------");
