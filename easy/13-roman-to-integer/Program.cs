public class Program 
{
    public int RomanToInt(string s) 
	{
        int I = 1;
        int V = 5;
        int X = 10;
        int L = 50;
        int C = 100;
        int D = 500;
        int M = 1000;
        
        int res = 0;
        int prev = 0;
        for (int i = s.Length - 1; i >= 0; --i)
        {
            if (s[i] == 'I') 
            {
                if (prev == V || prev == X) 
                {
                    res -= I;
                }
                else
                {
                    res += I;
                }
                prev = I;
            }
            else if (s[i] == 'V')
            {
                res += V;
                prev = V;
            }
            else if (s[i] == 'X')
            {
                if (prev == L || prev == C) 
                {
                    res -= X;
                }
                else
                {
                    res += X;
                }
                prev = X;
            }
            else if (s[i] == 'L')
            {
                res += L;
                prev = L;
            }
            else if (s[i] == 'C')
            {
                if (prev == D || prev == M) 
                {
                    res -= C;
                }
                else
                {
                    res += C;
                }
                prev = C;
            }
            else if (s[i] == 'D')
            {
                res += D;
                prev = D;
            }
            else if (s[i] == 'M')
            {
                res += M;
                prev = M;
            }
        }
        
        return res;
    }
}