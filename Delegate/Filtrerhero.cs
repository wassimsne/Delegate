

using Delegate;
using static Programme;


 
public class Filtrerhero
{
    public delegate bool ptrhero(Hero hero);
    public delegate TResult MyDelegate<T, TResult>(T arg);
    public delegate bool ptrgeneric<T>(T item);
    public  List<Hero> Filtrerher(List<Hero> Listhero, ptrhero f)
    {
        List<Hero> resultat = new List<Hero>();
        foreach (Hero h in Listhero)
        {if(f(h))
            resultat.Add(h);
        }
        return resultat;
    }
    public IEnumerable<T> Filtrerherogeneric<T>(IEnumerable<T> items, ptrgeneric<T> f)
    {
        
        foreach (T item in items)
        {
            if (f(item))
            {
                yield return item;
            }
        }
        
    }
}