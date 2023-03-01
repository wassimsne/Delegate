using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Personne
    {
        

        public Personne(string v1, string v2, bool v3)
        {
            this.Nom = v1;
            this.age = v2;
            this.adresse = v3;
        }

        public string Nom { get; set; }

      public string age { get; set; }

      public  bool adresse { get; set; }
    }
}
