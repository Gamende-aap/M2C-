namespace Constructors;

class QuizVraag
{
    internal string Vraag;
    internal string Antwoord;

    internal QuizVraag(string Vraag, string Antwoord)
    {
         this.Vraag = Vraag;
         this.Antwoord = Antwoord;
    }

    private void Run()
    {
        QuizVraag quizVraag = new QuizVraag("Wat is de hoofdstad van Nederland?", "Amsterdam");
    }
}
