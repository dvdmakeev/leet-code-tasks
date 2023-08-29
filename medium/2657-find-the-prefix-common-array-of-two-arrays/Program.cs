/*
    два массива перестановок
    найти C: C[i] - кол-во элементов в A[0..i] и B[0..i]

    if a[0] = b[0]:
        C[0] = 1
    else:
        C[0] = 0

    if seen.Contains(a[i] || b[i]):
        C[i] = C[i - 1] + 1
    elif seen.Contains(a[i] && b[i]):
        C[i] = C[i - 1] + 2
    else:
        C[i] = C[i - 1]
*/

public class Solution 
{
    public int[] FindThePrefixCommonArray(int[] A, int[] B) 
    {
        int[] C = new int[A.Length];
        var seen = new HashSet<int>();

        for (int i = 0; i < C.Length; ++i)
        {
            int x = 0;
            if (A[i] == B[i])
            {
                ++x;
            }
            else if (seen.Contains(A[i]) && seen.Contains(B[i]))
            {
                x += 2;
            }
            else if (seen.Contains(A[i]))
            {
                seen.Remove(A[i]);
                ++x;
                seen.Add(B[i]);
            }
            else if (seen.Contains(B[i]))
            {
                seen.Remove(B[i]);
                ++x;
                seen.Add(A[i]);
            }
            else
            {
                seen.Add(A[i]);
                seen.Add(B[i]);
            }

            if (i != 0)
            {
                x += C[i - 1];
            }

            C[i] = x;
        }

        return C;
    }
}
