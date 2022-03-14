using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labArch
{
   public interface ILoginModel
    {
        Policeman Select(int idToken, string password);
    }
}
