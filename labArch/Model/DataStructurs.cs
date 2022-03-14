using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labArch
{
    public enum SEX { MALE, FEMALE, ERROR }
    public struct DriverData
    {
        public int LicenseNumber { get; set; }
        public string FullName { get; set; }
        public string Adress { get; set; }
        public int Age { get; set; }
        public SEX Sex { get; set; }
    }
    public struct CarData
    {
        public int LicensePlate { get; set; }
        public int EngineNumber { get; set; }
        public int ColorCode { get; set; }
        public int LicenseNumber { get; set; }
    }
    public struct ReportData
    {
       public DateTime ReportDate { get; set; }
        public string ReportText { get; set; }
        public bool ReportResult { get; set; }
        public int IdToken { get; set; }
        public int LicensePlate { get; set; }
    }
}
