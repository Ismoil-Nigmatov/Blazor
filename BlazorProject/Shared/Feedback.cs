using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Shared
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public Education Education { get; set; }

        public User User { get; set; }
    }
}
