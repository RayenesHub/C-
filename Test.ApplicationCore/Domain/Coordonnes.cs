using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ApplicationCore.Domain
{
    //classe de type d'entité détenue(détention des attributs de la classe client)
    //Avec API Fluent on doit crée un classe ClientConfig (builder.OnwsOne(c=>c.Coordonnes))
    [Owned]
    public class Coordonnes
    {
        public string Adresse { get; set; }
        public string nom { get; set; }
        public string tel { get; set; }
        public string prenom { get; set; }
    }
}
