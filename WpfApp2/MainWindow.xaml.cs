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
using System.Windows.Threading;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Car> GetCars()
        {
            return new List<Car>
            {
                new Car
                {
                    Model="GL-500",
                     Vendor="Mercedes",
                      Year=2018
                },
                new Car
                {
                    Model="ID6",
                     Vendor="Wokswagen",
                      Year=2022
                },
                new Car
                {
                    Model="Supra",
                     Vendor="Toyota",
                      Year=2021
                },
                 new Car
                 {
                     Model="Cruze",
                      Vendor="Chevrolet",
                       Year=2010
                 }
            };

        }
        public MainWindow()
        {
            InitializeComponent();

            //listbox.ItemsSource = GetCars();
            //timer.Interval = TimeSpan.FromSeconds(1);
            //timer.Tick += Timer_Tick;

           // myDataGrid.ItemsSource = GetCars();
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // var item=listbox.SelectedItem as Car;
            //MessageBox.Show(item.ToString());
        }

        private void cmbbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var stackpanel=btn.Parent as StackPanel;
            var text = stackpanel.Children[1] as TextBlock;
            MessageBox.Show(text.Text);
        }

        //private void Timer_Tick(object? sender, EventArgs e)
        //{
        //    //if (progressBar.Value < progressBar.Maximum)
        //    //    progressBar.Value += 5;
        //    if (progressBar.Value == progressBar.Maximum)
        //    {
        //        timer.Stop();
        //        MessageBox.Show("Completed");
        //    }
        //}

        //private void downBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    if (progressBar.Value > progressBar.Minimum)
        //        progressBar.Value -= 5;
        //}

        //private void upBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    if (progressBar.Value < progressBar.Maximum)
        //        progressBar.Value += 5;
        //    if (progressBar.Value == progressBar.Maximum)
        //        MessageBox.Show("Completed");
        //}
        //DispatcherTimer timer = new DispatcherTimer();
        //private void startBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    timer.Start();
        //}

        //private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    startBtn.Content = int.Parse(Math.Floor(mySlider.Value).ToString());
        //}
    }
}
