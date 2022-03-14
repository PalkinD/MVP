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
    public partial class InspectionForm : Form,IInspectionView
    {
        public event Action InsertDriver;
        public event Action InspectionsList;
        public event Action Report;
        public event Action InsertCar;
        public event Action EraseDriver;
        public event Action EraseCar;
        public event Action UpdateDriver;
        public event Action UpdateCar;
        public event Action SelectDriver;
        public event Action SelectCar;
        public event Action SelectDriverByCar;
        public event Action SelectCarsByDriver;
        public int ChosenDriverId { 
            get{
                int licensePlate;
                try
                {
                    licensePlate = (int)driversGridView.SelectedRows[0].Cells["license_number"].Value;
                }catch(Exception ex)
                {
                    licensePlate = -1;
                }
                return licensePlate;
            }
        }
        public int ChosenCarId {
            get{
                int licenseNumber;
                try
                {
                    licenseNumber = (int)carsGridView.SelectedRows[0].Cells["license_plate"].Value;
                }
                catch(Exception ex)
                {
                    licenseNumber = -1;
                }
                return licenseNumber;
            } 
        }
        public DriverData DriverData { 
            get{
                DriverData data = new DriverData();
                try
                {
                    data.LicenseNumber = Convert.ToInt32(licenseNumberTextBox.Text);
                }
                catch (Exception ex)
                {
                    data.LicenseNumber = -1;

                }
                data.FullName = fullNameTextBox.Text;
                data.Adress = adressTextBox.Text;
                data.Age =(int)ageNumeric.Value;
                if (maleRadioButton.Checked)
                {
                    data.Sex = SEX.MALE;
                }else if (femaleRadioButton.Checked)
                {
                    data.Sex = SEX.FEMALE;
                }
                else
                {
                    data.Sex = SEX.ERROR;
                }
                return data;
            }
        }
        public CarData CarData
        {
            get
            {
                CarData data = new CarData();
                data.LicenseNumber = ChosenDriverId;
                try
                {
                    data.LicensePlate = Convert.ToInt32(licensePlateTextBox.Text);
                }catch(Exception ex)
                {
                    data.LicensePlate = -1;
                }
                try
                {
                    data.EngineNumber = Convert.ToInt32(engineNumberTextBox.Text);
                }catch(Exception ex)
                {
                    data.EngineNumber = -1;
                }
                data.ColorCode = (int)colorCodeNumeric.Value;
                return data;
            }
        }
        public InspectionForm()
        {
            InitializeComponent();
            driverInsertButton.Click += (sender, args) => Invoke(InsertDriver);
            carInsertButton.Click += (sender, args) => Invoke(InsertCar);
            driverEraseButton.Click += (sender, args) => Invoke(EraseDriver);
            carEraseButton.Click += (sender, args) => Invoke(EraseCar);
            driverUpdateButton.Click += (sender, args) => Invoke(UpdateDriver);
            carUpdateButton.Click += (sender, args) => Invoke(UpdateCar);
            driverSelectButton.Click += (sender, args) => Invoke(SelectDriver);
            carSelectButton.Click += (sender, args) => Invoke(SelectCar);
            driverSelectByCarButton.Click += (sender, args) => Invoke(SelectDriverByCar);
            carSelectByDriverButton.Click += (sender, args) => Invoke(SelectCarsByDriver);
            inspectButton.Click += (sender, args) => Invoke(Report);
            showInspectionsButton.Click += (sender, args) => Invoke(InspectionsList);
        }
        public void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }
        public new void Show()
        {
            this.ShowDialog();
        }
        private void Invoke(Action invokeEvent)
        {
            if (invokeEvent != null)
            {
                invokeEvent();
            }
        }

        public void UpdateCarsTable(DataSet carsDataSet)
        {
            carsGridView.DataSource = carsDataSet.Tables[0];
        }

        public void UpdateDriversTable(DataSet driversDataSet)
        {
            driversGridView.DataSource = driversDataSet.Tables[0];
        }
    }
}
