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
using System.Windows.Shapes;

namespace WorkoutAndTrackCalories
{
    /// <summary>
    /// Interaction logic for BMI.xaml
    /// </summary>
    public partial class BMI : Window
    {
        public BMI()
        {
            InitializeComponent();
        }
       
        private void calculeaza_Click(object sender, RoutedEventArgs e)
        {
            double h = int.Parse(inaltime.Text);
            double g = int.Parse(greutate.Text);
            double a = g * 10000 / h / h;
            if(a<18.5)
                MessageBox.Show((a).ToString()+"\n"+ "subponderal");
            else if(a<25)
                MessageBox.Show((a).ToString() + "\n" + "greutate normala");
            else if(a<30)
                MessageBox.Show((a).ToString() + "\n" + "supraponderal");
            else if(a<40)
                MessageBox.Show((a).ToString() + "\n" + "obezitate de gradul 1");
            else
                MessageBox.Show((a).ToString() + "\n" + "obezitate de gradul 2");
        }
    }
}
