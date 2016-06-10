using ServerFacades.Facades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerFacades.Factory
{
    public interface IFacadeFactory
    {
        IDriverFacade DriverFacade();

        ITeamFacade TeamFacade();
    }
}
