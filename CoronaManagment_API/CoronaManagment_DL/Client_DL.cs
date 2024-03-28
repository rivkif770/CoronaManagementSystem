using CoronaManagment_DL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace CoronaManagment_DL
{
    public class Client_DL : IClient_DL
    {
        CoronaManagmentContext coronamanagementContext = new CoronaManagmentContext();

        public List<Client> GetAllClients()
        {
            try
            {
                return coronamanagementContext.Clients.ToList();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Client GetClient(int id)
        {
            try
            {
                return coronamanagementContext.Clients.SingleOrDefault(x => x.Id == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddClient(Client newClient)
        {
            try
            {
                coronamanagementContext.Clients.Add(newClient);

                coronamanagementContext.SaveChanges();
                return true;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteClient(string IdentityClient)
        {
            try
            {
                foreach(var item in coronamanagementContext.Vaccinations)
                {
                    if (item.IdClient == IdentityClient)
                    {
                        coronamanagementContext.Vaccinations.Remove(item);
                    }     
                }

                Sick sick = coronamanagementContext.Sicks.SingleOrDefault(x => x.IdClient == IdentityClient);
                if(sick!=null)
                    coronamanagementContext.Sicks.Remove(sick);

                Client currentClient = coronamanagementContext.Clients.SingleOrDefault(x => x.IdentityClient == IdentityClient);
                coronamanagementContext.Clients.Remove(currentClient);
                coronamanagementContext.SaveChanges();
                return true;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool UpdateClient(int id, Client client)
        {
            try
            {
                Client currentClient = coronamanagementContext.Clients.SingleOrDefault(x => x.Id == id);
                coronamanagementContext.Entry(currentClient).CurrentValues.SetValues(client);
                coronamanagementContext.SaveChanges();
                return true;
            }

            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int CountUnvaccinated()
        {

            var c = coronamanagementContext.Clients
                .Where(g => !coronamanagementContext.Vaccinations
                .Select(b => b.IdClient)
                .Contains(g.IdentityClient));
            return c.Count();


        }
    }
}
