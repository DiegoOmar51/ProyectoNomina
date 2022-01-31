using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using ModeloDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class NominaDBBuilder
    {
        const string DBTipo = "DBTipo";
        enum DBTipoConn { SqlServer, Postgres, Memoria }
        static NominaDB db;

        public static NominaDB Crear()
        {
            // Lee la configuración acerca de qué base usar del archivo App.config
            /*string dbtipo = ConfigurationManager.AppSettings[DBTipo];
            string conn = ConfigurationManager.ConnectionStrings[dbtipo].ConnectionString;
            
            DbContextOptions<NominaDB> contextOptions;

            switch (dbtipo)
            {
                case "SqlServer":
                    contextOptions = new DbContextOptionsBuilder<NominaDB>()
                        .UseSqlServer(conn)
                        .Options;
                    break;
                case "Postgres":
                    contextOptions = new DbContextOptionsBuilder<NominaDB>()
                        .UseNpgsql(conn)
                        .Options;
                    break;
                default: // Por defecto usa la memoria como base de datos
                    contextOptions = new DbContextOptionsBuilder<NominaDB>()
                        .UseInMemoryDatabase(conn)
                        .Options;
                    break;
            }
            
            db = new NominaDB(contextOptions);*/

            return db;
        }
    }
}
