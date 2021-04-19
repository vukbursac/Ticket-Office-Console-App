namespace Biletarnica
{
    static class UcitavanjePodataka
    {
        /*
         * U ovu datoteku smo stavili sav kod koji se odnosi na ucitavanje podataka
         * iz datoteka.
         */

        private static void UcitajOsobe(string imeFajla)
        {
            /* Otvaramo datoteku */
            System.IO.StreamReader file = new System.IO.StreamReader(imeFajla);

            string linija;
            while (true)
            {
                /* Pokusavamo da ocitamo sledecu liniju teksta iz datoteke */
                linija = file.ReadLine();

                /* Ako smo dosli do kraja datoteke, zaustavljamo petlju */
                if (linija == null)
                {
                    break;
                }

                /* Razdvajamo ocitanu liniju na delove */
                string[] deloviLinije = linija.Split(',');

                /* Interpretiramo delove linije kao ime, prezime i jmbg osobe */
                string ime = deloviLinije[0];
                string prezime = deloviLinije[1];
                string jmbg = deloviLinije[2];

                /* Koristeci ocitane podatke o osobi, kreiramo novi objekat */
                Osoba novaOsoba = new Osoba(ime, prezime, jmbg);

                /* Ubacujemo novonastali objekat u staticku listu u kojoj cuvamo sve Osobe */
                Podaci.listaOsoba.Add(novaOsoba);
            }
        }

        private static void UcitajMuzickeDogadjaje(string imeFajla)
        {
            /* Otvaramo datoteku */
            System.IO.StreamReader file = new System.IO.StreamReader(imeFajla);

            string linija;
            while (true)
            {
                /* Pokusavamo da ocitamo sledecu liniju teksta iz datoteke */
                linija = file.ReadLine();

                /* Ako smo dosli do kraja datoteke, zaustavljamo petlju */
                if (linija == null)
                {
                    break;
                }

                /* Razdvajamo ocitanu liniju na delove */
                string[] deloviLinije = linija.Split(',');

                /* Interpretiramo delove linije kao podatke o muzickom dogadjaju */

                /* ID nam je celobrojni tip. Moramo prvo proveriti da li je moguca konverzija iz tekstualnog u celobrojni. */
                int id;

                /* Ukoliko konverzija nije uspela, preskocicemo ovaj red u datoteci - prelazimo na sledeci */
                if (!int.TryParse(deloviLinije[0], out id))
                {
                    continue;
                }

                /* Ukoliko je konverzija uspela, nastavljamo dalje */
                string naziv = deloviLinije[1];
                string mesto = deloviLinije[2];
                string vreme = deloviLinije[3];
                string izvodjac = deloviLinije[4];
                string zanr = deloviLinije[5];

                /* Koristeci ocitane podatke o muzickom dogadjaju, kreiramo novi objekat */
                MuzickiDogadjaj noviDogadjaj = new MuzickiDogadjaj(id, naziv, mesto, vreme, izvodjac, zanr);

                /* Ubacujemo novonastali objekat u staticku listu u kojoj cuvamo sve Dogadjaje */
                Podaci.listaDogadjaja.Add(noviDogadjaj);
            }
        }

        private static void UcitajSportskeDogadjaje(string imeFajla)
        {
            /* Otvaramo datoteku */
            System.IO.StreamReader file = new System.IO.StreamReader(imeFajla);

            string linija;
            while (true)
            {
                /* Pokusavamo da ocitamo sledecu liniju teksta iz datoteke */
                linija = file.ReadLine();

                /* Ako smo dosli do kraja datoteke, zaustavljamo petlju */
                if (linija == null)
                {
                    break;
                }

                /* Razdvajamo ocitanu liniju na delove */
                string[] deloviLinije = linija.Split(',');

                /* Interpretiramo delove linije kao podatke o sportskom dogadjaju */

                /* ID nam je celobrojni tip. Moramo prvo proveriti da li je moguca konverzija iz tekstualnog u celobrojni. */
                int id;

                /* Ukoliko konverzija nije uspela, preskocicemo ovaj red u datoteci - prelazimo na sledeci */
                if (!int.TryParse(deloviLinije[0], out id))
                {
                    continue;
                }

                /* Ukoliko je konverzija uspela, nastavljamo dalje */
                string naziv = deloviLinije[1];
                string mesto = deloviLinije[2];
                string vreme = deloviLinije[3];
                string vrstaSporta = deloviLinije[4];

                /* Koristeci ocitane podatke o sportskom dogadjaju, kreiramo novi objekat */
                SportskiDogadjaj noviDogadjaj = new SportskiDogadjaj(id, naziv, mesto, vreme, vrstaSporta);

                /* Ubacujemo novonastali objekat u staticku listu u kojoj cuvamo sve Dogadjaje */
                Podaci.listaDogadjaja.Add(noviDogadjaj);
            }
        }

        private static void UcitajUlaznice(string imeFajla)
        {
            /* Otvaramo datoteku */
            System.IO.StreamReader file = new System.IO.StreamReader(imeFajla);

            string linija;
            while (true)
            {
                /* Pokusavamo da ocitamo sledecu liniju teksta iz datoteke */
                linija = file.ReadLine();

                /* Ako smo dosli do kraja datoteke, zaustavljamo petlju */
                if (linija == null)
                {
                    break;
                }

                /* Razdvajamo ocitanu liniju na delove */
                string[] deloviLinije = linija.Split(',');


                /* Interpretiramo delove linije kao podatke o sportskom dogadjaju */

                /* ID nam je celobrojni tip. Moramo prvo proveriti da li je moguca konverzija iz tekstualnog u celobrojni. */
                int id;

                /* Ukoliko konverzija nije uspela, preskocicemo ovaj red u datoteci - prelazimo na sledeci */
                if (!int.TryParse(deloviLinije[0], out id))
                {
                    continue;
                }

                /* Ukoliko je konverzija uspela, nastavljamo dalje */

                /* Cena nam je realni broj. Moramo prvo proveriti da li je moguca konverzija iz teksta u realni broj */
                double cena;
                if (!double.TryParse(deloviLinije[1], out cena))
                {
                    continue;
                }

                /* Tip ulaznice je u programu enumeracija, a u datoteci jedan karakter koji bi trebalo da bude ili "O" ili "V". Moramo sada proveriti koji se karakter nalazi u datoteci, i napraviti odgovarajucu instancu enumeracije. */
                string tipUlazniceString = deloviLinije[2];
                TipUlaznice tip;
                if (tipUlazniceString == "O")
                {
                    tip = TipUlaznice.OBICNA;
                }
                else if(tipUlazniceString == "V")
                {
                    tip = TipUlaznice.VIP;
                }
                else
                {
                    continue;
                }

                /* Ulaznica i dogadjaj su vezani jednosmernom asocijacijom - Svaka ulaznica bi trebalo da zna za dogadjaj za koji je namenjena. U C# kodu smo to realizovali ubacivanjem reference na dogadjaj u klasu Ulaznica. U datoteci je veza realizovana tako sto svaka ulaznica u sebi ima zapisan id dogadjaja za koji je namenjena.
                 * 
                 * Nama nije cilj da u objektu ulaznice stoji "int id" dogadjaja, vec referenca na postojeci objekat odgovarajuceg dogadjaja.
                 * 
                 * Zbog toga nam je zadatak da ocitamo id dogadjaja iz datoteke, potom pronadjemo odgovarajuci dogadjaj iz staticke liste u kojoj cuvamo sve dogadjaje, i njegovu referencu smestimo u novi objekat ulaznice koji pravimo na kraju ove metode */

                int idDogadjaja;
                if (!int.TryParse(deloviLinije[3], out idDogadjaja))
                {
                    continue;
                }
                Dogadjaj dogadjaj = RukovanjeEntitetima.PronadjiDogadjajPoId(idDogadjaja);

                /* Slicno radimo i za osobe - od procitanog JMBG-a moramo da pronadjemo referencu na odgovarajuci objekat osobe u statickoj listi svih osoba */
                string jmbgOsobe = deloviLinije[4];
                Osoba osoba = RukovanjeEntitetima.PronadjiOsobuPoJMBG(jmbgOsobe);

                /* Koristeci ocitane podatke i pronadjene reference, pravimo novu ulaznicu */
                Ulaznica novaUlaznica = new Ulaznica(id, cena, tip, dogadjaj, osoba);

                /* Ubacujemo novu ulaznicu u staticku listu svih ulaznica */
                Podaci.listaUlaznica.Add(novaUlaznica);
            }
        }

        public static void UcitajPodatke()
        {
            /*
             * Imena datoteka smo zadali ovde. Struktura naseg projekta je takva da je 
             * izvrsna datoteka (.exe) u direktorijumu bin\\Debug. Zbog toga, da bismo
             * dosli do direktorijuma 'data' u kome se nalaze nasi podaci, moramo prvo
             * da se 'popnemo' dva nivoa iznad u odnosu na direktorijum izvrsne datoteke.
             * Dupla tacka (..) predstavlja penjanje u roditeljski direktorijum.
             * 
             * Ovo je uradjeno radi jednostavnosti programa. Naravno, bolje je parametrizovati
             * direktorijume i imena samih datoteka, pa ih spajati metodom Path.Combine()
             */

            UcitajOsobe("..\\..\\data\\osobe.csv");
            UcitajMuzickeDogadjaje("..\\..\\data\\muzicki.csv");
            UcitajSportskeDogadjaje("..\\..\\data\\sportski.csv");
            UcitajUlaznice("..\\..\\data\\ulaznice.csv");
        }

    }
}
