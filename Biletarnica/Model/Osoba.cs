namespace Biletarnica
{
    class Osoba
    {
        public string Ime { set; get; }
        public string Prezime { set; get; }
        public string JMBG { set; get; }

        public Osoba(string ime, string prezime, string jmbg)
        {
            Ime = ime;
            Prezime = prezime;
            JMBG = jmbg;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, JMBG: {2}", Ime, Prezime, JMBG);
        }
    }
}
