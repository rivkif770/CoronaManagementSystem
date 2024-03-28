using CoronaManagment_DL.Models;
using CoronaManagment_DTO;
using System.Collections.Generic;

namespace CorornaManagment_BL
{
    public interface ISick_BL
    {
        Sick_DTO GetSick(string identityClient);
        public bool AddSick(Sick_DTO newSick);
        public int[] CountSick();

    }
}