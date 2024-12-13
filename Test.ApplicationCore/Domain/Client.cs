using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ApplicationCore.Domain
{
    public class Client
    {
        //public string Adresse { get; set; }
        public Coordonnes coordonnes { get; set; }
        public int ClientId { get; set; }
        //public string nom { get; set; }
        //public string tel { get; set; }
        //public string prenom { get; set; }
        ///////////////////////////////////////////////////
        public virtual ICollection<Prestation> Prestations { get; set; }
    }
}
