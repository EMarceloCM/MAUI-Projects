using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Models
{
    public class Component
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Type page { get; set; }
        public bool IsReplacementPage { get; set; } = false;
    }
}
