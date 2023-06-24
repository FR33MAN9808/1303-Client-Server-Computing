using System;

namespace ClntSrvrWk1.Lessons.Week2
{
    public class TestArray
    {
        public void RunTest()
        {
            TestCharArray();
            TestPointArray();
            TestMultidimensionalRectangularArray();
            TestMultiDimentionalJaggedArray();
        }

        public void TestCharArray()
        {
            char[] vowels = new char[5];
            vowels[0] = 'a';
            vowels[1] = 'e';
            vowels[2] = 'i';
            vowels[3] = 'o';
            vowels[4] = 'u';

            char[] vowels2 = new char[] { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < vowels2.Length; i++)
            {
                Console.Write($"{vowels2[i]} ");
            }
        }

        public void TestPointArray()
        {
            // Point[] pointArray = new Point[3];
            var pointArray = new Point[3];

            for (int i = 0; i < pointArray.Length; i++)
            {
                pointArray[i] = new Point()
                {
                    x = i,
                    y = i * 2
                };
            }
        }

        /// <summary>
        /// create a 2 dimensional rectangular array
        /// {0,1,2}
        /// {3,4,5}
        /// {6,7,8}
        /// </summary>
        public void TestMultidimensionalRectangularArray()
        {
            Console.WriteLine("Rectangular array example:");
            int[,] matrix = new int[3, 3];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = (i * 3) + j;
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public void TestMultiDimentionalJaggedArray()
        {
            int[][] matrix = new int[3][];

            Console.WriteLine("Jagged array example:");
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[3];
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = (i * 3) + j;
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
