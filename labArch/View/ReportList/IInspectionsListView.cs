using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace labArch
{
    public interface IInspectionsListView:IView
    {
        void UpdateTable(DataSet table);
    }
}
