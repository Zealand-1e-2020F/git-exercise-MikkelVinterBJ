namespace GitExercise
{
    class myClass
    {
        private string navn{ get;}
        private string adresse {get;}
        private int postnr {get;}
        private string by {get;}
    

        public myClass(string navn, string adresse, int postnr)
        {
        this.navn = navn;
        this.adresse = adresse;
        this.postnr = postnr;
        }

        public override string ToString()
        {
            return $"Mit navn {navn}og jeg bor på {adresse}, min by hedder {by} og mit postnummer er {postnr}";
        }
    }
}