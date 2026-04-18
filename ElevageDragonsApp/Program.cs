using ElevageDragonsApp.Models;

namespace ElevageDragonsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventaire inventaire = new Inventaire(20, 0);
            Eleveur eleveur = new Eleveur("Thana", 1, inventaire);

            Enclos enclosFeu = new Enclos("Enclos Feu", 3, "Volcanique", 100);

            DragonFeu dragonFeu = new DragonFeu("Drako", 1, 1, 100, 50, 80, 70, 60);
            DragonEau dragonEau = new DragonEau("Aqua", 2, 1, 100, 40, 90, 60, 50);
            DragonPlante dragonPlante = new DragonPlante("Leaf", 1, 1, 100, 30, 85, 75, "Vert");

            Nourriture nourriture = new Nourriture("Viande", "Carnée", 25, 10);

            Console.WriteLine("Squelette opérationnel.");
        }
    }
}