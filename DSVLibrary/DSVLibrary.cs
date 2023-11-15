using System;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSVLibrary
{
    public class MathLibrary
    {
        public static int[] ReserveSort(int[] InArray)
        {
            bool bCapture = false;
            while (!bCapture)
            {
                bCapture = true;

                for (int i = 0; i < InArray.Length - 1; i++)
                {
                    if (InArray[i] > InArray[i + 1])
                    {
                        bCapture = false;
                        int temp = InArray[i];
                        InArray[i] = InArray[i + 1];
                        InArray[i + 1] = temp;
                    }
                }
            }

            Array.Reverse(InArray);
            return InArray;
        }

        public static int[] GenerateInput(int InSize, int InGMax, int InGMin)
        {
            if (InSize <= 1 || InGMax <= 0 || InGMin <= 0) throw new ArgumentException();

            int[] NArray = new int[InSize];
            Random NRandom = new Random();

            for (int c = 0; c < InSize; c++)
            {
                if (InGMin > InGMax) NArray[c] = 0;
                else NArray[c] = NRandom.Next(InGMin, InGMax);
            }

            return NArray;
        }

        int Inverse(int NewInput)
        {
            int reverse = 0;
            int reminder = 0;

            while (NewInput != 0)
            {
                reminder = NewInput % 10;
                reverse = reverse * 10 + reminder;
                NewInput /= 10;
            }

            return reverse;
        }

        double Quadra(double A, double B, double C)
        {
            return System.Math.Pow(B, 2) - 4 * A * C;
        }

        double QuadraX1X2(double InA, double InB, double InDec, bool IsTwo)
        {
            if (InDec < 0.0f) return 0.0f;
            return IsTwo ? (-InB + System.Math.Sqrt(InDec)) / 2 * InA : (-InB - System.Math.Sqrt(InDec)) / 2 * InA;
        }
    }
}