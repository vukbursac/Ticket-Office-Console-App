namespace Biletarnica
{
    /* Klasa koja opisuje bilo kakav dogadjaj. Nema potrebe da bude apstraktna - mozda neko zeli da pravi dogadjaje koji nisu ni muzicki ni sportski. Nije strasno ni ako stavite da je apstraktna, samo imajte na umu posledice te odluke  :) */
    class Dogadjaj
    {
        public int Id { set; get; }
        public string Naziv { set; get; }
        public string Mesto { set; get; }
        public string Vreme { set; get; }

        public Dogadjaj(int id, string naziv, string mesto, string vreme)
        {
            Id = id;
            Naziv = naziv;
            Mesto = mesto;
            Vreme = vreme;
        }

        public override string ToString()
        {
            return string.Format("Id:{0}, Naziv:{1}, Mesto:{2}, Vreme:{3}",
                Id, Naziv, Mesto, Vreme);
        }
    }
}
