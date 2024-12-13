using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.ApplicationCore.Domain;

namespace Test.ApplicationCore.Interface
{
    public interface IPrestataireService : IService<Prestataire>
    {
        IList<Prestataire> GetPrestataires();
    }
}
