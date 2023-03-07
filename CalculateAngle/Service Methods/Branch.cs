using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateAngle
{
    public class Branch
    {
        public List<Branch> _branches;
        public Branch()
        {
            _branches = new List<Branch>();
        }

        public int Depth()
        {
            if (_branches.Count == 0)
            {
                return 1;
            }
            else
            {
                int maxDepth = 0;

                foreach (Branch child in _branches)
                {
                    int childDepth = child.Depth();
                    maxDepth = Math.Max(maxDepth, childDepth);
                }

                return maxDepth + 1;
            }
        }
    }
}
