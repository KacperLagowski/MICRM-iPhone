using SIML.CRMInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MICRM_iPhone
{
    class ConnectionStringProvider : IConnectionStringProvider
    {
        public string ConnectionString()
        {
            return @"DATA SOURCE=vmSQL02.nero.systems;Initial Catalog=CRM;User Id=Android;Password=Android1;";
        }

        public string ConnectionString(ConnectionStringProviderEnum type)
        {
            return ConnectionString();
        }
    }
}

