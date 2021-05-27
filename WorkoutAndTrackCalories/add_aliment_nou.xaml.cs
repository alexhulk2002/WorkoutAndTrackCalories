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
using static WorkoutAndTrackCalories.DatabaseTools;
namespace WorkoutAndTrackCalories
{
    /// <summary>
    /// Interaction logic for add_aliment_nou.xaml
    /// </summary>
    public partial class add_aliment_nou : Page
    {
        public add_aliment_nou()
        {
            InitializeComponent();
        }


        private void adauga_Click(object sender, RoutedEventArgs e)
        {
            var name = nume_aliment.Text;
            var Glucide = float.Parse(glucide.Text);
            var Lipide = float.Parse(lipide.Text);
            var Zaharuri = float.Parse(zaharuri.Text);
            var Proteine = float.Parse(proteine.Text);
            var Acg = float.Parse(acg.Text);
            var Cal = float.Parse(cal.Text);

            var aliment = new Aliment(name, Glucide, Zaharuri, Lipide, Proteine, Acg, Cal);
            calories.Alimente.Add(aliment);
            reading_writing.scrie();
        }
    }
}
