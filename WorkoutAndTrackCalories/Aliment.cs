using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutAndTrackCalories
{
    public class Aliment
    {
        public Aliment(string n,float g,float z,float l,float p,float acg,float cal)
        {
            Name = n;
            Glucide = g;
            Zaharuri = z;
            Lipide = l;
            Proteine = p;
            Acg = acg;
            Cal = cal;

        }        public string Name { get; set; }
        public float Glucide, Zaharuri, Lipide, Proteine, Acg, Cal;
    }
}
