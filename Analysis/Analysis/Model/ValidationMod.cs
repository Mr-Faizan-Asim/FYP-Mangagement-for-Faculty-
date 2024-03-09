using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysis.Model
{
    public static class ValidationMod
    {

        public static bool EndsWithSuffix<T>(this T text, string suffix)
        {
            if (text == null || suffix == null)
            {
                return false; // Handle null cases
            }

            return text.ToString().ToLower().EndsWith(suffix.ToLower());
        }
    }
}
