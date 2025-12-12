using System.Linq.Expressions;

namespace ForHerhaling;

class Program
{
    static void Main(string[] args)
    {
        double[] prijzen = new double[] { 10.5, 20.0, 15.75, 30.0, 25.5 };
        string[] artiekelen = {"Boek", "Pen", "Notitieboek", "Rugzak", "Laptop"};
        Formulier[] formulieren = new Formulier[2];

        
        formulieren[0] = new Formulier()
        {
            feedback = "Prijzig maar lekker",
            sterren = 4
        };

        formulieren[1] = new Formulier()
        {
            feedback = "Goede prijs kwaliteit verhouding",
            sterren = 5
        };

        for (int i = 0; i < prijzen.Length; i++)
        {
            Console.WriteLine($"Artikel: {artiekelen[i]}, Prijs: {prijzen[i]}");
        }
        foreach (Formulier formulier in formulieren)
        {
            Console.WriteLine($"Beoordeling: {formulier.sterren} sterren, Feedback: {formulier.feedback}");
        }
    
    }
    internal class Formulier
    {
        internal int sterren {get; set;}
        internal string feedback{get; set;}
    }

}
