    public class Solution 
    {
        private string RevertIthChar(string s, int i)
        {
            string result;

            char c = s[i];
            if (char.IsLower(c))
            {
                result = s.Remove(i, 1).Insert(i, char.ToUpper(c).ToString());
            }
            else
            {
                result = s.Remove(i, 1).Insert(i, char.ToLower(c).ToString());
            }

            return result;
        }

        private void LetterCasePermutationRec(string s, HashSet<string> permutations, int fromI)
        {
            if (fromI >= s.Length && !permutations.Contains(s))
            {
                permutations.Add(s);
            }
            
            for (int i = fromI; i < s.Length; ++i)
            {
                if (char.IsLetter(s[i]))
                {
                    string reverted = RevertIthChar(s, i);
                    
                    LetterCasePermutationRec(reverted, permutations, i + 1);
                }

                LetterCasePermutationRec(s, permutations, i + 1);
            }
        }

        public IList<string> LetterCasePermutation(string s)
        {
            var permutations = new HashSet<string>();
            LetterCasePermutationRec(s, permutations, 0);

            return permutations.ToList();
        }
    }
