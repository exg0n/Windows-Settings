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

namespace Windows_Settings
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void btn_delete_click(object sender, RoutedEventArgs e)
        {
            main_frame.Content = new delete_page();
        }
        private void btn_recovery_click(object sender, RoutedEventArgs e)
        {

        }
        private void btn_online_install_click(object sender, RoutedEventArgs e)
        {

        }
        private void btn_office_install_click(object sender, RoutedEventArgs e)
        {

        }
        private void btn_adobe_install_click(object sender, RoutedEventArgs e)
        {

        }
        private void btn_about_program_click(object sender, RoutedEventArgs e)
        {

        }

        private void empty(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    btn_delete.Visibility = Visibility.Collapsed;
        //}
    }
}