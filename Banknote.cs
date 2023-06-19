using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public enum BanknoteAdi
    {
        IkiYuzLira,
        YuzLira,
        ElliLira,
        YirmiLira,
        OnLira,
        BesLira

    }
    class Banknote : IPara
    {

        public int En { get; set; }
        public int Boy { get; set; }

        const double yükseklik = 0.25;

        public Banknote(int en, int boy)
        {
            En = en;
            Boy = boy;
        }

        public Banknote()
        {

        }

        public string Adi { get; set; }
        public float Degeri { get; set; }

        public double Hacim()
        {
            return En / 4 * Boy * yükseklik * 4;
        }



        public BanknoteAdi BanknoteAdi { get => _banknoteAdi; set => _banknoteAdi = value; }

        private BanknoteAdi _banknoteAdi;

    }
}



/*BONUS-3: Her bir paranın kendisine göre kapladığı bir hacim olmalıdır.Banknote
hacmi x*y*z(en*boy*yükseklik) olarak hesaplanabilir.
    */
