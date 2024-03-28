using CoronaManagment_DL.Models;
using System;
using System.Collections.Generic;

namespace CoronaManagment_DTO
{
    public class Client_DTO
    {
        public int Id { get; set; }
        public string IdentityClient { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Img { get; set; }

       
    }
}
