using System;
using log4net;
using System.Threading;
using System.Text;

// Code to help me remember how to set up my logging in C#

namespace Log4NetDemo
{
    class Program
    {

        //Declare an instance for log4net
        private static readonly ILog Log = 
              LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            ImplementLoggingFuntion();
            String testmsg = "Sent from Main()";
            logTest(testmsg);
            Console.WriteLine("Press any key to close the application");
            Console.ReadKey();
        }

        private static void ImplementLoggingFuntion()
        {
            /* We have 5 levels of log message. Let's test all.
             *  FATAL
                ERROR
                WARN
                INFO
                DEBUG
             */
            var secs = 1;
            Log.Fatal("Start log FATAL...");
            Console.WriteLine("Start log FATAL...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Error("Start log ERROR...");
            Console.WriteLine("Start log ERROR...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Warn("Start log WARN...");
            Console.WriteLine("Start log WARN...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Info("Start log INFO...");
            Console.WriteLine("Start log INFO...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Debug("Start log DEBUG...");
            Console.WriteLine("Start log DEBUG...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

        }

        private static void logTest(String logmsg)
        {
            String input = logmsg;
            Log.Info("Logging from function logTest()..." + input);
            //return output.ToArray();
        }
    }
}
