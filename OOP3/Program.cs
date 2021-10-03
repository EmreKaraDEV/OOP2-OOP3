using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager  housingCreditManager = new HousingCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ConsultManager consultManager = new ConsultManager();
            //consultManager.MakeConsult(personalFinanceCreditManager, new List<ILoggerService> { databaseLoggerService });
            //consultManager.MakeConsult(vehicleCreditManager, new List<ILoggerService> { fileLoggerService });
            //consultManager.MakeConsult(housingCreditManager, new List<ILoggerService> {databaseLoggerService });
            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), fileLoggerService, databaseLoggerService};
            
            consultManager.MakeConsult(new TraderCreditManager(), loggers);

            List<ICreditManager> credits = new List<ICreditManager>() { personalFinanceCreditManager, vehicleCreditManager };
            
            //consultManager.MakeCreditPreliminaryInformation(credits);
        }
    }
}
