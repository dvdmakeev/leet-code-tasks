public class Solution 
{
    public char NextGreatestLetter(char[] letters, char target) 
    {
        int start = 0;
        int end = letters.Length - 1;

        while (start <= end)
        {
            int middle = (start + end) / 2;
            if (letters[middle] > target)
            {
                end = middle - 1;
            }
            else
            {
                start = middle + 1;
            }
        }

        return letters[start % letters.Length];
    }
}
