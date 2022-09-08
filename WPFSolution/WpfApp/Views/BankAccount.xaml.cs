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
            this.autoSuggestionAccount.AutoSuggestionList.Clear();
            List<string> accounts = new List<string>();
            accounts.Add("111");
            accounts.Add("123");
            accounts.Add("222");
            accounts.Add("234");
            autoSuggestionAccount.AutoSuggestionList = accounts;
        }
    }
}
