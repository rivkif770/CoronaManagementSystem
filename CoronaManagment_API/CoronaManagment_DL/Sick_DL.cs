using CoronaManagment_DL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CoronaManagment_DL
{
    public class Sick_DL : ISick_DL
    {
        CoronaManagmentContext coronamanagementContext = new CoronaManagmentContext();

        public Sick GetSick(string identityClient)
        {
            try
            {
                var sick = coronamanagementContext.Sicks.SingleOrDefault(x => x.IdClient == identityClient);

                return sick;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddSick(Sick newSick)
        {
            try
            {
                coronamanagementContext.Sicks.Add(newSick);
                coronamanagementContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int[] CountSick()
        {
            var c = coronamanagementContext.Sicks.Where(x => x.DatePositive.Month.ToString() == (DateTime.Now.Month-1).ToString())
                .GroupBy(x => x.DatePositive.Day).Select(s => new { s.Key, Count = s.Count() }).ToList();

            int [] list = new int[30];
            foreach (var i in c)
            {
                list[i.Key-1] = i.Count;
            }
            return list;
        }
    }
}
