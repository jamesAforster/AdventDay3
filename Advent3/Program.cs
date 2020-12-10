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
                        elementIndex = Math.Abs(elementIndex - row.Length);
                    }
                    if (input[rowIndex][elementIndex].ToString() == "#")
                    {
                        count += 1;
                    }
                    elementIndex += 1;
                    rowIndex += 2;
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
