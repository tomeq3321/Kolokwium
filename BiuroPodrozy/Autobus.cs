using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodrozy
{
    class Autobus : SrodekLokomocji
    {
        public Autobus(int iloscMiejscK)
        {
            this.iloscMiejsc = iloscMiejscK;

            ObliczCene();
        }

        public override string ToString()
        {
            return "Autobus: ilosc miejsc: " + iloscMiejsc + ", cena biletu: " + cenaBiletu;

        }
    }
}
