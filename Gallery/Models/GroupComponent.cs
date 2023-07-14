using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Models
{
    public class GroupComponent : List<Component>
    {
        public string Name { get; set; }
    }
}
