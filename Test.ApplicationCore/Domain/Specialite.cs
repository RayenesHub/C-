using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ApplicationCore.Domain
{
    public enum Intitule { Bricolage, Jardinage, Menage }
    public class Specialite
    {
        [Key]
        public int Code { get; set; }

        public string Description { get; set; }

        public Intitule intitule { get; set; }
        public object Intitule { get; internal set; }

        ////////////////////////////////////////////
        public virtual ICollection<Prestataire> Prestataires { get; set; }
    }
}
 