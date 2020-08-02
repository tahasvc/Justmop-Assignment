using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_2
{
    class SimilarityCalculator
    {
        /// <summary>This method for calculating similarity in string
        /// </summary>
        /// <param name="value">the new string value</param>
        public static int calculate(string value)
        {
            char[] strArr = value.ToCharArray();
            int length = strArr.Length;
            int count = length;
            for (int t = 1; t < length; t++)
            {
                int len = length - t;
                int k = 0;
                for (; k < len; k++)
                    if (strArr[k] != strArr[k + t])
                    {
                        break;
                    }
                count += k;
            }
            return count;
        }
    }
}
