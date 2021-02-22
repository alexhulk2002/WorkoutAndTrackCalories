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
            PageViewer.Navigate(MainPage); 
        }        

        public static MainPage MainPage = new MainPage();
        public static calories CaloriesPage = new calories();
        public static Page1 Page1 = new Page1();

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
