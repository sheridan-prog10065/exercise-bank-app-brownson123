namespace BankApp;

public class CheckingAccount : Account
{
    public CheckingAccount(int accountNumber, string accountHolderName) : base(accountNumber, accountHolderName)
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