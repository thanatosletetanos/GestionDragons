namespace ElevageDragonsApp.Models
{
    public abstract class Dragon
    {
        private string _nom;
        private int _age;
        private int _niveau;
        private int _sante;
        private int _faim;

        public Dragon(string nom, int age, int niveau, int sante, int faim)
        {
            _nom = nom;
            _age = age;
            _niveau = niveau;
            _sante = sante;
            _faim = faim;
        }

        public string Nom => _nom;
        public int Age => _age;
        public int Niveau => _niveau;
        public int Sante => _sante;
        public int Faim => _faim;

        public virtual void Manger(Nourriture nourriture)
        {
            throw new NotImplementedException();
        }

        public virtual void Evoluer()
        {
            throw new NotImplementedException();
        }

        public abstract void Afficher();
    }
}