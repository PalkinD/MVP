using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace labArch{
    public interface IInspectionView : IView
    {
        event Action Report;
        event Action InspectionsList;
        event Action InsertDriver;
        event Action InsertCar;
        event Action EraseDriver;
        event Action EraseCar;
        event Action UpdateDriver;
        event Action UpdateCar;
        event Action SelectDriver;
        event Action SelectCar;
        event Action SelectDriverByCar;
        event Action SelectCarsByDriver;
        int ChosenDriverId { get; }
        int ChosenCarId { get; }
        DriverData DriverData{ get;}
        CarData CarData { get; }
        void UpdateCarsTable(DataSet carsDataSet);
        void UpdateDriversTable(DataSet driversDataSet);
    }
}
