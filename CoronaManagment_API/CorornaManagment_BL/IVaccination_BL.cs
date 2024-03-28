using CoronaManagment_DTO;
using System.Collections.Generic;

namespace CorornaManagment_BL
{
    public interface IVaccination_BL
    {
        List<Vaccination_DTO> GetAllVaccin(string identityClient);
        public bool AddVaccin(Vaccination_DTO vaccination);
    }
}