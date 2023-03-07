using CalculateAngle;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reiz_Tech
{
    public class DepthCalculator
    {
        public static int CalculateDepth(Branch branch)
        {
            if (branch._branches.Count == 0)
                return 1;
            else
            {
                int maxChildDepth = 0;

                foreach (var child in branch._branches)
                {
                    int chilDepth = CalculateDepth(child);
                    maxChildDepth = Math.Max(maxChildDepth, chilDepth);
                }
                return maxChildDepth + 1;
            }
        }
    }
}
