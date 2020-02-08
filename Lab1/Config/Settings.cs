using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Config
{
   public class Settings
    {
        private static JsonFile calcConfig = new JsonFile("Resources\\CalculationConfig.json");
        public static double Tolerance = calcConfig.GetValue<double>(".tolerance");
    }
}
