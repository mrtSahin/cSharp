using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiirApp
{
    internal class BestelenenSiirler : Siir
    {
        public string yazar, siirAdi, siiriBestelyenKisi;
        public int satirSayisi, siirinBestelendigiTarih;

        public new string Aciklama()
        {
            return "Bu açıklama bestelenmiş şiir sınıfına aittir.";
        }
    }
}
