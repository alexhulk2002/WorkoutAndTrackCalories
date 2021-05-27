using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace WorkoutAndTrackCalories
{
    public static class reading_writing
    {
        public static void citire()
        {
            calories.Alimente.Clear();
            if (!File.Exists("alimente.bin"))
            {
                calories.Alimente.AddRange(calories.AlimenteDefault);
                scrie();
                return;
            }
            using (BinaryReader br = new BinaryReader(File.OpenRead("alimente.bin")))
            {
                while (br.BaseStream.Position!=br.BaseStream.Length)
                {
                    var nume = br.ReadString();
                    var glucide = br.ReadSingle();
                    var zaharuri = br.ReadSingle();
                    var lipide = br.ReadSingle();
                    var proteine = br.ReadSingle();
                    var acg = br.ReadSingle();
                    var cal = br.ReadSingle();
                    var aliment = new Aliment(nume, glucide, zaharuri, lipide, proteine, acg, cal);
                    calories.Alimente.Add(aliment);
                }
            }
        }


        public static void scrie()
        {
            using (BinaryWriter bw = new BinaryWriter(File.Create("alimente.bin")))
            {
               foreach(var aliment in calories.Alimente)
                {
                    bw.Write(aliment.Name);
                    bw.Write(aliment.Glucide);
                    bw.Write(aliment.Zaharuri);
                    bw.Write(aliment.Lipide);
                    bw.Write(aliment.Proteine);
                    bw.Write(aliment.Acg);
                    bw.Write(aliment.Cal);

                }
            }
        }
    }
}
