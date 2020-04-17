using System;
using System.Collections.Generic;
using System.Text;

namespace Extension
{
    public static class ExtensionMethod
    {
        public static bool IsDivisibleBy3(this int i)
        {
            if ((i / 3)==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
