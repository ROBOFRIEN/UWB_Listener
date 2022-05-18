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

namespace wpf_UWB_GUI
{
    /// <summary>
    /// UC_.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class UC_Menu_gateway : UserControl
    {

        //MenuGateway -> MainWindow
        public delegate void MainGetMenuGatewayDataEventHandler(int btnNumber);
        public event MainGetMenuGatewayDataEventHandler setGatewayMenuButton;

        public UC_Menu_gateway()
        {
            InitializeComponent();
        }

        private void btn_menu_communication_Click(object sender, RoutedEventArgs e)
        {
            Color mColor = (Color)ColorConverter.ConvertFromString("#FF161618");
            btn_menu_communication.Background = new SolidColorBrush(mColor);
            btn_menu_filter.Background = new SolidColorBrush(mColor);
            btn_menu_device.Background = new SolidColorBrush(mColor);
            btn_menu_map.Background = new SolidColorBrush(mColor);
            btn_menu_setting.Background = new SolidColorBrush(mColor);
            btn_menu_info.Background = new SolidColorBrush(mColor);

            mColor = (Color)ColorConverter.ConvertFromString("#FF25262A");
            btn_menu_communication.Background = new SolidColorBrush(mColor);

            setGatewayMenuButton(1);
        }

        private void btn_menu_filter_Click(object sender, RoutedEventArgs e)
        {
            Color mColor = (Color)ColorConverter.ConvertFromString("#FF161618");
            btn_menu_communication.Background = new SolidColorBrush(mColor);
            btn_menu_filter.Background = new SolidColorBrush(mColor);
            btn_menu_device.Background = new SolidColorBrush(mColor);
            btn_menu_map.Background = new SolidColorBrush(mColor);
            btn_menu_setting.Background = new SolidColorBrush(mColor);
            btn_menu_info.Background = new SolidColorBrush(mColor);

            mColor = (Color)ColorConverter.ConvertFromString("#FF25262A");
            btn_menu_filter.Background = new SolidColorBrush(mColor);

            setGatewayMenuButton(2);
        }

        private void btn_menu_device_Click(object sender, RoutedEventArgs e)
        {
            Color mColor = (Color)ColorConverter.ConvertFromString("#FF161618");
            btn_menu_communication.Background = new SolidColorBrush(mColor);
            btn_menu_filter.Background = new SolidColorBrush(mColor);
            btn_menu_device.Background = new SolidColorBrush(mColor);
            btn_menu_map.Background = new SolidColorBrush(mColor);
            btn_menu_setting.Background = new SolidColorBrush(mColor);
            btn_menu_info.Background = new SolidColorBrush(mColor);

            mColor = (Color)ColorConverter.ConvertFromString("#FF25262A");
            btn_menu_device.Background = new SolidColorBrush(mColor);

            setGatewayMenuButton(3);
        }

        private void btn_menu_map_Click(object sender, RoutedEventArgs e)
        {
            Color mColor = (Color)ColorConverter.ConvertFromString("#FF161618");
            btn_menu_communication.Background = new SolidColorBrush(mColor);
            btn_menu_filter.Background = new SolidColorBrush(mColor);
            btn_menu_device.Background = new SolidColorBrush(mColor);
            btn_menu_map.Background = new SolidColorBrush(mColor);
            btn_menu_setting.Background = new SolidColorBrush(mColor);
            btn_menu_info.Background = new SolidColorBrush(mColor);

            mColor = (Color)ColorConverter.ConvertFromString("#FF25262A");
            btn_menu_map.Background = new SolidColorBrush(mColor);

            setGatewayMenuButton(4);
        }

        private void btn_menu_setting_Click(object sender, RoutedEventArgs e)
        {
            Color mColor = (Color)ColorConverter.ConvertFromString("#FF161618");
            btn_menu_communication.Background = new SolidColorBrush(mColor);
            btn_menu_filter.Background = new SolidColorBrush(mColor);
            btn_menu_device.Background = new SolidColorBrush(mColor);
            btn_menu_map.Background = new SolidColorBrush(mColor);
            btn_menu_setting.Background = new SolidColorBrush(mColor);
            btn_menu_info.Background = new SolidColorBrush(mColor);

            mColor = (Color)ColorConverter.ConvertFromString("#FF25262A");
            btn_menu_setting.Background = new SolidColorBrush(mColor);

            setGatewayMenuButton(5);
        }

        private void btn_menu_info_Click(object sender, RoutedEventArgs e)
        {
            Color mColor = (Color)ColorConverter.ConvertFromString("#FF161618");
            btn_menu_communication.Background = new SolidColorBrush(mColor);
            btn_menu_filter.Background = new SolidColorBrush(mColor);
            btn_menu_device.Background = new SolidColorBrush(mColor);
            btn_menu_map.Background = new SolidColorBrush(mColor);
            btn_menu_setting.Background = new SolidColorBrush(mColor);
            btn_menu_info.Background = new SolidColorBrush(mColor);

            mColor = (Color)ColorConverter.ConvertFromString("#FF25262A");
            btn_menu_info.Background = new SolidColorBrush(mColor);

            setGatewayMenuButton(6);
        }
    }
}
