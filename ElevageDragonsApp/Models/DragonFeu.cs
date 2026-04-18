namespace ElevageDragonsApp.Models
{
    public class DragonFeu : Dragon
    {
        private int _temperatureFlamme;
        private int _intensiteFeu;
        private int _resistanceChaleur;

        public DragonFeu(string nom, int age, int niveau, int sante, int faim,
            int temperatureFlamme, int intensiteFeu, int resistanceChaleur)
            : base(nom, age, niveau, sante, faim)
        {
            _temperatureFlamme = temperatureFlamme;
            _intensiteFeu = intensiteFeu;
            _resistanceChaleur = resistanceChaleur;
        }

        public int TemperatureFlamme => _temperatureFlamme;
        public int IntensiteFeu => _intensiteFeu;
        public int ResistanceChaleur => _resistanceChaleur;

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