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
using FirstMVVM.ViewModels;


namespace FirstMVVM.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //InitializeComponent();
            //DataContext = MainViewModel.Instance;

            //FN.Text = MainViewModel.Instance.ImportantPerson.FirstName;
            //LN.Text = MainViewModel.Instance.ImportantPerson.LastName;
            //FLN.Text = MainViewModel.Instance.ImportantPerson.FullName;
        }

        //private void Gem_Click(object sender, RoutedEventArgs e)
        //{
        //    MainViewModel.Instance.ImportantPerson.FirstName = FN.Text;
        //    MainViewModel.Instance.ImportantPerson.LastName = LN.Text; 

        //    //FN.Text = MainViewModel.Instance.ImportantPerson.FirstName;
        //    //LN.Text = MainViewModel.Instance.ImportantPerson.LastName;
        //    FLN.Text = MainViewModel.Instance.ImportantPerson.FullName;

        //}
    }
}
