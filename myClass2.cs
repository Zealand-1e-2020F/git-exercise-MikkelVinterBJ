namespace GitExercise
{
    class myClass2
    {
        private string navn{ get;}
        private string adresse {get;}
        private int postnr {get;}
        private string by {get;}
    

        public myClass2(string navn, string adresse, int postnr, string by)
        {
        this.navn = navn;
        this.adresse = adresse;
        this.postnr = postnr;
        this.by = by;
        }

        public override string ToString()
        {
            return $"Mit navn er {navn} og jeg bor på {adresse}, min by hedder {by} og mit postnummer er {postnr}";
        }
    }
}