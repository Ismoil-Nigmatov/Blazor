using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Shared
{
    public class Test
    {
        public int Id { get; set; }

        public string Question { get; set; }

        public List<string> Options { get; set; }

        public string RightOption { get; set; }
    }
}
