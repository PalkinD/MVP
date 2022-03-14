using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labArch
{
   public interface IRegistrationModel
    {
        void Insert(Policeman policeman, string password);
    }
}
