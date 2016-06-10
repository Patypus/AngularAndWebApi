using ServerFacades.Facades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerFacades.Models;
using DataLayer.Context;

namespace ServerFacades.Facades
{
    public class DriverFacade : IDriverFacade
    {
        private readonly DataContext _context;

        public DriverFacade(DataContext context)
        {
            _context = context;
        }

        public List<DriverDto> GetAllDrivers()
        {
            throw new NotImplementedException();
        }

        public Guid AddDriver(DriverDto driverDetails)
        {
            throw new NotImplementedException();
        }
    }
}
