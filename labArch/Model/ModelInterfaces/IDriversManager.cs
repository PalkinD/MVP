using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace labArch
{
   public interface IDriversManager
    {
        DataSet GetDriversTable();
        void InsertDriver(DriverData data);
        void EraseDriver(int licenseNumber);
        void UpdateDriver(int licenseNumber,DriverData data);
        DataSet SelectDriver(DriverData data);
        DataSet SelectDriverByCar(int licensePlate);
    }
}
