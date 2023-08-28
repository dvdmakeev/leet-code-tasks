/*
    withdraw(int amount)     -> int[]
    deposit (int[] banknotes) -> void

    int[] banknotes
    deposit: суммируем два массива
    
    withdraw:
        res = [n]
        for i = banknotes[n, 0]
            while b[i] > 0 && val[i] <= amount
                amount -= val[i]
                ++res[i]
                --b[i]
    O(amount)

    O(banknotesCount.Length) = O(1)
    // amount
    // n k

    // needToWithdraw = amount / k

    // needToWithdraw > n -> withdraw n     -> next banknote
    // needToWithdraw < n -> needToWithdraw -> next banknote
    // amount -= withdrawn * k

    withdraw:
        res = [n]
        for i = banknotes[n, 0]
            

*/

public class ATM 
{
    private const int DenominationCount = 5;

    private long[] banknotes;
    private long[] banknoteValues;

    public ATM() 
    {
        banknotes = new long[DenominationCount];
        banknoteValues = new long[DenominationCount] { 20, 50, 100, 200, 500 };
    }
    
    public void Deposit(int[] banknotesCount) 
    {
        for (int i = 0; i < banknotesCount.Length; ++i)
        {
            banknotes[i] += banknotesCount[i];
        }
    }
    
    public int[] Withdraw(int amount) 
    {
        long[] result = new long[DenominationCount];
        long currentAmount = amount;

        for (int i = banknotes.Length - 1; i >= 0; --i)
        {
            if (currentAmount == 0)
            {
                break;
            }

            long needToWithdrawBanknotes = currentAmount / banknoteValues[i];
            long withdrawnBanknotes = Math.Min(needToWithdrawBanknotes, banknotes[i]);

            currentAmount -= withdrawnBanknotes * banknoteValues[i];

            result[i] += withdrawnBanknotes;
        }

        if (currentAmount > 0)
        {
            return new int[] { -1 };
        }

        for (int i = 0; i < banknotes.Length; ++i)
        {
            banknotes[i] -= result[i];
        }

        return result.Select(a => (int)a).ToArray();
    }
}

/**
 * Your ATM object will be instantiated and called as such:
 * ATM obj = new ATM();
 * obj.Deposit(banknotesCount);
 * int[] param_2 = obj.Withdraw(amount);
 */
