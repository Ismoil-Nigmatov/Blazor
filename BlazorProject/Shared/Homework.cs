﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Shared
{
    public class Homework
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public Task Task { get; set; }

    }
}
