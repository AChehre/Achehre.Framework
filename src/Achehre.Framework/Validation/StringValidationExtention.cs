﻿using System;
using Achehre.Framework.Resources;

namespace Achehre.Framework.Validation
{
    public static class StringExtention
    {
        public static void AssertArgumentIsNotNullOrWhiteSpace(this string str, string name)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentNullException(name, ErrorMessageResource.ArgumentNullError);
            }
        }
    }
}