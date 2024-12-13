using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.ApplicationCore.Domain;
using Test.ApplicationCore.Interface;

namespace Test.ApplicationCore.Service
{
    public class PrestataireService : Service<Prestataire>, IPrestataireService
    {
        public PrestataireService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IList<Prestataire> GetPrestataires()
        {
            //Bricolage indice 0 (equals) et retourne les 2 meillers(take(2))
            return GetMany(p=>p.MySpecialite.Intitule.Equals("0"))
                .OrderByDescending(p=>p.Appreciation)
                .Take(2).ToList();
        }
    }
}
