namespace BankApp;

public class Account
{
    #region Fields
    protected string _accountHolderName;
    protected int _accountNumber;
    protected double _annualIntrRate;
    protected decimal _balance;
    #endregion

    #region constructors
    public Account(int accountNumber, string accountHolderName)
    {
        _accountNumber = accountNumber;
        _accountHolderName = accountHolderName;
    }
    #endregion

    #region Properties
    public string AccountHolderName
    {
        get
        {
            return _accountHolderName;
        }
    }

    public int AccountNumber
    {
        get
        {
            return _accountNumber;
        }
    }

    public virtual double AnnualIntrestRate
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

    public decimal Balance
    {
        get
        {
            return _balance;
        }
    }
    #endregion
}