﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class NameChangedEventArgs : EventArgs //specifies inheritance 
    {
        public string ExistingName { get; set; }
        public string NewName { get; set; }
    }
}
