﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IDisposableDemo id = new IDisposableDemo();
            id.ToRead_Write();
            id.Dispose();

        }
    }
}
