using System;
using System.Collections.Generic;

#nullable disable

namespace CoronaManagment_DL.Models
{
    public partial class Client
    {
        public Client()
        {
            Vaccinations = new HashSet<Vaccination>();
        }


        public string IdentityClient { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }

        public virtual Sick Sick { get; set; }
        public virtual ICollection<Vaccination> Vaccinations { get; set; }
    }
}
