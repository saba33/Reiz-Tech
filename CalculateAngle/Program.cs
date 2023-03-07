using Reiz_Tech;
using System;

namespace CalculateAngle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I have Commented code and separated different functional Methods with Regions,
            // just open the region And Uncomment part of the code that you wnat to use.

            // Calculate angle dagrees
            #region Calculate angle in degrees
            AngleCalculator.calculate();
            #endregion

            // Implementing 5 level Branch Tree manually
            #region Implementing 5 level Branch Tree manually

            Branch root = new Branch();
            // (Level 1)
            Branch child1 = new Branch();
            root._branches.Add(child1);

            Branch child2 = new Branch();
            root._branches.Add(child2);

            //(level 2)
            Branch child11 = new Branch();
            child1._branches.Add(child11);

            Branch child12 = new Branch();
            child1._branches.Add(child12);

            Branch child21 = new Branch();
            child2._branches.Add(child21);

            Branch child22 = new Branch();
            child2._branches.Add(child22);

            //(level 3)
            Branch child111 = new Branch();
            child11._branches.Add(child111);

            Branch child112 = new Branch();
            child11._branches.Add(child112);

            Branch child121 = new Branch();
            child12._branches.Add(child121);

            Branch child122 = new Branch();
            child12._branches.Add(child122);

            Branch child211 = new Branch();
            child21._branches.Add(child211);

            Branch child212 = new Branch();
            child21._branches.Add(child212);

            Branch child221 = new Branch();
            child22._branches.Add(child221);

            Branch child222 = new Branch();
            child22._branches.Add(child222);

            // (level 4)
            Branch child1111 = new Branch();
            child111._branches.Add(child1111);

            Branch child1112 = new Branch();
            child111._branches.Add(child1112);

            Branch child1121 = new Branch();
            child112._branches.Add(child1121);

            Branch child1122 = new Branch();
            child112._branches.Add(child1122);

            Branch child1211 = new Branch();
            child121._branches.Add(child1211);

            Branch child1212 = new Branch();
            child121._branches.Add(child1212);

            Branch child1221 = new Branch();
            child122._branches.Add(child1221);

            Branch child1222 = new Branch();
            child122._branches.Add(child1222);

            Branch child2111 = new Branch();
            child211._branches.Add(child2111);

            Branch child2112 = new Branch();
            child211._branches.Add(child2112);

            Branch child2121 = new Branch();
            child212._branches.Add(child2121);

            Branch child2122 = new Branch();
            child212._branches.Add(child2122);

            Branch child2211 = new Branch();
            child221._branches.Add(child2211);

            Branch child2212 = new Branch();
            child221._branches.Add(child2212);

            Branch child2221 = new Branch();
            child222._branches.Add(child2221);

            Branch child2222 = new Branch();
            child222._branches.Add(child2222);

            // (level 5)
            Branch child11111 = new Branch();
            child1111._branches.Add(child11111);

            Branch child11112 = new Branch();
            child1111._branches.Add(child11112);

            Branch child11121 = new Branch();
            child1112._branches.Add(child11121);

            Branch child11122 = new Branch();
            child1112._branches.Add(child11122);

            Branch child11211 = new Branch();
            child1121._branches.Add(child11211);

            Branch child11212 = new Branch();
            child1121._branches.Add(child11212);

            Branch child11221 = new Branch();
            child1122._branches.Add(child11221);

            Branch child11222 = new Branch();
            child1122._branches.Add(child11222);

            Branch child12111 = new Branch();
            child1211._branches.Add(child12111);

            #endregion

            // Implementing Branch Tree with loop and calculating it's Depth with integrated Method.
            #region Implementing 5 level tree with with loop
            //Branch root = new Branch();

            //Branch current = root;

            //for (int i = 0; i < 5; i++)
            //{
            //    Branch child1 = new Branch();
            //    Branch child2 = new Branch();
            //    current._branches.Add(child1);
            //    current._branches.Add(child2);
            //    current = child1;
            //}

            //int depth = root.Depth();
            //Console.WriteLine("Max Depth: " + depth);
            #endregion

            // Calculating Branch Tree Depth with separated Method 
            #region Calculating Depth with separated method
            //int result = DepthCalculator.CalculateDepth(root);
            //Console.WriteLine(result);
            #endregion
        }
    }
}
