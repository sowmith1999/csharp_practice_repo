using System;
using System.Linq;

namespace practice
{
    public class TwoSumArrayTuple
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            for (var i=0;i<=numbers.Length;i++)
            {
                var difference = target - numbers[i];
                if(Array.Exists(numbers,number=>number==difference))
                {
                    var reqIndex = Array.LastIndexOf(numbers, difference);
                    if (reqIndex > i)
                    {
                        return new[] {i, reqIndex};
                    }
                    else
                    {
                        return new[] {reqIndex, i};
                    }
                }
                else
                {
                    continue;
                }
                
            }
            return new int[0];
        }
    }
}