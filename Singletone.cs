﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    internal class Singletone
    {
        public static Entities DB { get; } = new Entities();
    }
}
