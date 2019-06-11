using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchereSteinPapier_WPF
{
    class Spiellogic
    {
        // 0 = nicht gezogen, 1 = Schere, 2 = Stein, 3 = Papier
        private int Computerzug { get; set; }
        private int Spielerzug { get; set; }
        private int PunkteComputer { get; set; }
        private int PunkteSpieler { get; set; }

        public Spiellogic()
        {
            Computerzug = 0;
            Spielerzug = 0;
            PunkteComputer = 0;
            PunkteSpieler = 0;
        }

        internal int macheSpielzug()
        {
            Random random = new Random();
            return(random.Next(1, 4));
        }
    }
}
