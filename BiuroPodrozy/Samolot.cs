using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodrozy
{
    class Samolot : SrodekLokomocji
    {
        private int odleglosc;

        public override void ObliczCene()
        {
            if (odleglosc > 200) cenaBiletu = odleglosc * 2.56;
            else cenaBiletu = 24;
        }

        public Samolot(int iloscMiejscK,int odlegloscK)
        {
            this.iloscMiejsc = iloscMiejscK;
            this.odleglosc = odlegloscK;
            ObliczCene();
        }

        public override string ToString()
        {
            return "Samolot: ilosc miejsc: " + iloscMiejsc + ", odleglodc: " +
                odleglosc + ", cena biletu: " + cenaBiletu;
        }

    }
}
