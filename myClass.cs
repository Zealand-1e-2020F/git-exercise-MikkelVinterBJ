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
            return $"My name is {navn}, and i live in {adresse}, and my postnr is {postnr}";
        }
    }
}