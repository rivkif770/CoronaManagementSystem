using AutoMapper;
using CoronaManagment_DL;
using CoronaManagment_DL.Models;
using CoronaManagment_DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CorornaManagment_BL
{
    public class Vaccination_BL : IVaccination_BL
    {
        IVaccination_DL vaccination_DL;
        IMapper mapper;

        public Vaccination_BL(IVaccination_DL vaccination_DL)
        {
            this.vaccination_DL = vaccination_DL;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });

            mapper = config.CreateMapper();
        }

        public List<Vaccination_DTO> GetAllVaccin(string identityClient)
        {
            return mapper.Map<List<Vaccination>, List<Vaccination_DTO>>(vaccination_DL.GetAllVaccin(identityClient));
        }

        public bool AddVaccin(Vaccination_DTO vaccination)
        {
            Vaccination vaccin = mapper.Map<Vaccination_DTO, Vaccination>(vaccination);
            return vaccination_DL.AddVaccin(vaccin);
        }
    }
}
