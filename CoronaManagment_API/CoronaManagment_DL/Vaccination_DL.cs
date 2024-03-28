using CoronaManagment_DL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CoronaManagment_DL
{
    public class Vaccination_DL : IVaccination_DL
    {
        CoronaManagmentContext coronamanagementContext = new CoronaManagmentContext();

        public List<Vaccination> GetAllVaccin(string identityClient)
        {
            try
            {

                var vaccines = coronamanagementContext.Vaccinations.Where(x => x.IdClient == identityClient).ToList();

                return vaccines;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddVaccin(Vaccination vaccination)
        {
            try
            {
                coronamanagementContext.Vaccinations.Add(vaccination);
                coronamanagementContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
