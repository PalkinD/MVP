using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labArch
{
    public partial class ReportForm : Form,IReportView
    {
       public event Action Report;
        public string ReportText { get => reportTextBox.Text; }
        public DateTime ReportDate { get => dateTimePicker.Value; }
        public bool ReportResult
        {
            get
            {
                if (inspectionTrue.Checked)
                {
                    return true;
                }else if (inspectionFalse.Checked)
                {
                    return false;
                }
                throw new Exception("Не выбран результат");
            }
        }
        public ReportForm()
        {
            InitializeComponent();
            reportButton.Click += (sender, args) => Invoke(Report);
        }
        public new void Show()
        {
            this.ShowDialog();
        }
        public void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }
        private void Invoke(Action invokeEvent)
        {
            if (invokeEvent != null)
            {
                invokeEvent();
            }
        }
    }
}
