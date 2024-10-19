using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia2Gr2
{
    internal class Zespol
    {
        int liczbaAktywnychCzlonkowZespolu;
        string nazwaZespolu;
        KierownikZespolu kierownik;
        List<CzlonekZespolu> czlonkowie;

        public Zespol()
        {
            liczbaAktywnychCzlonkowZespolu = 0;
            nazwaZespolu = string.Empty;
            czlonkowie = new(); //!!!!!!!!!!!!!
        }
        public Zespol(string nazwaZespolu, KierownikZespolu kierownik)
            : this()
        {
            this.nazwaZespolu = nazwaZespolu;
            this.kierownik = kierownik;
        }
        public void DodajCzlonkaZespolu(CzlonekZespolu cz)
        {
            if (cz is not null)
            {
                czlonkowie.Add(cz);
                if (cz.Aktywny)
                {
                    ++liczbaAktywnychCzlonkowZespolu;
                }
            }
        }
        public CzlonekZespolu? 
            WyszukajCzlonkowZespolu(string pesel)
        {
            return czlonkowie.Find(cz => cz.Pesel == pesel);
        }
    }
}
