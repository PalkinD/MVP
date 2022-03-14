using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labArch
{
   public interface IReportView:IView
    {
       event Action Report;
       string ReportText { get; }     
       DateTime ReportDate { get; }
        bool ReportResult { get; }
    }
}
