namespace ElevageDragonsApp.Models
{
    public class Nourriture
    {
        private string _nom;
        private string _type;
        private int _valeurNutritive;
        private int _quantite;

        public Nourriture(string nom, string type, int valeurNutritive, int quantite)
        {
            _nom = nom;
            _type = type;
            _valeurNutritive = valeurNutritive;
            _quantite = quantite;
        }

        public string Nom => _nom;
        public string Type => _type;
        public int ValeurNutritive => _valeurNutritive;
        public int Quantite => _quantite;

        public void DiminuerQuantite()
        {
            throw new NotImplementedException();
        }

        public void Afficher()
        {
            throw new NotImplementedException();
        }
    }
}