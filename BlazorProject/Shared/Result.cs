using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Shared
{
    public class Result
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public Education Education { get; set; }
        public User User { get; set; }
    }
}
