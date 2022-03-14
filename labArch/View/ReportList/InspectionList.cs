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
    public partial class InspectionList : Form,IInspectionsListView
    {
        public InspectionList()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            this.ShowDialog();
        }
        public void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }

        public void UpdateTable(DataSet table)
        {
            inspectionsTable.DataSource = table.Tables[0];
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
