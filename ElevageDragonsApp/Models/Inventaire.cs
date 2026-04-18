namespace ElevageDragonsApp.Models
{
    public class Inventaire
    {
        private int _capacite;
        private int _nombreElements;
        private List<Nourriture> _nourritures;

        public Inventaire(int capacite, int nombreElements)
        {
            _capacite = capacite;
            _nombreElements = nombreElements;
            _nourritures = new List<Nourriture>();
        }

        public int Capacite => _capacite;
        public int NombreElements => _nombreElements;
        public List<Nourriture> Nourritures => _nourritures;

        public void AjouterNourriture(Nourriture nourriture)
        {
            throw new NotImplementedException();
        }

        public void RetirerNourriture(Nourriture nourriture)
        {
            throw new NotImplementedException();
        }

        public void AfficherStock()
        {
            throw new NotImplementedException();
        }
    }
}