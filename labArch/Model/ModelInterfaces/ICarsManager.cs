using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace labArch
{
    public interface ICarsManager
    {
        DataSet GetCarsTable();
        void InsertCar(CarData data);
        void EraseCar(int licensePlate);
        void UpdateCar(int licensePlate, CarData data);
        DataSet SelectCar(CarData data);
        DataSet SelectCarsByDriver(int licenseNumber);
    }
}
