using System;

namespace Advent3
{
    public class Toboggan
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public int calculate(string[] input)
        {
            int count = 0;
            int rowIndex = 0;
            int elementIndex = 0;
            foreach (string row in input)
            {
                try
                {
                    if (elementIndex > row.Length - 1)
                    {
                        if (elementIndex == 33)
                        {
                            elementIndex = 2;
                        }
                        else if (elementIndex == 32)
                        {
                            elementIndex = 1;
                        }
                        else if (elementIndex == 31)
                        {
                            elementIndex = 0;
                        }
                    }
                    if (input[rowIndex][elementIndex].ToString() == "#")
                    {
                        count += 1;
                    }
                    rowIndex += 1;
                    elementIndex += 3;
                    Console.WriteLine("row index: " + rowIndex);
                    Console.WriteLine("element index: " + elementIndex);
                }
                catch
                {

                }
            }
            Console.WriteLine("Count: " + count);
            return count;
        }
    }
}
