﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3.Extensions
{
    public static class StringExtensions
    {
        public static int CountLines(this string input) =>
            input.Split(Environment.NewLine).Length;

    }
}
