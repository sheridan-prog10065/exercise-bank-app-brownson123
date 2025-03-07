using System.Collections.ObjectModel;

namespace BankApp;

public class Bank
{
    private ObservableCollection<Account> _accountList = new ObservableCollection<Account>();

    public Bank()
    {
    }
    
    #region Properties

    public ObservableCollection<Account> AccountList
    {
        get
        {
            return _accountList;
        }
    }
    #endregion
}