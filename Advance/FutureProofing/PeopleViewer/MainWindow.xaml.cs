using Common;
using People.Library;
using System.Collections.Generic;
using System.Windows;

namespace PeopleViewer
{
    public partial class MainWindow : Window
    {
        PersonRepository repository = new PersonRepository();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConcreteFetchButton_Click(object sender, RoutedEventArgs e)
        {
            /*Person[] people = repository.GetPeople();
            foreach(Person p in people)
            {
                PersonListBox.Items.Add(p)
            }*/

            List<Person> people = repository.GetPeople();
            PersonListBox.ItemsSource = people;                 // here no need of foreach loop.

        }

        private void AbstractFetchButton_Click(object sender, RoutedEventArgs e)
        {

            IEnumerable<Person> people = repository.GetPeople();    // whatever type return this function, IEnumerable assign that type.
            PersonListBox.ItemsSource = people;                 // here no need of foreach loop.
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            PersonListBox.ItemsSource = null ;
        }
    }
}
