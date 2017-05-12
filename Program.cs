using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example7
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte valueSByte = -100;
            byte valueByte = 100;
            short valudShort = -20000;
            ushort valueUShort = 50000;
            int valueInt = -1000000000;
            uint valueUInt = 4000000000;
            long valueLong = -800000000000;
            ulong valueULong = 9000000000000000000;

            float valueFlort = 3.1415F;
            double valueDouble = 3.14159265358979;

            char valueChar = 'A';
            string valueString = "C# PROGRAM";

            bool valueBool = true;

            Console.WriteLine("{1} :{0}", valueSByte,valueSByte.GetType().Name);
            Console.WriteLine("{1} :{0}", valueByte,valueByte.GetType().Name);
            Console.WriteLine("{1} :{0}", valudShort,valudShort.GetType().Name);
            Console.WriteLine("{1} :{0}", valueUShort, valueUShort.GetType().Name);
            Console.WriteLine("{1} :{0}", valueInt, valueInt.GetType().Name);
            Console.WriteLine("{1} :{0}", valueUInt, valueUInt.GetType().Name);
            Console.WriteLine("{1} :{0}", valueLong, valueLong.GetType().Name);
            Console.WriteLine("{1} :{0}", valueULong, valueULong.GetType().Name);
            Console.WriteLine("{1} :{0}", valueFlort, valueFlort.GetType().Name);
            Console.WriteLine("{1} :{0}", valueDouble, valueDouble.GetType().Name);
            Console.WriteLine("{1} :{0}", valueChar, valueChar.GetType().Name);
            Console.WriteLine("{1 }:{0}", valueString, valueString.GetType().Name);
            Console.WriteLine("{1} :{0}", valueBool, valueBool.GetType().Name);
        }
    }
}
