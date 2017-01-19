using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polindrome
{
    public static class PolidromExtension
    {
        public static bool IsPalindrome(this string value)
        {
            for (int i = 0; i < value.Length / 2 + 1; i++)
            {
                if (value[i] != value[value.Length - i - 1])
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }
    }
}
