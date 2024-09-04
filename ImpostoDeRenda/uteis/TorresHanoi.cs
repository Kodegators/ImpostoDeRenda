using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoDeRenda.uteis
{
    public class TorresHanoi
    {

        public static void TorresHanoiJogo()
        {
            var disc = '-';
            List<int> torre1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> torre2 = new List<int> { };
            List<int> torre3 = new List<int> { };

            for (int i = 0; i < torre1.Count; i++)
            {
                int t2 = torre2.ElementAtOrDefault(i);
                int t3 = torre3.ElementAtOrDefault(i);
                Console.WriteLine(new string(disc, torre1[i]));
            }
        }
    }
}
