﻿namespace Strategy
{
    public class OperationAdd : IOperation
    {
        public int Calculate(int val1, int val2)
        {
            return val1 + val2;
        }
    }
}