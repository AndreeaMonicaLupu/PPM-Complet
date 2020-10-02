using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_SOAC
{
    public class Instructiune
    {
        public string tip;
        public int PC_curent, PC_urmator;
        public Instructiune(string tipp, string PC_c, string PC_u)
        {
            tip = tipp;
            PC_curent = Int32.Parse(PC_c);
            PC_urmator = Int32.Parse(PC_u);

        }

        public int Taken_NotTaken(string tip)
        {
            if (tip == "BT" || tip == "BS" || tip == "BM" || tip == "BR")
                return 1;
            else if (tip == "NT")
                return 0;

            return -100;
        }
    }
}
