using System;

namespace CalculateAngle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the hours (1-12): ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Enter the minutes (0-59): ");
                int minutes = int.Parse(Console.ReadLine());


                double hour_angle = (hours % 12 + minutes / 60.0) * 30;

                double minute_angle = minutes * 6;

                // calculate the difference between the two angles
                double angle_diff = Math.Abs(hour_angle - minute_angle);

                // calculate the lesser angle between the two angles
                if (angle_diff > 180)
                {
                    angle_diff = 360 - angle_diff;
                }

                // output the result to the console
                Console.WriteLine($"The lesser angle between the hour and minute hands is {angle_diff} degrees.");
            }
        
        }
    }
}
