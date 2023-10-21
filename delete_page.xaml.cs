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
using System.Diagnostics;

namespace Windows_Settings
{
    /// <summary>
    /// Логика взаимодействия для delete_page.xaml
    /// </summary>
    public partial class delete_page : UserControl
    {
        public delete_page()
        {
            InitializeComponent();
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

        private void ReturFalseCheckBox()
        {
            CheckBox foundCheckBox = (CheckBox)this.FindName("select_all");
            foundCheckBox.IsChecked = false;
        }

        private void ReturTrueCheckBox()
        {
            if (is_all_checked() == true)
            {
                CheckBox foundCheckBox = (CheckBox)this.FindName("select_all");
                foundCheckBox.IsChecked = true;
            }
        }

        private void cb_cortana_Checked(object sender, RoutedEventArgs e)
        {
            if (is_all_checked() == true)
            {
                CheckBox foundCheckBox = (CheckBox)this.FindName("select_all");
                foundCheckBox.IsChecked = true;
            }
        }
        private void cb_cortana_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox foundCheckBox = (CheckBox)this.FindName("select_all");
            foundCheckBox.IsChecked = false;
        }

        private void cb_microsoft_365_office_Checked(object sender, RoutedEventArgs e)
        {
            if (is_all_checked() == true)
            {
                CheckBox foundCheckBox = (CheckBox)this.FindName("select_all");
                foundCheckBox.IsChecked = true;
            }
        }
        private void cb_microsoft_365_office_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox foundCheckBox = (CheckBox)this.FindName("select_all");
            foundCheckBox.IsChecked = false;
        }

        private void cb_microsoft_teams_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void cb_microsoft_teams_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox foundCheckBox = (CheckBox)this.FindName("select_all");
            foundCheckBox.IsChecked = false;
        }

        private void cb_microsoft_to_do_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_onedrive_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_solitaire_and_casual_games_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_xbox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_alarm_clock_and_clock_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_quick_support_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_notes_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_voice_recording_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_calendar_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_camera_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_maps_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_film_and_tv_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_media_player_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_beginning_of_work_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_news_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_weather_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_mail_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_video_editor_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_сommunication_with_the_phone_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_adviсe_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_technical_support_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_photo_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_feedback_center_Checked(object sender, RoutedEventArgs e)
        {

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

        private void SelectAllChecked(object sender, RoutedEventArgs e)
        {
            
        }

        private void SelectAllUnchecked(object sender, RoutedEventArgs e)
        {

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

        private void delete_btn_Click(object sender, RoutedEventArgs e)
        {
            // сбор всех выделенных чекбоксов в один список
            List<CheckBox> list = FindVisualChildren<CheckBox>(this)
                        .Where(cb => cb.IsChecked == true)
                        .ToList(); ProcessStartInfo start_info = new ProcessStartInfo("powershell.exe");
            //start_info.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(start_info);

            // выполнение команд для всех выбранных чекбоксов
            foreach (var checkBox in list)
            {
                string command = "Get-AppxPackage *" + change_symbol(checkBox.Name) + "* | Remove-AppxPackage";
                start_info.Arguments = command;
                Process.Start(start_info);
            }
        }
        
    }
}
