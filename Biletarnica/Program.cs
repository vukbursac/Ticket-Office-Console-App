namespace Biletarnica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ovde samo ucitavamo podatke, i pravimo i prikazujemo osnovni meni.
             * Nema potrebe da 'zagadjujemo' ovu datoteku dodatnim funkcionalnostima.
             */

            UcitavanjePodataka.UcitajPodatke();

            Meni m = new Meni();
            m.DodajOpciju(PregledEntiteta.MeniPregled, "Pregled entiteta");
            m.DodajOpciju(RukovanjeEntitetima.MeniRukovanje, "Rukovanje entitetima");            
            m.Pokreni();
        }
    }
}
