using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp.Views
{
    /// <summary>
    /// Interaction logic for BankAccount.xaml
    /// </summary>
    public partial class BankAccount : Window
    {
        public BankAccount()
        {
            InitializeComponent();

        }

        private void autoSuggestionAccount_Loaded(object sender, RoutedEventArgs e)
        {
            //this.autoSuggestionAccount.AutoSuggestionList.Clear();
            //List<string> accounts = new List<string>();
            //accounts.Add("111");
            //accounts.Add("123");
            //accounts.Add("222");
            //accounts.Add("234");
            //autoSuggestionAccount.AutoSuggestionList = accounts;
        }

        private void autoSuggestionAccount_AutoSuggestionTextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.autoSuggestionAccount.autoTextBox.Text)
                && (this.autoSuggestionAccount.autoTextBox.Text.Length > 1))
            {
                this.autoSuggestionAccount.Filter = true;
                return;
            }
            this.autoSuggestionAccount.Filter = false;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.autoSuggestionAccount.AutoSuggestionList.Clear();
            List<string> accounts = new List<string>();
            accounts.Add("111");
            accounts.Add("1111");
            accounts.Add("11111");
            accounts.Add("123");
            accounts.Add("1234");
            accounts.Add("1212");
            accounts.Add("1222");
            accounts.Add("122");
            accounts.Add("12345");
            accounts.Add("1233");
            accounts.Add("222");
            accounts.Add("234");
            autoSuggestionAccount.AutoSuggestionList = accounts;
        }
    }
}
