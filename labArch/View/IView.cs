using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labArch
{
    public interface IView
    {
        void Show();
        void Close();
        void ShowError(string errorMessage);
    }
}
