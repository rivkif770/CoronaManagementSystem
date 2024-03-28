using CoronaManagment_DL.Models;
using CoronaManagment_DTO;
using System.Collections.Generic;

namespace CorornaManagment_BL
{
    public interface IClient_BL
    {
        List<Client_DTO> GetAllClients();
        public Client_DTO GetClient(int id);
        public bool AddClient(Client_DTO newClient);
        public bool DeleteClient(string IdentityClient);
        public bool UpdateClient(int id, Client_DTO client);
        public int CountUnvaccinated();
    }
}