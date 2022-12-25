public class Solution 
{
    private IList<int> DiffWaysToComputeRec(string expr)
    {
        var result = new List<int>();

        for (int i = 0; i < expr.Length; ++i)
        {
            if (expr[i] == '+' ||
                expr[i] == '-' ||
                expr[i] == '*')
            {
                string part1 = expr.Substring(0, i);
                string part2 = expr.Substring(i + 1);

                IList<int> results1 = DiffWaysToComputeRec(part1);
                IList<int> results2 = DiffWaysToComputeRec(part2);

                foreach (int result1 in results1)
                {
                    foreach (int result2 in results2)
                    {
                        int currentResult = 0;
                        switch (expr[i])
                        {
                            case '+':
                                currentResult = result1 + result2;
                                break;

                            case '-':
                                currentResult = result1 - result2;
                                break;

                            case '*':
                                currentResult = result1 * result2;
                                break;

                            default:
                                throw new NotImplementedException();
                        }

                        result.Add(currentResult);
                    }
                }
            }

        }

        if (result.Count == 0)
        {
            result.Add(int.Parse(expr));
        }

        return result;
    }

    public IList<int> DiffWaysToCompute(string expression) 
    {
        return DiffWaysToComputeRec(expression);
    }
}
