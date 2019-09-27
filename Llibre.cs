public class Llibre
{
    string Autor;
    string Nom;
    string Editorial;
    decimal Preu;
    
    public Llibre(string autor, string nom, string editorial, decimal preu)
    {
        Autor = autor;
        Nom = nom;
        Editorial = editorial;
        Preu = preu;
    }
    
    public string Autor { get; }
    public string Nom { get; }
    public string Editorial { get; }
    public decimal Preu { get; set; }
}