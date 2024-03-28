using CoronaManagment_DL.Models;
using System.Collections.Generic;

namespace CoronaManagment_DL
{
    public interface IVaccination_DL
    {
        List<Vaccination> GetAllVaccin(string identityClient);
        public bool AddVaccin(Vaccination vaccination);
    }
}