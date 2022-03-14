using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labArch
{
   public interface ILoginView:IView
    {
        int Token { get; }
        string Password { get; }
        event Action Login;
        event Action Registration;
    }
}
