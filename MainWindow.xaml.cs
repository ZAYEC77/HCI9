using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace HCI9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Timer timer = new Timer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += timer_Tick;
            timer.Interval = 10;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            System.Windows.Shapes.Rectangle rect = new System.Windows.Shapes.Rectangle() { Height = 70 };
            GradientBrush brush;
            Random rand = new Random();
            byte r = Convert.ToByte(rand.Next(255));
            byte b = Convert.ToByte(rand.Next(255));
            byte g = Convert.ToByte(rand.Next(255));
            GradientStopCollection points = new GradientStopCollection(3);
            points.Add(new GradientStop(Color.FromArgb(255, 255, 255, 255), 0.0));

             r = Convert.ToByte(rand.Next(255));
             b = Convert.ToByte(rand.Next(255));
             g = Convert.ToByte(rand.Next(255));
            points.Add(new GradientStop(Color.FromArgb(255, r, g, b), 0.5));

             r = Convert.ToByte(rand.Next(255));
             b = Convert.ToByte(rand.Next(255));
             g = Convert.ToByte(rand.Next(255));
            points.Add(new GradientStop(Color.FromArgb(255, 0, 0, 0), 1.0));
            brush = new LinearGradientBrush(points);
            rect.Fill = brush;
            this.stackPanel.Effect = rect.Effect = new System.Windows.Media.Effects.BlurEffect() { Radius = 20 }; 
            rect.Effect = new System.Windows.Media.Effects.BlurEffect() { Radius = 20};
            this.stackPanel.Children.Add(rect);
            if (this.stackPanel.Children.Count*70 > this.Height-50 )
            {
                this.stackPanel.Children.RemoveAt(0);
                timer.Interval = 290;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void mainForm_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void stackPanel_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {

        }

        private void Rectangle_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }


        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Window2 w = new Window2();
            w.ShowDialog();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.ShowDialog();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            Window3 w = new Window3();
            w.ShowDialog();
        }
    }
}
