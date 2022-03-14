using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labArch
{
    public class ReportPresenter : IPresenter
    {
        private readonly IReportView _reportForm;
        private readonly IReportModel _dataBase;
        private int _idToken;
        private int _licensePlate;
        public ReportPresenter(IReportView view,IReportModel model, int idToken,int licensePlate)
        {
            _reportForm = view;
            _dataBase = model;
            _idToken = idToken;
            _licensePlate = licensePlate;
            _reportForm.Report += Report;
        }
        private void Report()
        {
            ReportData report = new ReportData();
            try
            {
                report.ReportDate = _reportForm.ReportDate;
                report.ReportResult = _reportForm.ReportResult;
                report.ReportText = _reportForm.ReportText;
                report.IdToken = _idToken;
                report.LicensePlate = _licensePlate;
                if (!_dataBase.IsAllowedToMakeReport(report.IdToken,report.ReportDate))
                {
                    throw new Exception("Полицейский сделал больче чем 10 осмотров");
                }
                _dataBase.Insert(report);
            }catch(Exception ex)
            {
                _reportForm.ShowError(ex.Message);
            }
        }
        public void Run()
        {
            _reportForm.Show();
        }
    }
}
