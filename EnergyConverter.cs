using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngergyLib
{
   public static class EnergyConverter
    {
        public static double ToJoule(double calorie)
        {
            double joule = calorie * 4.2;

            return Math.Round(joule);
        }

        public static double ToCalorie(double joule)
        {
            double calorie = joule / 4.2;

            return Math.Round(calorie);
        }
    }
}
