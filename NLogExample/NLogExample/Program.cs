using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace NLogExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = 0;
                int result = 5 / num;

            }
            catch(DivideByZeroException ex)
            {
                // Logging Exception UsandoNLog
                Logger logger = LogManager.GetLogger("databaseLogger");

                logger.Error(ex, "Error");
            }

            // Reportar lo que se hizo con el Method Main
            Console.WriteLine("Ahora pasaremos a la Exception Handler Logic");
            Console.ReadLine();

        }
    }
}
