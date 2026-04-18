namespace ElevageDragonsApp.Models
{
    public class DragonEau : Dragon
    {
        private int _niveauHydratation;
        private int _vitesseNage;
        private int _resistanceFroid;

        public DragonEau(string nom, int age, int niveau, int sante, int faim,
            int niveauHydratation, int vitesseNage, int resistanceFroid)
            : base(nom, age, niveau, sante, faim)
        {
            _niveauHydratation = niveauHydratation;
            _vitesseNage = vitesseNage;
            _resistanceFroid = resistanceFroid;
        }

        public int NiveauHydratation => _niveauHydratation;
        public int VitesseNage => _vitesseNage;
        public int ResistanceFroid => _resistanceFroid;

        public void UtiliserPouvoir()
        {
            throw new NotImplementedException();
        }

        public override void Afficher()
        {
            throw new NotImplementedException();
        }
    }
}