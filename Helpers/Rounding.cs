﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Helpers
{
    public class Rounding
    {
        public static double RoundTwoDecimalPlaces(double value)
        {
            return Math.Round(value, 2, MidpointRounding.ToEven);
        }
    }
}