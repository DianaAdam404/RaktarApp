using System;
using System.Collections.Generic;
using System.Text;

namespace RaktarApp
{
    internal class TartosTermek : Termek
    {
        public int GaranciaEvek { get; set; }
        public TartosTermek(string BeCikkszam, int BeAlapar, int BeGaranciaevek) : base(BeCikkszam, BeAlapar)
        {
            GaranciaEvek = BeGaranciaevek;
        }
        public override int ErtekSzamitas(int darabszam)
        {
            return base.ErtekSzamitas(darabszam) + (GaranciaEvek * 500 * darabszam);
        }
        public override string ToString()
        {
            return base.ToString()+ $"| Garancia: [{GaranciaEvek}] év";
        }
    }
}
