using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithBitArray
{
    internal class Program
    {
        static string BitArrayToString(BitArray bitArray)
        {
            char[] chars = new char[bitArray.Length];
            for (int i = 0; i < bitArray.Length; i++)
            {
                chars[i] = bitArray[i] ? '1' : '0';
            }
            return new string(chars);
        }

        static void Main(string[] args)
        {
            // Create a BitArray with 10 bits, all initialized to false
            BitArray bits1 = new BitArray(10);
            Console.WriteLine("\nbits1 content: " + BitArrayToString(bits1));

            for (int i = 0; i < bits1.Count; i++)
            {
                bool bitVal = bits1[i];
                Console.WriteLine($"Bit at index {i} Is :  {bitVal}");
            }
            Console.WriteLine("--------------------- Part 2--------------------------");
            Console.ReadLine();
            // Create a BitArray from an array of booleans
            bool[] initialValues = { true, false, true, true, false };
            BitArray bits2 = new BitArray(initialValues);

            Console.WriteLine("\nbits2 content: " + BitArrayToString(bits2));
            for (int i = 0; i < bits2.Count; i++)
            {
                bool bitVal = bits2[i];
                Console.WriteLine($"Bit at index {i}: {bitVal}");
            }
            Console.WriteLine("--------------------- Part 3 --------------------------");
            Console.ReadLine();
            // Create a BitArray from a byte array
            byte[] byteArray = { 0xAA, 0x55 }; // 10101010, 01010101
            BitArray bits3 = new BitArray(byteArray);

            Console.WriteLine("\nbits3 content: " + BitArrayToString(bits3));
            for (int i = 0; i < bits3.Count; i++)
            {
                bool bitVal = bits3[i];
                Console.WriteLine($"Bit at index {i}: {bitVal}");
            }
            Console.WriteLine("--------------------- Part 4 ---------- Basic Operations ----------------");
            Console.ReadLine();
            // Basic Operations
            BitArray bits4 = new BitArray(8); // 00000000
            Console.WriteLine("\nbits4 Before Change : " + BitArrayToString(bits4));
            bits4.Set(2, true); // Set the bit at index 2 to true
            bits4.Set(5, true); // Set the bit at index 5 to true
            bits4[7] = true;    // Set the bit at index 7 to true
            bits4[3] = false;   // Set the bit at index 3 to false


            Console.WriteLine("\nbits4 content: " + BitArrayToString(bits4));
            for (int i = 0; i < bits4.Count; i++)
            {
                bool bitVal = bits4[i];
                Console.WriteLine($"Bit at index {i}: {bitVal}");
            }
            Console.ReadLine();
            bits4.SetAll(true); // Set all bits to true
            Console.WriteLine("\nbits4 content after setting all to true: " + BitArrayToString(bits4));
            for (int i = 0; i < bits4.Count; i++)
            {
                bool bitVal = bits4[i];
                Console.WriteLine($"Bit at index {i}: {bitVal}");
            }
            Console.ReadLine();
            bits4.SetAll(false); // Set all bits to false
            Console.WriteLine("\nbits4 content after setting all to false:" + BitArrayToString(bits4));
            for (int i = 0; i < bits4.Count; i++)
            {
                bool bitVal = bits4[i];
                Console.WriteLine($"Bit at index {i}: {bitVal}");
            }
            Console.WriteLine("--------------------- Part 5 --------------------------");
            Console.ReadLine();
            bool bitValue = bits4[3] = true; // Get the value of the bit at index 3
            int length = bits4.Length; // Get the number of bits in the BitArray

            Console.WriteLine("My length " + length + " -- " + bitValue);
            // Iterating Through a BitArray
            BitArray bits5 = new BitArray(8);
            bits5.SetAll(true);

            Console.WriteLine("\nbits5 content: " + BitArrayToString(bits5));
            for (int i = 0; i < bits5.Count; i++)
            {
                bool bitVal = bits5[i];
                Console.WriteLine($"Bit at index {i}: {bitVal}");
            }

            Console.ReadKey();

            Console.WriteLine("--------------------- Bitwise Operators --------------------------");
            Console.ReadKey();

            // Create two BitArrays
            BitArray bits11 = new BitArray(new bool[] { true, false, true, false });
            BitArray bits21 = new BitArray(new bool[] { true, true, true, false });


            Console.WriteLine("bits1 : " + BitArrayToString(bits11));
            Console.WriteLine("bits2 : " + BitArrayToString(bits21));
            Console.WriteLine("\nBitWise Operators :\n");


            // Bitwise AND operation
            BitArray resultAnd = new BitArray(bits11);
            resultAnd.And(bits21);


            Console.WriteLine("\nBitwise AND result: ");
            Console.WriteLine(BitArrayToString(bits11));
            Console.WriteLine(BitArrayToString(bits21));
            Console.WriteLine("------------");
            Console.WriteLine(BitArrayToString(resultAnd));

            // Bitwise Or operation

            BitArray resultOr = new BitArray(bits11);
            resultOr.Or(bits21);


            Console.WriteLine("\nBitwise Or result: ");
            Console.WriteLine(BitArrayToString(bits11));
            Console.WriteLine(BitArrayToString(bits21));
            Console.WriteLine("------------");
            Console.WriteLine(BitArrayToString(resultOr));

            // Bitwise Not operation
            BitArray resultNot = new BitArray(bits11);
            resultNot.Not();

            Console.WriteLine("\nBitwise Not result: ");
            Console.WriteLine(BitArrayToString(bits11));
            Console.WriteLine("------------");
            Console.WriteLine(BitArrayToString(resultNot));

            // Bitwise Xor operation
            /*
             Explaining the XOR:
             XOR Table: returns true of the two bits are diffrent, otherwise returns false.

                | A | B | A XOR B |
                |---|---|---------|
                | 0 | 0 |    0    |
                | 0 | 1 |    1    |
                | 1 | 0 |    1    |
                | 1 | 1 |    0    |
             */
            BitArray resultXor = new BitArray(bits11);
            resultXor.Xor(bits21);


            Console.WriteLine("\nBitwise Xor result: ");
            Console.WriteLine(BitArrayToString(bits11));
            Console.WriteLine(BitArrayToString(bits21));
            Console.WriteLine("------------");
            Console.WriteLine(BitArrayToString(resultXor));

            Console.ReadKey();













            Console.ReadLine();
        }
    }
}
