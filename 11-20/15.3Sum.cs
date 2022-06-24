using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeNote;

public static partial class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
		int length = nums.Length;
        Array.Sort(nums);
		List<IList<int>> result = new List<IList<int>>();
		for (int first = 0; first < length; first++) // iterate first pointer
		{
			if (first > 0 && nums[first] == nums[first - 1]) continue; //skip same value
			int third = length - 1; // right pointer
			int target = -nums[first];
			for (int second = first + 1; second < length; second++)
			{
				if (second > first + 1 && nums[second] == nums[second - 1]) continue; //skip same value
				while (second < third && nums[second] + nums[third] > target)
				{
					--third; //move right pointer
				}
				if (second == third) // b no longer < c
				{
					break;
				}
				if (nums[second] + nums[third] == target)
				{
					result.Add(new List<int> { nums[first], nums[second], nums[third] });
				}

				string x = "".AsSpan();
			}
		}
		return result;
	}
}	
