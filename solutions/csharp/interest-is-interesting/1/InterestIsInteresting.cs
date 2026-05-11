static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        return balance switch
        {
                < 0 => 3.213f,
                < 1000 => 0.5f,
                < 5000 => 1.621f,
                >= 5000 => 2.475f
        };
    }

    public static decimal Interest(decimal balance)
    {
        return (decimal)InterestRate(balance) * balance / 100;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        if(targetBalance <= balance)
            return 0;
        int years = 0;
        do
        {
            balance = balance + Interest(balance);
            years++;
        }while(targetBalance > balance);
        
        return years;
    }
}
