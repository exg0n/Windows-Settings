using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для recovery_page.xaml
    /// </summary>
    public partial class recovery_page : UserControl
    {
        // чекбокс "выделить все"
        private CheckBox SelectAllCB;

        public recovery_page()
        {
            InitializeComponent();
            SelectAllCB = (CheckBox)this.FindName("select_all");
        }
        private IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }
        private StringBuilder change_symbol(string input_name)
        {
            StringBuilder str = new StringBuilder(input_name);

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == '_')
                    str[i] = '.';
            }
            return str;
        }
        private bool is_all_checked()
        {
            int counter = 0;
            List<CheckBox> list = FindVisualChildren<CheckBox>(this).ToList();

            foreach (var checkBox in list)
                if (checkBox.IsChecked == true)
                    counter++;

            if (counter == list.Count() - 1)
                return true;
            else
                return false;
        }
        private void ReturnCBFalse(object sender, RoutedEventArgs e)
        {
            SelectAllCB.IsChecked = false;
        }

        private void ReturnCBTrue(object sender, RoutedEventArgs e)
        {
            if (is_all_checked() == true)
                SelectAllCB.IsChecked = true;
        }
        private void SelectAllClick(object sender, RoutedEventArgs e)
        {
            CheckBox foundCheckBox = (CheckBox)this.FindName("select_all");

            if (foundCheckBox.IsChecked == true)
            {
                List<CheckBox> list = FindVisualChildren<CheckBox>(this)
                         .ToList();

                foreach (var checkBox in list)
                    checkBox.IsChecked = true;
            }
            else if (foundCheckBox.IsChecked == false)
            {
                List<CheckBox> list = FindVisualChildren<CheckBox>(this)
                         .ToList();

                foreach (var checkBox in list)
                    checkBox.IsChecked = false;
            }
        }
        private void recovery_btn_Click(object sender, RoutedEventArgs e)
        {
            List<CheckBox> list = FindVisualChildren<CheckBox>(this)
                        .Where(cb => cb.IsChecked == true)
                        .ToList(); ProcessStartInfo start_info = new ProcessStartInfo("powershell.exe");
            //start_info.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(start_info);

            foreach (var checkBox in list)
            {
                string command = "Add-AppxPackage -register 'C:\\Program Files\\WindowsApps\\*" + change_symbol(checkBox.Name) + "*\\AppxManifest.xml' -DisableDevelopmentMode";
                start_info.Arguments = command;
                Process.Start(start_info);
            } 
        }
    }
}
