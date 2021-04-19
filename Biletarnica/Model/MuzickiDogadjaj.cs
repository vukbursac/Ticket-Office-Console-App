namespace Biletarnica
{
    class MuzickiDogadjaj : Dogadjaj
    {
        /* Posto MuzickiDogadjaj nasledjuje Dogadjaj, ovde navodimo samo dodatna polja koja zelimo da svaki MuzickiDogadjaj ima. On automatski poseduje sva polja koja poseduje i Dogadjaj. */
        public string Izvodjac { set; get; }
        public string Zanr { set; get; }

        /* Prilikom konstruisanja objekta se MORA pozvati neki konstruktor pretka. Posto predak (klasa Dogadjaj) sadrzi konstruktor koji postavlja neka polja na odgovarajuce vrednosti, mi zelimo njega da pozovemo i prosledimo mu neke argumente koje smo dobili prilikom naseg poziva */
        public MuzickiDogadjaj(int id, string naziv, string mesto, string vreme, string izvodjac, string zanr) : base(id, naziv, mesto, vreme)
        {
            Izvodjac = izvodjac;
            Zanr = zanr;
        }

        /* Predak (klasa Dogadjaj) vec sadrzi metodu ToString koja radi jedan deo posla koji nam treba. Mi cemo iskoristiti taj deo posla pomocu base.ToString(), i dodati deo koji nam nedostaje. */
        public override string ToString()
        {
            string stringPretka = base.ToString();
            string ukupanString = stringPretka + ", Izvodjac:" + Izvodjac + ", Zanr:" + Zanr;
            return ukupanString;    
        }
    }
}
