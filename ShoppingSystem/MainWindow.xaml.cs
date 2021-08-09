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

namespace ShoppingSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AddGood newWindow = new AddGood();
            newWindow.Closed += (s, args) => this.Show();

            newWindow.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            UpDateGood newWindow = new UpDateGood();
            newWindow.Closed += (s, args) => this.Show();
            newWindow.Show();
                
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            NewShop newWindow = new NewShop();
            newWindow.Closed += (s, args) => this.Show();
            newWindow.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PreviousShop newWindow = new PreviousShop();
            newWindow.Closed += (s, args) => this.Show();
            newWindow.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Hide();
            StatisticsAndRecommendations newWindow = new StatisticsAndRecommendations();
            newWindow.Closed += (s, args) => this.Show();
            newWindow.Show();
        }
    }
}
