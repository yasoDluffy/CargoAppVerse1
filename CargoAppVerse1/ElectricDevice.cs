using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoAppVerse1
{
    public class ElectricDevice : Products
    {
        private int voltage;//הוספת תכונה שקשורה רק למחלקת חשמל
        public ElectricDevice(string name, double width, double height, double length, double weight, int voltage) : base(name, width, height, length, weight)
        {
            name = "Hello";
        }
    }
}
