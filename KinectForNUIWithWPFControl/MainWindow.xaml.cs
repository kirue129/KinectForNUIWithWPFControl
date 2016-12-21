﻿using Microsoft.Kinect;
using Microsoft.Kinect.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;

namespace KinectForNUIWithWPFControl
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void InitializeKinectControls()
        {
            KinectRegion.SetKinectRegion(this, kinectRegion);
            this.kinectRegion.KinectSensor = KinectSensor.GetDefault();
            this.kinectRegion.KinectSensor.Open();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            button.Content = "Pressed!";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InitializeKinectControls();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (kinectRegion != null)
            {
                if (kinectRegion.KinectSensor != null)
                {
                    kinectRegion.KinectSensor.Close();
                    kinectRegion.KinectSensor = null;
                }
                kinectRegion = null;
            }
        }
    }
}
