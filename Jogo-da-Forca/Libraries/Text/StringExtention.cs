using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Forca.Libraries.Text
{
    static class StringExtention
    {
        public static List<int> AllIndexesOff(this string str, string value)
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentNullException("A palavra nao pode ser vazia!", "value");
            List<int> indexes = new List<int>();
            for (int i = 0; ; i += value.Length)
            {
                i = str.IndexOf(value, i);
                if (i == -1)
                    return indexes;
                indexes.Add(i);
            }
        }
    }
}
