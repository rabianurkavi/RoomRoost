using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomRoost.DataAccessLayer.Services
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new ConfigurationManager();
                // .. BUNLAR DOSYA UZANTISININ DIŞINA ÇIKMAYI TEMSİL ETMEKTEDİR.
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../ApiConsume/RoomRoost.WebApi"));
                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("SQL");
            }
        }
    }
}
