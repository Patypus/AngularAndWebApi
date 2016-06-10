using ServerFacades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerFacades.Facades.Interfaces
{
    public interface IDriverFacade
    {
        List<DriverDto> GetAllDrivers();

        Guid AddDriver(DriverDto driverDetails);
    }
}
