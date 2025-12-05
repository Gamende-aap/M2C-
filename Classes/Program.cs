using System.Runtime.InteropServices;
 
namespace Classes;
 
class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
 
    Auto auto1 = new Auto()
    {
        automaat = true,
        kenteken = "AB-123-CD",
        kilometerStand = 15000,
        merk = "BMW",
    };
 
    Auto auto2 = new Auto()
    {
        automaat = false,
        kenteken = "PD-028-KL",
        kilometerStand = 2835189,
        merk = "Audi",
    };
 
    RijLeraar rijleraar1 = new RijLeraar()
    {
        naam = "Jan",
        leeftijd = 45,
        zzp = false,
    };

    TheorieTest theorieTest1 = new TheorieTest()
    {
        AantalFouten = 3,
        Gehaald = true,
        afnameDatum = new DateTime(2024, 11, 15),
    };

    RijTest rijTest1 = new RijTest()
    {
        Gehaald = false,
        AfnameDatum = new DateTime(2024, 12, 1),
    };

    LesPakket lesPakket1 = new LesPakket()
    {
        urenGekocht = 40,
        urenVerbruikt = 25,
        examenPogingen = 2,
        automaat = false,
    };

    void Run()
    {
        var student1 = new Student()
        {
            naam = "Pietje",
            leeftijd = 25,
            lespakket = lesPakket1,
            rijLeraar = rijleraar1,
            theorieTest = theorieTest1,
            rijTest = rijTest1,
        };

        var lesuur = new LesUur()
        {
            auto = auto1,
            rijLeraar = rijleraar1,
            student = student1,
            tijd = 1130,
        };
    }
}