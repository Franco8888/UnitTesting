﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }

        public double Devide(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return x / y;
            }
        }
    }
}