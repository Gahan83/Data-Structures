namespace Arrays.Arrays
{
    public class IntersectionofArray
    {
        //public int[] Intersect(int[] nums1, int[] nums2)
        //{
        //    return nums1.GroupBy(x => x)
        //       .ToDictionary(g => g.Key, g => Math.Min(g.Count(), nums2.Count(n => n == g.Key)))
        //       .SelectMany(kvp => Enumerable.Repeat(kvp.Key, kvp.Value))
        //       .ToArray();
        //}

        public int[] Intersect(int[] nums1, int[] nums2)
        {
            // Dictionary to store the counts of elements in nums1
            Dictionary<int, int> countMap = new Dictionary<int, int>();
            List<int> intersection = new List<int>();

            // Count occurrences of each number in nums1
            foreach (int num in nums1)
            {
                if (countMap.ContainsKey(num))
                {
                    countMap[num]++;
                }
                else
                {
                    countMap[num] = 1;
                }
            }

            // Find intersections by iterating through nums2
            foreach (int num in nums2)
            {
                if (countMap.ContainsKey(num) && countMap[num] > 0)
                {
                    intersection.Add(num); // Add to result if present in both
                    countMap[num]--;       // Decrement the count in the map
                }
            }

            // Convert the intersection list to an array and return
            return intersection.ToArray();
        }
    }
}
