using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoAppVerse1
{
    /*
         portable זה נייד
         IPortable זה הממשק
         זהו ממשק שחל על כל המוצרים - כי הם ניידים   
     
    */
    public interface IPortable //הגדרת פעולות אינטרפס שחובה לממש
    {
        void PackageItem();
        bool IsPackaged();




    }
}
