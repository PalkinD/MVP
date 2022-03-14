using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labArch
{
   public interface IReportModel
    {
        void Insert(ReportData report);
        bool IsAllowedToMakeReport(int idToken, DateTime date);
    }
}
