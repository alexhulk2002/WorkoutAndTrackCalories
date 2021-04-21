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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Workout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(MainWindow.Page1);
            //PageViewer.Navigate(page1);
            //PageViewer.Visibility = Visibility.Visible;

            //BackButton.Visibility = Visibility.Visible;
        }

        private void Calories_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(MainWindow.CaloriesPage);
            //PageViewer.Navigate(calories);
            //PageViewer.Visibility = Visibility.Visible;
            //BackButton.Visibility = Visibility.Visible;
        }
        //BMI bmi = new BMI();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new BMI().ShowDialog();
        }

        private void exercice_Click(object sender, RoutedEventArgs e)
        {
            new exercices().ShowDialog();
        }
    }
}
