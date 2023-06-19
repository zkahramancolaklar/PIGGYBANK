using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public enum CoinAdi
    {
        BirLira,
        ElliKurus,
        YirmiBesKurus,
        OnKurus,
        BesKurus,
        BirKurus

    }
    class Coin : IPara
    {
        private readonly double Yaricap;
        private const double pi = 3.14159265;

        public string Adi { get; set; }
        public float Degeri { get; set; }

        public Coin(double yaricap)
        {
            this.Yaricap = yaricap;
        }

        public Coin()
        {

        }

        public double Hacim()
        {
            return pi * Math.Pow(Yaricap, 2);
        }



        public CoinAdi CoinAdi { get => _coinAdi; set => _coinAdi = value; }

        private CoinAdi _coinAdi;

    }
}
