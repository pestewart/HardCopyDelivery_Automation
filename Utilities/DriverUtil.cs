using AutomationTools.Selectors;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCopyDelivery.UI.Tests.Utilities
{
    public class DriverUtil
    {
        public static DriverType DetermineBrowserType()
        {
            var driverName = ConfigurationManager.AppSettings["Browser"];
            DriverType wantedDriver = DriverType.None;

            switch (driverName)
            {
                case "Chrome":
                    wantedDriver = DriverType.Chrome;
                    break;
                case "IE11":
                    wantedDriver = DriverType.InternetExplorer;
                    break;
                case "Edge":
                    wantedDriver = DriverType.Edge;
                    break;
                case "Firefox":
                    wantedDriver = DriverType.Firefox;
                    break;
                default:
                    wantedDriver = DriverType.None;
                    break;
            }

            return wantedDriver;
        }

    }
}
