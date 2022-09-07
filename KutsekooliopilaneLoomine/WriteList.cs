using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutsekooliopilaneLoomine
{
    internal class WriteList
    {
        public static void WriteToListHamster(Kutsekooliõpilane kutsekooliõpilane)
        {
            var list = kutsekooliõpilane.Return_List();
            string path = @"C:\Users\opilane.TTHK\Source\Repos\KutsekooliopilaneLoominee\KutsekooliopilaneLoomine\Inimesed.txt";

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                foreach (String s in list)
                    writer.WriteLine(s);
            }

        }
    }
}
