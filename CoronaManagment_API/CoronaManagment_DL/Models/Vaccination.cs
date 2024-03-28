using System;
using System.Collections.Generic;

#nullable disable

namespace CoronaManagment_DL.Models
{
    public partial class Vaccination
    {
        public int Id { get; set; }
        public string IdClient { get; set; }
        public DateTime DateVaccin { get; set; }
        public string NameCompany { get; set; }

        public virtual Client IdClientNavigation { get; set; }
    }
}
