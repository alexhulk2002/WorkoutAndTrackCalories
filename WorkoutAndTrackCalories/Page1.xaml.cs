using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            functions = new Dictionary<string, Dictionary<string, Func<string>>>()
            {
                {"strength" , new Dictionary<string, Func<string>>()
                    {
                        { "pull",  strength_pull },
                        { "push", strength_push },
                        { "legs", strength_legs },
                        { "abs", strength_abs },
                        { "full body", strength_fullbody },
                    }
                },
                {"hypertrophy" , new Dictionary<string, Func<string>>()
                    {
                        { "pull",  hypertrophy_pull },
                        { "push", hypertrophy_push },
                        { "legs", hypertrophy_legs },
                        { "abs", hypretrophy_abs },
                        { "full body", hypertrophy_fullbody },
                    }
                }
            };
        }

        private void generate_Click(object sender, RoutedEventArgs e)
        {
            //show_exercices.Text=functions[param1][param2]();
            show_exercices.Text = functions[param1][param2]?.Invoke();
        }

        private void savedata_Click(object sender, RoutedEventArgs e)
        {
            int i_pushups = int.Parse(pushups.Text);
            int i_pullups = int.Parse(pullups.Text);
            int i_crunches = int.Parse(crunches.Text);
            int i_squats = int.Parse(squats.Text);
            using(BinaryWriter bw=new BinaryWriter(File.OpenWrite("data.bin")))
            {
                bw.Write(i_pushups);
                bw.Write(i_pullups);
                bw.Write(i_crunches);
                bw.Write(i_squats);
            }
        }

        private void loaddata_Click(object sender, RoutedEventArgs e)
        {
            if(!File.Exists("data.bin"))
            {
                MessageBox.Show("File not found. Please retype your data and press Save");
            }
            using(BinaryReader br=new BinaryReader(File.OpenRead("data.bin")))
            {
                int i_pushups = br.ReadInt32();
                pushups.Text = i_pushups.ToString();
                int i_pullups = br.ReadInt32();
                pullups.Text = i_pullups.ToString();
                int i_crunches = br.ReadInt32();
                crunches.Text = i_crunches.ToString();
                int i_squats = br.ReadInt32();
                squats.Text = i_squats.ToString();
            }
        }


        string strength_push()
        {
            string result = "";
            int i_pushups = int.Parse(pushups.Text);
            result += i_pushups / 2 + " archer push ups\n";
            result += i_pushups / 3 * 2 + " declie push ups\n";
            result += i_pushups / 3 * 2 + " weighted push ups\n";
            result += i_pushups / 2 + "push ups\n";
            result += i_pushups / 3 + "skull crushers\n";
            result += "1 min plank\n";
            result += " 3-5 sets 1.5-2 min rest";
            //MessageBox.Show(result);
            return result;
        }
        string strength_pull()
        {
            string result ="";
            int i_pullups = int.Parse(pullups.Text);


            return result;
        }
        string strength_legs()
        {
            string result = "";
            return result;
        }
        string strength_abs()
        {
            string result = "";
            return result;
        }
        string strength_fullbody()
        {
            string result = "";
            return result;
        }
        string hypertrophy_push()
        {
            string result = "";
            return result;
        }
        string hypertrophy_pull()
        {
            string result = "";
            return result;
        }
        string hypertrophy_legs()
        {
            string result = "";
            return result;
        }
        string hypretrophy_abs()
        {
            string result = "";
            return result;
        }
        string hypertrophy_fullbody()
        {
            string result = "";
            return result;
        }

        Dictionary<string, Dictionary<string, Func<string>>> functions;

        string param1="strength";
        private void RadioButton2_Checked(object sender, RoutedEventArgs e)
        {
            param1 = (sender as RadioButton).Content as string;            
        }

        string param2="push";
        private void RadioButton4_Checked(object sender, RoutedEventArgs e)
        {
            param2 = (sender as RadioButton).Content as string;            
        }

        private void NumericForce_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Input = sender as TextBox;
            if(Input.Text=="")
            {
                Input.Text = "0";
                return;
            }
            if (int.TryParse(Input.Text, out int val))
            {
                if (val < 0) val = 0;
                else if (val > 1000) val = 1000;
                Input.Text = val.ToString();
                if (val < 10) Input.CaretIndex = 1;
            }
            else
            {
                int i = Input.CaretIndex;
                Input.CaretIndex = Math.Min(i - 1, Input.Text.Length);                
            }
        }
    }
}
