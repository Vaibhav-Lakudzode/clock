﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDelegationApp
{
    public class MathEngineProcessor
    {
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine(result);
            return result;
        }
        public int Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine(result);
            return result;
        }
        public int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine(result);
            return result;
        }
        public int Divide(int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine(result);
            return result;
        }
    }
}
