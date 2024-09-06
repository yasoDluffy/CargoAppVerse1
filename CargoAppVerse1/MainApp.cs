using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoAppVerse1
{
    public class MainApp
    {
        public static void RunMe()
        {
            ElectricDevice tv1 = new ElectricDevice("Samsung",105,10,85,4);//יצירת מופע חדש
            tv1.PackageItem();
        }
    }
}
