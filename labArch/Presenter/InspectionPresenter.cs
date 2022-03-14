using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labArch
{
   public class InspectionPresenter:IPresenter
    {
        private readonly IInspectionView _insectionForm;
        private readonly ICarsManager _carsDataTable;
        private readonly IDriversManager _driversDataTable;
        private Policeman _policeman;
        private Action _UpdateCarsTable;
        private Action _UpdateDriversTable;
        public InspectionPresenter(IInspectionView form, ICarsManager cars, IDriversManager drivers,Policeman policeman)
        {
            _insectionForm = form;
            _carsDataTable = cars;
            _driversDataTable = drivers;
            _policeman = policeman;
            _insectionForm.InsertDriver += () => InsertDriver(_insectionForm.DriverData);
            _insectionForm.InsertCar += () => InsertCar(_insectionForm.CarData);
            _insectionForm.EraseDriver += () => EraseDriver(_insectionForm.ChosenDriverId);
            _insectionForm.EraseCar += () => EraseCar(_insectionForm.ChosenCarId);
            _insectionForm.UpdateDriver += () => UpdateDriver(_insectionForm.ChosenDriverId, _insectionForm.DriverData);
            _insectionForm.UpdateCar += () =>  UpdateCar(_insectionForm.ChosenCarId, _insectionForm.CarData);
            _insectionForm.SelectDriver += () => SelectDriver(_insectionForm.DriverData);
            _insectionForm.SelectCar +=  () => SelectCar(_insectionForm.CarData);
            _insectionForm.SelectDriverByCar += () => SelectDriverByCar(_insectionForm.ChosenCarId);
            _insectionForm.SelectCarsByDriver += () => SelectCarsByDriver(_insectionForm.ChosenDriverId);
            _insectionForm.Report += Report;
            _insectionForm.InspectionsList += InspectionListShow;
            _UpdateCarsTable = () => _insectionForm.UpdateCarsTable(_carsDataTable.GetCarsTable());
            _UpdateDriversTable = () => _insectionForm.UpdateDriversTable(_driversDataTable.GetDriversTable());
            _UpdateCarsTable();
            _UpdateDriversTable();
        }
        private void SelectCarsByDriver(int chosenDriverId)
        {
            Action UpdateCarTable = () => _insectionForm.UpdateCarsTable(_carsDataTable.SelectCarsByDriver(chosenDriverId));
            makeChangeInDataBase(chosenDriverId<0, delegate { }, UpdateCarTable, "Выберите водителя");
        }
        private void SelectDriverByCar(int chosenCarId)
        {
            Action UpdateDriverTable = () => _insectionForm.UpdateDriversTable(_driversDataTable.SelectDriverByCar(chosenCarId));
            makeChangeInDataBase(chosenCarId < 0, delegate { }, UpdateDriverTable, "Выберите машину");
        }
        private void SelectCar(CarData carData)
        {
            Action UpdateCarTable = () => _insectionForm.UpdateCarsTable(_carsDataTable.SelectCar(carData));
            makeChangeInDataBase(HasNoFilled(carData), delegate { }, UpdateCarTable, "Заполните поля");
        }
        private void SelectDriver(DriverData driverData)
        {
            Action UpdateDriverTable = () => _insectionForm.UpdateDriversTable(_driversDataTable.SelectDriver(driverData));
            makeChangeInDataBase(HasNoFilled(driverData), delegate { }, UpdateDriverTable, "Заполните поля");
        }
        private void UpdateCar(int chosenCarId, CarData carData)
        {
            Action UpdateCar = () => _carsDataTable.UpdateCar(chosenCarId, carData);
            makeChangeInDataBase((chosenCarId < 0 || HasNoFilled(carData)), UpdateCar, _UpdateCarsTable, "Заполните поля или выберите машину");
        }

        private void UpdateDriver(int chosenDriverId, DriverData driverData)
        {
            Action UpdateDriver = () => _driversDataTable.UpdateDriver(chosenDriverId, driverData);
            makeChangeInDataBase((chosenDriverId < 0 || HasNoFilled(driverData)), UpdateDriver, _UpdateDriversTable, "Заполните поля или выберите водителя");
        }

        private void EraseCar(int chosenCarId)
        {
            Action EraseCar = () => _carsDataTable.EraseCar(chosenCarId);
            makeChangeInDataBase(chosenCarId < 0, EraseCar, _UpdateCarsTable, "Выберите машину");
        }

        private void EraseDriver(int chosenDriverId)
        {
            Action EraseDriver = () => _driversDataTable.EraseDriver(chosenDriverId);
            makeChangeInDataBase(chosenDriverId < 0, EraseDriver, _UpdateDriversTable, "Выберите водителя");
        }

        private void InsertCar(CarData carData)
        {
            Action InsertCar = () => _carsDataTable.InsertCar(carData);
            makeChangeInDataBase(HasSkips(carData), InsertCar, _UpdateCarsTable, "Заполните все поля");
        }
        private void InsertDriver(DriverData driverData)
        {
            Action InsertDriver = () => _driversDataTable.InsertDriver(driverData);
            makeChangeInDataBase(HasSkips(driverData), InsertDriver, _UpdateDriversTable, "Заполните все поля");
        }
        private void Report()
        {
            ReportPresenter report = new ReportPresenter(new ReportForm(), new ReportMapper("PoliceDB"), _policeman.IdToken, _insectionForm.ChosenCarId);
            report.Run();
        }
        private void InspectionListShow()
        {
            InspectionsListPresenter presenter = new InspectionsListPresenter(new InspectionListModel("PoliceDb"), new InspectionList(), _policeman);
            presenter.Run();
        }
        private void makeChangeInDataBase(bool hasError, Action intoractToDataBase, Action updateFormTable, string errorMessage)
        {
            try
            {
                if (hasError)
                {
                    throw new Exception(errorMessage);
                }
                intoractToDataBase();
                updateFormTable();
            }
            catch (Exception ex)
            {
                _insectionForm.ShowError(ex.Message);
            }
        }
        private bool HasSkips(CarData data)
        {
            return data.LicenseNumber <= 0 || data.LicensePlate <= 0 || data.EngineNumber <= 0 || data.ColorCode <= 0;
        }
        private bool HasSkips(DriverData data)
        {
            return String.IsNullOrEmpty(data.FullName)||data.Sex==SEX.ERROR||String.IsNullOrEmpty(data.Adress)||data.LicenseNumber<=0||data.Age<=18;
        }
        private bool HasNoFilled(DriverData data)
        {
            return String.IsNullOrEmpty(data.FullName)&&data.Sex == SEX.ERROR && String.IsNullOrEmpty(data.Adress) && data.LicenseNumber <= 0 && data.Age <= 18;
        }
        private bool HasNoFilled(CarData data)
        {
            return data.LicenseNumber <= 0 && data.LicensePlate <= 0 && data.EngineNumber <= 0 && data.ColorCode <= 0;
        }
        public void Run()
        {
            _insectionForm.Show();
        }
    }
}
