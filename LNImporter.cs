﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer
{
    interface LNImporter
    {
        void parse();

        void saveToDatabase();

    }
}