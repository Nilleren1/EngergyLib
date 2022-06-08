using System;

namespace EngergyLib
{
    public class EnergyData
    {
       

        public int Id { get; set; }
        public string EnergyMetric { get; set; }
        public double Value{ get; set; }

        public EnergyData()
        {
            
        }

        public EnergyData(string energyMetric, double value)
        {
            EnergyMetric = energyMetric;
            Value = value;
        }

    }
}
