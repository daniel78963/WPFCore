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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp.Controls;
using WpfApp.Data.Entities;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            List<Person> list = new List<Person>();
            list.Add(new Person() { Id = 1, Name = "Charles", Age = 40, Job = "Author" });
            list.Add(new Person() { Id = 2, Name = "John", Age = 40, Job = "Officer" });
            list.Add(new Person() { Id = 3, Name = "Bernard", Age = 40, Job = "Engineer" });
            grdPersons.ItemsSource = list;
        }

        private void btnGrid_Click(object sender, RoutedEventArgs e)
        {
            //Person person = (Person)grdPersons.SelectedItem;
            //string msg = $"Person Id={person.Id}, Name={person.Name}, Job={person.Job} ";
            //MessageBox.Show(msg);

            var list = grdPersons.SelectedItems;
            string personasSelected = string.Empty;
            foreach (var item in list)
            {
                Person person = (Person)item;
                personasSelected+= $"Person Id={person.Id}, Name={person.Name}, Job={person.Job} " + Environment.NewLine;
            }
            MessageBox.Show(personasSelected);
        }

        private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            WpfApp.ViewModel.StudentViewModel studentViewModelObject =
               new WpfApp.ViewModel.StudentViewModel();
            studentViewModelObject.LoadStudents();

            StudentViewControl.DataContext = studentViewModelObject;
        }

        private void AutoCompleteViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            WpfApp.ViewModel.AutoCompleteViewModel viewModelObject =
               new WpfApp.ViewModel.AutoCompleteViewModel();
            viewModelObject.LoadAccounts();
            autoCompleteAccounts.DataContext = viewModelObject;
        }
    }
}
