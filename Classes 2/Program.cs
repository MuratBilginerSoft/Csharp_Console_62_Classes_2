using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_2
{
    class Otomobiller
    {
        public string Renk;
        public string PlakaNo;
        public double Hacim;
        public int vites;

        public void GazaBas()
        {
            Console.WriteLine("Araç Hızlanıyor");
        }

        public void FreneBas()
        {
            Console.WriteLine("Araç Yavaşlıyor");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string Durum;
            Otomobiller X = new Otomobiller();// Genel Nesne Türetme Kodumuz

            X.Renk = "Siyah";
            X.PlakaNo = "09 DN 965";
            X.vites = 5;
            X.Hacim=345.5;

            Console.WriteLine("Aracın Plakası:{0}\n Aracın Rengi{1}\n Vites{2}\n Aracın Hacmi{3}",X.PlakaNo,X.Renk,X.vites,X.Hacim);

            Console.WriteLine("Gaza Basıyorsanız G Harfine Frene Basıyorsanız F Harfine Basınız");
            Durum = Console.ReadLine();

            if (Durum=="G")
            {
                X.GazaBas();
            }

            else if(Durum=="F")
            {
                X.FreneBas();
            }

            else
            {
                Console.WriteLine("Bu Aracın Böyle Bir Özelliği Yoktur0");
            }

            Console.ReadKey();
        }
    }
}
