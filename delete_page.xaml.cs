﻿using System;
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
    /// Логика взаимодействия для delete_page.xaml
    /// </summary>
    public partial class delete_page : UserControl
    {
        public delete_page()
        {
            InitializeComponent();
        }

        private void cb_cortana_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_microsoft_365_office_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_microsoft_teams_Checked(object sender, RoutedEventArgs e)
        {

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

        private void delete_btn_Click(object sender, RoutedEventArgs e)
        {
            var list = (this.Content as Panel).Children.OfType<CheckBox>().Where(x => x.IsChecked == true);
        }
    }
}
