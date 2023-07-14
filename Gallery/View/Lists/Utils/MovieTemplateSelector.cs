using Gallery.View.Lists.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.View.Lists.Utils
{
    class MovieTemplateSelector : DataTemplateSelector
    {
        public DataTemplate TemplateDefault { get; set; }
        public DataTemplate TemplateLongMovie { get; set; }
        
        //toda linha do template chama este método
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Movie movie = (Movie)item;
            return (movie.Duration.Hours > 1) ? TemplateLongMovie : TemplateDefault;
        }
    }
}
