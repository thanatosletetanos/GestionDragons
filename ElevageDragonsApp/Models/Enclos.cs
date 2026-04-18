namespace ElevageDragonsApp.Models
{
    public class Enclos
    {
        private string _nom;
        private int _capaciteMax;
        private string _typeHabitat;
        private int _proprete;
        private List<Dragon> _dragons;

        public Enclos(string nom, int capaciteMax, string typeHabitat, int proprete)
        {
            _nom = nom;
            _capaciteMax = capaciteMax;
            _typeHabitat = typeHabitat;
            _proprete = proprete;
            _dragons = new List<Dragon>();
        }

        public string Nom => _nom;
        public int CapaciteMax => _capaciteMax;
        public string TypeHabitat => _typeHabitat;
        public int Proprete => _proprete;
        public List<Dragon> Dragons => _dragons;

        public void AjouterDragon(Dragon dragon)
        {
            throw new NotImplementedException();
        }

        public void RetirerDragon(Dragon dragon)
        {
            throw new NotImplementedException();
        }

        public void Afficher()
        {
            throw new NotImplementedException();
        }
    }
}