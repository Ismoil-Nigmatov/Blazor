﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Shared
{
    public class TaskAnswer
    {
        public int Id { get; set; }

        public string Answer { get; set; }

        public Task Task { get; set; }
    }
}
