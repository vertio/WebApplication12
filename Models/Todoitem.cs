using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication12.models
{
    public class Todoitem
    {
        public long Id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public bool IsComplete { get; set; }

    }
}
