using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ApplicationCore.Domain
{ 
    //configuration de clé composée en utilisant les annotations 
 // [PrimaryKey("ClientFK","PrestataireFK","HeureDebut")]
    public class Prestation
    { 
       public DateTime HeureDebut { get; set; }
        public int ClientFK { get; set; }
        public int PrestataireFK { get; set; }

        public int NbrHeures { get; set; }
        ////////////////////////////////////////////
        public virtual Client Myclient { get; set; }
        public virtual Prestataire MyPrestataire { get; set; }
    } 
}
