namespace Biletarnica
{
    class SportskiDogadjaj : Dogadjaj
    {
        /* Posto SportskiDogadjaj nasledjuje Dogadjaj, ovde navodimo samo dodatna polja koja zelimo da svaki SportskiDogadjaj ima. On automatski poseduje sva polja koja poseduje i Dogadjaj. */
        public string VrstaSporta { set; get; }

        /* Prilikom konstruisanja objekta se MORA pozvati neki konstruktor pretka. Posto predak (klasa Dogadjaj) sadrzi konstruktor koji postavlja neka polja na odgovarajuce vrednosti, mi zelimo njega da pozovemo i prosledimo mu neke argumente koje smo dobili prilikom naseg poziva */
        public SportskiDogadjaj(int id, string naziv, string mesto, string vreme, string vrstaSporta) : base(id, naziv, mesto, vreme)
        {
            VrstaSporta = vrstaSporta;
        }

        /* Predak (klasa Dogadjaj) vec sadrzi metodu ToString koja radi jedan deo posla koji nam treba. Mi cemo iskoristiti taj deo posla pomocu base.ToString(), i dodati deo koji nam nedostaje. */
        public override string ToString()
        {
            string stringPretka = base.ToString();
            string ukupanString = stringPretka + ", Vrsta sporta:" + VrstaSporta;
            return ukupanString;
        }
    }
}
