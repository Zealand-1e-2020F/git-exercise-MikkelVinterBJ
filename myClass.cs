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
}
}