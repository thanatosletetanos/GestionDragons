namespace ElevageDragonsApp.Models
{
    public class Eleveur
    {
        private string _nom;
        private int _niveauExperience;
        private Inventaire _inventaire;
        private List<Enclos> _enclos;

        public Eleveur(string nom, int niveauExperience, Inventaire inventaire)
        {
            _nom = nom;
            _niveauExperience = niveauExperience;
            _inventaire = inventaire;
            _enclos = new List<Enclos>();
        }

        public string Nom => _nom;
        public int NiveauExperience => _niveauExperience;
        public Inventaire Inventaire => _inventaire;
        public List<Enclos> Enclos => _enclos;

        public void NourrirDragon(Dragon dragon, Nourriture nourriture)
        {
            throw new NotImplementedException();
        }

        public void AjouterDragonEnclos(Dragon dragon, Enclos enclos)
        {
            throw new NotImplementedException();
        }

        public void AfficherElevage()
        {
            throw new NotImplementedException();
        }
    }
}