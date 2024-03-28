using CoronaManagment_DL.Models;
using System.Collections.Generic;

namespace CoronaManagment_DL
{
    public interface ISick_DL
    {
        Sick GetSick(string identityClient);
        public bool AddSick(Sick sick);
        public int[] CountSick();

    }
}