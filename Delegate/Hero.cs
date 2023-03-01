using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Hero
    {
        

        public Hero(string v1, string v2, bool v3)
        {
            this.Nom = v1;
            this.Prenom = v2;
            this.peutvoler = v3;
        }

        public string Nom { get; set; }

      public string Prenom { get; set; }

      public  bool peutvoler { get; set; }
    }
}
