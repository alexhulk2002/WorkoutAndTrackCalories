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

namespace WorkoutAndTrackCalories
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Page1 page1 = new Page1();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Workout_Click(object sender, RoutedEventArgs e)
        {
            Content = page1;
        }

        private void Calories_Click(object sender, RoutedEventArgs e)
        {
            //Content = calories;
        }
    }
}
