﻿using System;

namespace FirstTask.MathModule
{
    public static class Task1A
    {
        public static double Calculate(double z, double k)
        {
            int i;
            double sumA = 0;
            for (i = 1; i <= k; i++)
            {
                sumA += ((1 / Math.Sqrt(z * i)) + Math.Tan(k / i));
            }
            return sumA;
        }
    }
}