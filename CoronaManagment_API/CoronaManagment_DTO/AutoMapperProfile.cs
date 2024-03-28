using CoronaManagment_DL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaManagment_DTO
{
    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Client_DTO, Client>();
            CreateMap<Client, Client_DTO>();

            CreateMap<Vaccination_DTO, Vaccination>();
            CreateMap<Vaccination, Vaccination_DTO>();

            CreateMap<Sick_DTO, Sick>();
            CreateMap<Sick, Sick_DTO>();

        }
    }
}
