﻿using System;

namespace Extensibility 

{

    public class DbMigrator
        
    {
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
        _logger = logger;

        }

        public void Migrate()
        {
            _logger.LogInfo("Migrating started at {0}" + DateTime.Now);
            
            _logger.LogInfo("Migrating finished at {0}" + DateTime.Now);

        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            var dbMigrator = new DbMigrator(new ConsoleLogger());

            dbMigrator.Migrate();
            
        }
    }
}
