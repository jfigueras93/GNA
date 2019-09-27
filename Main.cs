using Autor;
using Llibre;
using Editorial;

class Test
{
    static void Main()
    {
        const decimal IVA = 1.21;

        //Creem tots els objectes per fer els exemples
        var AldousHuxley = new Autor("Aldous Huxley");
        var GoergeRRMartin = new Autor("George RR Martin");

        List<Llibre> editorials = new List<Llibre>();

        var Planeta = new Editorial("Planeta", null);
        var Agostini = new Editorial("Agostini", null);
        var Gigamesh = new Editorial("Gigamesh", null);
        var Lubna = new Editorial("Lubna", null);
        var Virtual = new Editorial("Virtual", null);
        //Posteriorment es podria afegir un llistat de llibres a cada editorial.

        List<Llibre> llibres = new List<Llibre>();
        
        var UnMundoFeliz = new Llibre(AldousHuxley, "Un Mundo Feliz", "Planeta", 20.00);
        var LaIsla = new Llibre(AldousHuxley, "La Isla", "Agostini", 20.00);
        var CromeYellow = new Llibre(AldousHuxley, "Crome Yellow", "Planeta", 20.00);
        var XocDeReis = new Llibre(GoergeRRMartin, "Xoc de Reis", "Gigamesh", 12.50);
        var SueñoDelFevre = new Llibre(GoergeRRMartin, "Sueño del Fevre", "Virtual", 5.00);    

        llibres.Add(UnMundoFeliz);
        llibres.Add(LaIsla);
        llibres.Add(CromeYellow);
        llibres.Add(XocDeReis);
        llibres.Add(SueñoDelFevre);

        //Mostrar Llistat de llibres per autor ex: Aldous Huxley
        Console.WriteLine(LlistarLlibresPerAutor(llibres, AldousHuxley));

        //Mostrar Llistat de llibres inferiors a 15€
        Console.WriteLine(LlistarLlibresPerPreu(llibres));
    }

    public List<Llibres> LlistarLlibresPerAutor(List<Llibres> Llistat, string nomLlibre)
    {
        List<Llibres> LlistatPerAutor = new List<Llibres>();
        foreach (var llibre in Llistat)
        {
            if (nomLlibre = llibre.Nom)
            {
                LlistatPerAutor.Add(llibre);    
            }
        }
        return LlistatPerAutor;
    }

    public List<Editorial> LlistarEditorialsPerAutor(List<Editorial> Llistat, string nomAutor)
    {
        List<Editorial> LlistatPerEditorial = new List<Editorial>();
        foreach (var editorial in LlistatPerEditorial)
        {
            if (nomAutor = editorial.Autor)
            {
                LlistatPerEditorial.Add(editorial);    
            }
        }
        return LlistatPerEditorial;
    }

    public List<Llibres> LlistarLLibresInferiors(List<Llibres> Llistat)
    {
        List<Llibres> LlistatPerPreu = new List<Llibres>();
        foreach (var llibre in Llistat)
        {
            if (llibre.Preu < 15.00)
            {
                LlistatPerPreu.Add(llibre);  
                llibre.Preu = llibre.Preu * IVA;  //Afegim l'IVA designat al principi.
            }
        }
        return LlistatPerPreu;
    }
}