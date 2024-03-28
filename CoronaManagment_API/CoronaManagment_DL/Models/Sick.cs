using System;
using System.Collections.Generic;

#nullable disable

namespace CoronaManagment_DL.Models
{
    public partial class Sick
    {
        public int Id { get; set; }
        public string IdClient { get; set; }
        public DateTime DatePositive { get; set; }
        public DateTime DateRecovery { get; set; }

        public virtual Client IdClientNavigation { get; set; }
    }
}
