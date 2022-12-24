    public class Solution 
    {
        private char GetOppositeChar(char c)
        {
            if (c < 'a')
            {
                return (char)((int)c -(int)'A' + (int)'a');
            }
            else
            {
                return (char)((int)c -(int)'a' + (int)'A');
            }
        }

        public IList<string> LetterCasePermutation(string s)
        {
            var permutations = new List<string>();
            permutations.Add("");

            for (int i = 0; i < s.Length; ++i)
            {
                var newPermutations = new List<string>();
                foreach (string current in permutations)
                {
                    if (char.IsDigit(s[i]))
                    {
                        newPermutations.Add(current + s[i]);
                    }
                    else
                    {
                        newPermutations.Add(current + s[i]);
                        newPermutations.Add(current + GetOppositeChar(s[i]));
                    }
                }

                permutations = newPermutations;
            }

            return permutations;
        }
    }
