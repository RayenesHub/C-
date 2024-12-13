using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ApplicationCore.Domain
{
    public class Prestataire
    {
        [Range(0,5,ErrorMessage="yohoho")]
        public int Appreciation { get; set; }
        public int PrestataireId { get; set; }
        public string PrestatairePhoto { get; set; }
        public string PrestataireTel { get; set; }
        [DataType(DataType.Currency)]
        public double TarifHoraire { get; set; }
        [MaxLength(20)]
        public string PrestataireNom { get; set; }
        [ForeignKey("MySpecialite")]
        public int SpecialiteFK { get; set; }
        ////////////////////////////////////////////////////////
       //ForeignKey("SpecialiteFK")]
        public virtual Specialite MySpecialite { get; set; }
        public virtual ICollection<Prestation> Prestations { get; set; }

    }
}
