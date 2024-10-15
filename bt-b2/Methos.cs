public static class Methods
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numDictionary = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (numDictionary.ContainsKey(complement))
            {
                return new int[] { numDictionary[complement], i };
            }

            numDictionary[nums[i]] = i;
        }

        return new int[] { };
    }

    public static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;

        int uniqueIndex = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[uniqueIndex])
            {
                uniqueIndex++;
                nums[uniqueIndex] = nums[i];
            }
        }

        return uniqueIndex + 1;
    }

    public static List<int> TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (frequencyMap.ContainsKey(num))
            {
                frequencyMap[num]++;
            }
            else
            {
                frequencyMap[num] = 1;
            }
        }

        var topKElements = frequencyMap.OrderByDescending(x => x.Value)
                                       .Take(k)
                                       .Select(x => x.Key)
                                       .ToList();

        return topKElements;
    }

    public static int MaxProfit(int[] prices)
    {
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        foreach (var price in prices)
        {
            if (price < minPrice)
            {
                minPrice = price;
            }

            int profit = price - minPrice;
            if (profit > maxProfit)
            {
                maxProfit = profit;
            }
        }

        return maxProfit;
    }
}
