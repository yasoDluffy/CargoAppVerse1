using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoAppVerse1
{
    //אבסטרקי הכוונה אל תיתן למשתמש ליצור משהו מתוך פרודקט
    public abstract class Products:IPortable//מימוש אינטרפס
    {
        //בסיס למחלקות יורשות
        private string name;
        private double width;
        private double height;
        private double length;
        private double weight;

        protected Products(string name, double width, double height, double length, double weight)
        {
            this.name = name;
            this.width = width;
            this.height = height;
            this.length = length;
            this.weight = weight;
        }

        public bool IsPackaged()
        {
            return true;
        }

        public void PackageItem()
        {
            
        }
       
    }
}
