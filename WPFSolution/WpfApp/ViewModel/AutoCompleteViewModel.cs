using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static WpfApp.Model.AccountModel;
using static WpfApp.Model.StudentModel;

namespace WpfApp.ViewModel
{
    public class AutoCompleteViewModel : INotifyPropertyChanged
    {
        public AutoCompleteViewModel()
        {

        }

        private string valueText = "";

        public string ValueText
        {
            get
            {
                return valueText;
            }

            set
            {
                if (value != valueText)
                {
                    valueText = value;
                    OnPropertyChange();
                }
            }
        }

        private void OnPropertyChange([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            if (ValueText != null
                && ValueText.Length >= 3)
            {
                LoadAccounts();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //public ObservableCollection<Account> Accounts
        //{
        //    get;
        //    set;
        //}
        private ObservableCollection<Account> accounts;
        public ObservableCollection<Account> Accounts
        {
            get
            {
                return accounts;
            }

            set
            {
                accounts = value;
            }
        }

        public void LoadAccounts()
        {
            ObservableCollection<Account> accounts = new ObservableCollection<Account>();
            accounts.Add(new Account { AccountNumber = "123", AccountName = "Allain Account" });
            accounts.Add(new Account { AccountNumber = "1234", AccountName = "Allain Account" });
            accounts.Add(new Account { AccountNumber = "12345", AccountName = "Allain Account" });
            Accounts = accounts;
        }
    }
}
