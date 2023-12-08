using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Forca.Models
{
    internal class Word
    {
        public Word(string tips, string text) 
        { 
            this.Tips = tips;
            this.Text = text;
        }
        public string Tips { get; set; } = String.Empty;
        public string Text { get; set; } = String.Empty;
    }
}
