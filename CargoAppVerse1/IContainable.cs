﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoAppVerse1
{
    public interface IContainable
    {
        bool Load();
        void Unload();
    }
}
