namespace Biletarnica
{
    /* Enumeracija mora biti public da bi bila vidljiva ostatku koda */
    public enum TipUlaznice { OBICNA, VIP };

    class Ulaznica
    {
        public int Id { set; get; }
        public double Cena { set; get; }
        public TipUlaznice Tip { set; get; }

        /* Veza asocijacije - Svaka ulaznica zna za koji je dogadjaj namenjena (samo jedan dogadjaj). */
        public Dogadjaj Dogadjaj { set; get; }

        /* Veza asocijacije - Svaka ulaznica zna za koju je osobu namenjena (samo jednu osobu). */
        public Osoba Osoba { set; get; }

        public Ulaznica(int id, double cena, TipUlaznice tip, Dogadjaj dogadjaj, Osoba osoba)
        {
            Id = id;
            Cena = cena;
            Tip = tip;
            Dogadjaj = dogadjaj;
            Osoba = osoba;
        }

        public override string ToString()
        {
            string tipString;
            if (Tip == TipUlaznice.OBICNA)
            {
                tipString = "Obicna";
            }
            else
            {
                tipString = "VIP";
            }
            return string.Format("Id:{0} ,Cena:{1} ,Tip:{2} ,Naziv dogadjaja:{3} ,Osoba:{4}", Id, Cena, tipString, Dogadjaj.Naziv, Osoba.ToString());
        }
    }
}
