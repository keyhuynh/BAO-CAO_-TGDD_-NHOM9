using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasm.Extensions
{
    public static class DecimalExtensions
    {
        public static string ToCurrency(this decimal decimalValue)
        {
            return $"{decimalValue:C}";
        }
    }
}
