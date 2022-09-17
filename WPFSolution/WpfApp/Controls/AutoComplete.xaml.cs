using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static WpfApp.Model.AccountModel;

namespace WpfApp.Controls
{
    /// <summary>
    /// Interaction logic for AutoComplete.xaml
    /// </summary>
    public partial class AutoComplete : UserControl
    {
        public AutoComplete()
        {
            InitializeComponent();
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
                valueText = value;
            }
        }

        public ObservableCollection<string> Items
        {
            get;
            set;
        }

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

        private List<string> autoSuggestionList = new List<string>();

        /// <summary>  
        /// Gets or sets Auto suggestion list property.  
        /// </summary>  
        public List<string> AutoSuggestionList
        {
            get { return this.autoSuggestionList; }
            set { this.autoSuggestionList = value; }
        }

        private ObservableCollection<string> autoSuggestionListGen = new ObservableCollection<string>();

        /// <summary>  
        /// Gets or sets Auto suggestion list property.  
        /// </summary>  
        public ObservableCollection<string> AutoSuggestionListGen
        {
            get { return this.autoSuggestionListGen; }
            set { this.autoSuggestionListGen = value; }
        }

        private void LoadCollection<T>(ObservableCollection<T> observableCollection)
        {
        }

        /// <summary>  
        ///  Auto Text Box text changed method.  
        /// </summary>  
        /// <param name="sender">Sender parameter</param>  
        /// <param name="e">Event parameter</param>  
        private void AutoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if (this.Filter)
            //{
            //    AutoSuggestionFilter();
            //    return;
            //}

            //e.Handled = true;
            //if (AutoSuggestionTextChanged != null)
            //    AutoSuggestionTextChanged(this, EventArgs.Empty);


            try
            {
                //// Verification.  
                //if (string.IsNullOrEmpty(this.autoTextBox.Text))
                //{
                //    // Disable.  
                //    this.CloseAutoSuggestionBox();

                //    // Info.  
                //    return;
                //}

                //// Enable.  
                //this.OpenAutoSuggestionBox();

                // Settings.  
                this.autoList.ItemsSource = this.AutoSuggestionList.Where(p => p.ToLower().Contains(this.autoTextBox.Text.ToLower())).ToList();
                this.autoListOne.ItemsSource = this.AutoSuggestionList.Where(p => p.ToLower().Contains(this.autoTextBox.Text.ToLower())).ToList();
            }
            catch (Exception ex)
            {
                // Info.  
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Console.Write(ex);
            }
        }
    }
}
