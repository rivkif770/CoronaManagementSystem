using CoronaManagment_DL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaManagment_DTO
{
    public class Vaccination_DTO
    {
        public int Id { get; set; }
        public string IdClient { get; set; }
        public DateTime DateVaccin { get; set; }
        public string NameCompany { get; set; }

      
    }
}
