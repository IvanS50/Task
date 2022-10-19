using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp85
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 7, 13 };
            Console.WriteLine(NearToTen(nums));
            Console.ReadKey();
        }

        static int NearToTen(List<int> nums)
        {
            int maxNum = nums[0];
            int numPad = Math.Abs(10 - nums[0]);

            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] == 10)
                {
                    return nums[i];
                }

                else if (Math.Abs(10 - nums[i]) < numPad)
                {
                    maxNum = nums[i];
                    numPad = Math.Abs(10 - nums[i]);
                }

                else if (Math.Abs(10 - nums[i]) == numPad)
                {
                    if (maxNum < nums[i])
                    {
                        maxNum = nums[i];
                    }
                }
            }
            return maxNum;
        }
    }


}
