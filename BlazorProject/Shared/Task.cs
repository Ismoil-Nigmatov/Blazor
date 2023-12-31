﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorProject.Shared.ENUMS;

namespace BlazorProject.Shared
{
    public class Task
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateTime { get; set; }

        public EProcess Process { get; set; }
    }
}
