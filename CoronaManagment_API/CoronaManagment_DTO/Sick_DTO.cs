using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaManagment_DTO
{
    public class Sick_DTO
    {
        public int Id { get; set; }
        public string IdClient { get; set; }
        public DateTime DatePositive { get; set; }
        public DateTime DateRecovery { get; set; }
    }
}
