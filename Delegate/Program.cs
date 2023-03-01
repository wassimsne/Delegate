

using Delegate;
using static Programme;

public class Programme
{
    

    public delegate int ptropr(int x, int y);
    public static void Main(String[] args)
    {
        List<Hero> hero = new List<Hero>()
        {
        new Hero("hfhj", "jhgj", true),
        new Hero("wassim", "snen", true)
        };

        List<Personne> pers = new List<Personne>()
        {
         new Personne("salah", "ali", true),
         new Personne("wassim", "snen", true)
        };
       



        ptropr FoncCalcul=Sommer;
       /* int resultat = FoncCalcul(5, 8);
        Console.WriteLine("la somme {0}", Sommer(3, 5));
        Console.WriteLine("la somme {0}", FoncCalcul(3, 5));
        Console.WriteLine("le resultat"+ resultat);*/

        CalculeretAffichier(5, 8, Sommer);
        CalculeretAffichier(5, 8, Multiplier);
        CalculeretAffichier(5, 8, (x,y)=>x+y);
        CalculeretAffichier(5, 8, (x, y) => x*y);

        CalculeretAffichier(5, 8, (x, y) =>

        {
            return x + y;
        });


        Filtrerhero filtrerh = new Filtrerhero();
        var x = filtrerh.Filtrerher(hero, h => h.Nom == "wassim");
        var y = filtrerh.Filtrerherogeneric(hero, h => h.Nom == "wassim");
        var z = filtrerh.Filtrerherogeneric(pers, h => h.Nom == "salah");
        foreach (var h in y)
        {
            Console.WriteLine(h.Nom);
        }
        foreach (var h in z)
        {
            Console.WriteLine(h.Nom);
        }



    }

    public static int Sommer(int x, int y)
    {
        return x + y;
    }
    public static int Multiplier(int x, int y)
    {
        return x*y;
    }
    public static void CalculeretAffichier(int x, int y, ptropr f)
    {
        int resultat = f(x, y);
        Console.WriteLine("le resultat est "+resultat);
    }
    

    

    
    

}