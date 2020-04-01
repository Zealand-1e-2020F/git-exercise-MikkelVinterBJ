namespace GitExercise
{
    class myClass
    {
        private string navn{ get; set; }
        private string adresse {get; set;}
        private int postnr {get; set;}
    

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