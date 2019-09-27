public class Editorial
{
    string Nom;
    List<Llibre> Llibres = new List<Llibre>();
    List<string> Autors = new List<string>();

    public Editorial(string nom, list<Llibre> llibres, list<string> autors)
    {
        Nom = nom;
        Llibres = llibres;
        Autors = autors
    }
    
    public string Nom { get; }
    public List<Llibre> llibres { get; }
    public List<string> autors { get; }
}