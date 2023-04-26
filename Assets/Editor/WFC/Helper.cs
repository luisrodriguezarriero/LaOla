﻿
namespace WFC_Unity_Luyso
{
    public static class Helper
    {
        public static int Random(this double[] weights, double r)
        {
            double sum = 0;
            for (int i = 0; i < weights.Length; i++) sum += weights[i];
            double threshold = r * sum;

            double partialSum = 0;
            for (int i = 0; i < weights.Length; i++)
            {
                partialSum += weights[i];
                if (partialSum >= threshold) return i;
            }
            return 0;
        }
        public static readonly int[] dx = { -1, 0, 1, 0 };
        public static readonly int[] dy = { 0, 1, 0, -1 };
        public static readonly int[] opposite = { 2, 3, 0, 1 };
        
    }
    public enum Heuristic { Entropy, MRV, Scanline };

    
}




