using CoronaManagment_DL.Models;
using System.Collections.Generic;

namespace CoronaManagment_DL
{
    public interface IClient_DL
    {
        List<Client> GetAllClients();
        public Client GetClient(int id);
        public bool AddClient(Client newClient);
        public bool DeleteClient(string IdentityClient);
        public bool UpdateClient(int id, Client client);
        public int CountUnvaccinated();
    }
}