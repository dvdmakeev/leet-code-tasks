public class Solution 
{
    /*
        [-2 0 1 2 4 5]
        ["-2" "0->2" "4" "5"]

        []
        []

        startRange
        endRange
        current

        if range == null
            range = (current, current)
        elif current == endRange + 1
            endRange = current
        else
            result.Add(range)
            range = (current, current)
    */
    public class Range
    {
        public int Start { get; set; }
        public int End { get; set; }

        public Range(int start, int end)
        {
            Start = start;
            End = end;
        }

        public override string ToString()
        {
            if (Start == End)
            {
                return Start.ToString();
            }

            return $"{Start}->{End}";
        }
    }

    public IList<string> SummaryRanges(int[] nums) 
    {
        var formattedRanges = new List<string>();
        Range range = null;

        for (int i = 0; i < nums.Length; ++i)
        {
            if (range == null)
            {
                range = new Range(nums[i], nums[i]);
            }
            else if (range.End + 1 == nums[i])
            {
                range.End = nums[i];
            }
            else
            {
                formattedRanges.Add(range.ToString());
                range = new Range(nums[i], nums[i]);
            }
        }

        if (range != null)
        {
            formattedRanges.Add(range.ToString());
        }

        return formattedRanges;
    }
}
