using System;
using System.Collections.Generic;
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

namespace WorkoutAndTrackCalories
{
    /// <summary>
    /// Interaction logic for calories.xaml
    /// </summary>
    public partial class calories : Page
    {
        public calories()
        {
            InitializeComponent();
            for (int i = 0; i < Alimente.Count; i++)
                Alimente[i].Acg = 0;
            add_Aliment.POwner = this;
        }

        public static List<Aliment> Alimente = new List<Aliment>()
        {
            new Aliment("lapte",5,5,3.75f,3.75f,2.5f,67),
            new Aliment("banana",22.8f,12.2f,1.1f,0.3f,0.11f,89),
            new Aliment("fulgi de ovaz",59,0.7f,14,7,1.3f,375),
            new Aliment("ciocolata 85",18,14,8.5f,52,34,600),
            new Aliment("paine",50.1f,0.35f,10.93f,2.03f,0.51f,267.8f),
            new Aliment("ou",1.1f,1.1f,13,11,3.3f,155),
            new Aliment("iaurt",3.6f,3.6f,4.3f,5.3f,3.4f,79),
            new Aliment("piept cocos",0,0,31,3.6f,1,164),
            new Aliment("in",29,1.5f,18.3f,42.16f,3.6f,534),
            new Aliment("ciocolata 99",7.6f,1.7f,11,60,38,646),
            new Aliment("morcov",9.58f,4.74f,0.93f,0.24f,0.04f,41),
            new Aliment("mar",14,10,0.3f,0.2f,0,52),
            new Aliment("branza",4.5f,4.5f,13,9,6,156),
            new Aliment("gogoasa",52.5f,0,8.2f,13.8f,0,379),
            new Aliment("chiftele",20,0.9f,1.7f,0.1f,0,86),
            new Aliment("cartofi",21.8f,1.53f,2.1f,0.15f,0.02f,94),
            new Aliment("carnat",1.7f,0,15,26,11,301),
        };
        public static float numar, cantitate, G = 0, Z = 0, P = 0, L = 0, ACG = 0, Q = 0, CAL = 0;
        private void submit_Click(object sender, RoutedEventArgs e)
        {
            CaloriesOutput.Text +="*Total:\n"
               + $"Cantitate: {Q} g\n"
             + $"Calorii: {CAL} \n" 
             + $"Glucide: {G} \n"
            + $"Din care zaharuri: {Z} \n"
            + $"Proteine: {P}\n"
            + $"Lipide: {L} \n"
            + $"Din care saturate: {ACG}";
        }
        add_aliment add_Aliment = new add_aliment();
        private void add_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            add_Aliment.ShowDialog();
        }

        
    }
}
