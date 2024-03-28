using AutoMapper;
using CoronaManagment_DL;
using CoronaManagment_DL.Models;
using CoronaManagment_DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CorornaManagment_BL
{
    public class Sick_BL : ISick_BL
    {
        ISick_DL sick_DL;
        IMapper mapper;

        public Sick_BL(ISick_DL sick_DL)
        {
            this.sick_DL = sick_DL;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });

            mapper = config.CreateMapper();
        }

        public Sick_DTO GetSick(string identityClient)
        {
            return mapper.Map<Sick, Sick_DTO>(sick_DL.GetSick(identityClient));
        }

        public bool AddSick(Sick_DTO newSick)
        {
            Sick sick = mapper.Map<Sick_DTO, Sick>(newSick);
            return sick_DL.AddSick(sick);
        }

        public int[] CountSick()
        {
            return sick_DL.CountSick();
        }
    }
}
