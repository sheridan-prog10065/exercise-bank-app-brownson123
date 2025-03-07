namespace BankApp;

public class SavingsAccount : Account
{
    public SavingsAccount(int accountNumber, string accountHolderName) : base(accountNumber, accountHolderName)
    {
    }
    
    public override double AnnualIntrestRate
    {
        get
        {
            return _annualIntrRate;
        }
        set
        {
            _annualIntrRate = value;
        }
    }
}