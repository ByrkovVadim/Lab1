using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    class Encrypt
    {

        
        static List<string> initials = new List<string>()
        { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м",
          "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ",
          "ы", "ь", "э", "ю", "я"
        };
        int[] index = new int[initials.Count];
        string[] initial = new string[initials.Count];

        public void SelectArr()
        {
            int id = 100;
            for (int i = 0; i > index.Length; i++ )
            {
                index[i] = id + 1;
                initial[i] = initials[i]; 
            }
        }


        
    }
}
