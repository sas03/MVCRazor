namespace RazorPrix.Models
{
    public class Expenditure
    {
        public string Nom { get; set; }
        public DateTime Date { get; set; }
        public double Prix { get; set; }
        public Expenditure(string nom, DateTime date, double prix)
        {
            Nom = nom;
            Date = date;
            Prix = prix;
        }
    }
}
