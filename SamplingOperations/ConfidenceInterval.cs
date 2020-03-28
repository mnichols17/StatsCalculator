using System;
using System.Collections.Generic;
using System.Text;
using StatOperations;
using MathOperations;
using System.IO;

namespace SamplingOperations
{
    class ConfidenceInterval
    {
        static private decimal Tscore(int df, decimal foundA)
        {
            using (var reader = new StreamReader("../../../t-table.csv"))
            {
                int temp = 0;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('\n');

                    switch (foundA)
                    {
                        case (.25m):
                            temp = 1;
                            break;
                        case (.1m):
                            temp = 2;
                            break;
                        case (.05m):
                            temp = 3;
                            break;
                        case (.025m):
                            temp = 4;
                            break;
                        case (.01m):
                            temp = 5;
                            break;
                        case (.005m):
                            temp = 6;
                            break;
                        case (.001m):
                            temp = 7;
                            break;
                        case (.0005m):
                            temp = 8;
                            break;
                    }

                    foreach (var s in values)
                    {
                        var tem = s.Split(',');
                        if (tem[0] == Convert.ToString(df))
                        {
                            return (Convert.ToDecimal(tem[temp]));
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
                return -1;
            }
        }
        static public decimal Interval(int percent, int[] nums)
        {
            int df = nums.Length - 1;
            decimal mean = Mean.findMean(nums);
            decimal sd = StandardDeviation.findSD(nums);
            decimal confidence = Multiplication.Product(percent, .01m);
            decimal ans = Division.Quotient((1 - confidence), 2);
            return Tscore(df, ans);
        }
    }
}