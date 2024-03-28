using AutoMapper;
using CoronaManagment_DL;
using CoronaManagment_DL.Models;
using CoronaManagment_DTO;
using System;
using System.Collections.Generic;

namespace CorornaManagment_BL
{
    public class Client_BL : IClient_BL
    {
        private IClient_DL client_DL;
        IMapper mapper;

        public Client_BL(IClient_DL client_DL)
        {
            this.client_DL = client_DL;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });

            mapper = config.CreateMapper();
        }

        public List<Client_DTO> GetAllClients()
        {
            return mapper.Map<List<Client>, List<Client_DTO>>(client_DL.GetAllClients());
        }

        public Client_DTO GetClient(int id)
        {
            return mapper.Map<Client, Client_DTO>(client_DL.GetClient(id));
        }

        public bool AddClient(Client_DTO newClient)
        {
            Client client = mapper.Map<Client_DTO, Client>(newClient);
            return client_DL.AddClient(client);
        }

        public bool DeleteClient(string IdentityClient)
        {
            return client_DL.DeleteClient(IdentityClient);
        }

        public bool UpdateClient(int id, Client_DTO client)
        {
            Client newClient = mapper.Map<Client_DTO, Client>(client);
            return client_DL.UpdateClient(id, newClient);
        }

        public int CountUnvaccinated()
        {
            return client_DL.CountUnvaccinated();
        }

    }
}
