using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labArch
{
   public interface IRegistrationView:IView
    {
        event Action Registration;
        int Token { get; }
        string Password { get; }
        string RePassword { get; }
        string FullName { get; }
        string Rank { get; }
        string Position { get; }
    }
}
