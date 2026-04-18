namespace ElevageDragonsApp.Models
{
    public class DragonPlante : Dragon
    {
        private int _energieNature;
        private int _vitesseRegeneration;
        private string _couleurEcailles;

        public DragonPlante(string nom, int age, int niveau, int sante, int faim,
            int energieNature, int vitesseRegeneration, string couleurEcailles)
            : base(nom, age, niveau, sante, faim)
        {
            _energieNature = energieNature;
            _vitesseRegeneration = vitesseRegeneration;
            _couleurEcailles = couleurEcailles;
        }

        public int EnergieNature => _energieNature;
        public int VitesseRegeneration => _vitesseRegeneration;
        public string CouleurEcailles => _couleurEcailles;

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