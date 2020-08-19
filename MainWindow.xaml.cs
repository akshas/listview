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

namespace LoginForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Person> person;
        public MainWindow()
        {
            InitializeComponent();
            person = new ObservableCollection<Person>();
            list_view.ItemsSource = person;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            person.Add(new Person(txt1.Text, txt2.Text, txt3.Text, txt4.Text, txt5.Text));
        }

        private void txt_GotFocus(object sender, RoutedEventArgs e)
        {
            

            TextBox tb = (TextBox)sender;
            tb.SelectAll(); 
        }

        private void txt_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Focus();
            tb.SelectAll();
        }
    }
}
