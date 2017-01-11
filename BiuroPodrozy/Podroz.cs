using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodrozy 
{
    class Podroz  : IZarzadzaj,IData
    {
        private DateTime dataPodrozy;
        private List<SrodekLokomocji> planPodrozy;
        private double koszty;


        public Podroz()
        {
            planPodrozy = new List<SrodekLokomocji>();
            this.koszty = 200;
        }

        public void stworzPlan()
        {
           planPodrozy.Add(new Autobus(20));
           planPodrozy.Add(new Samolot(100,20000));
        }

        public void DodajAutobus(int iloscMiejsc)
        {
            planPodrozy.Add(new Autobus(iloscMiejsc));
          //  koszty=koszty 
        }
       public void DodajSamolot(int iloscMiejsc, int odleglosc)
        {
            planPodrozy.Add(new Samolot(iloscMiejsc, odleglosc));
            //koszty = koszty  ;
        }
       public void UsunOstatni()
       {
           planPodrozy.RemoveAt( planPodrozy.Count-1);
       }
       public void Wyczysc()
       {
           planPodrozy.Clear();
       }
        public void UstawDate(DateTime data)
        {
            this.dataPodrozy = data;
        }
      public  bool SprawdzDate()
        {
            if (dataPodrozy > DateTime.Now) return true;
            else return false;
        }

      public override string ToString()
      {
          string lista = string.Empty;

          foreach(var element in planPodrozy)
          {
              lista+= element.ToString()+ "\r\n";

          }

          return lista;
      }
   


    }
}
