using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Model
{
    public class AccountModel
    {

        public class Account : INotifyPropertyChanged
        {
            private string accountNumber;
            private string accountName;

            public string AccountNumber
            {
                get
                {
                    return accountNumber;
                }

                set
                {
                    if (accountNumber != value)
                    {
                        accountNumber = value;
                        OnPropertyChanged("AccountNumber");
                    }
                }
            }

            public string AccountName
            {
                get { return accountName; }

                set
                {
                    if (accountName != value)
                    {
                        accountName = value;
                        OnPropertyChanged("AccountName");
                    }
                }
            }


            public event PropertyChangedEventHandler PropertyChanged;

            private void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
