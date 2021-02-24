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
    /// Interaction logic for add_aliment.xaml
    /// </summary>
    public partial class add_aliment : Window
    {
        public add_aliment()
        {
            InitializeComponent();
            calories.Alimente=calories.Alimente.OrderBy(o => o.Name).ToList();
            AlimentsList.ItemsSource = calories.Alimente;
        }

        public calories POwner;

        private void adauga_Click(object sender, RoutedEventArgs e)
        {
            POwner.CaloriesInput.Text += $"" +
                $"{calories.Alimente[int.Parse(numar_aliment.Text)-1].Name}\n {cantitate_aliment.Text} g \n";
            //calories.numar = int.Parse(numar_aliment.Text)-1;
            calories.cantitate = int.Parse(cantitate_aliment.Text);
            POwner.CaloriesOutput.Text += $"" +
                $"*" + $"{calories.Alimente[int.Parse(numar_aliment.Text)-1].Name}:\n"
                + $"Glucide:" + $"{calories.Alimente[int.Parse(numar_aliment.Text)-1].Glucide / 100 * calories.cantitate}\n"
                + $"Zaharuri: " + $"{calories.Alimente[int.Parse(numar_aliment.Text)-1].Zaharuri / 100 * calories.cantitate}\n"
                + $"Lipide: " + $"{calories.Alimente[int.Parse(numar_aliment.Text)-1].Lipide / 100 * calories.cantitate}\n"
                + $"Proteine: " + $"{calories.Alimente[int.Parse(numar_aliment.Text)-1].Proteine / 100 * calories.cantitate}\n"
                + $"Acg: " + $"{calories.Alimente[int.Parse(numar_aliment.Text)-1].Acg / 100 * calories.cantitate}\n"
                + $"Cal: " + $"{calories.Alimente[int.Parse(numar_aliment.Text)-1].Cal / 100 * calories.cantitate}\n \n";

            calories.G += calories.Alimente[int.Parse(numar_aliment.Text)-1].Glucide / 100 * calories.cantitate;
            calories.Z += calories.Alimente[int.Parse(numar_aliment.Text)-1].Zaharuri / 100 * calories.cantitate;
            calories.L += calories.Alimente[int.Parse(numar_aliment.Text)-1].Lipide / 100 * calories.cantitate;
            calories.P += calories.Alimente[int.Parse(numar_aliment.Text)-1].Proteine / 100 * calories.cantitate;
            calories.ACG += calories.Alimente[int.Parse(numar_aliment.Text)-1].Acg / 100 * calories.cantitate;
            calories.CAL += calories.Alimente[int.Parse(numar_aliment.Text)-1].Cal / 100 * calories.cantitate;
            calories.Q += float.Parse(cantitate_aliment.Text);
        }
    }
}
