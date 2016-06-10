using DataLayer.Context;
using ServerFacades.Facades;
using ServerFacades.Facades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerFacades.Factory
{
    public class FacadeFactory
    {
        private readonly DataContext _context;

        private IDriverFacade _driverFacade;
        private ITeamFacade _teamFacade;

        public FacadeFactory()
        {
            _context = new DataContext();
        }

        public IDriverFacade DriverFacade()
        {
            if (_driverFacade == null)
            {
                _driverFacade = new DriverFacade(_context);
            }
            return _driverFacade;
        }

        public ITeamFacade TeamFacade()
        {
            if (_teamFacade == null)
            {
                _teamFacade = new TeamFacade(_context);
            }

            return _teamFacade;
        }
    }
}
