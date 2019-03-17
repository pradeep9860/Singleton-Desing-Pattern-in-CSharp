using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingletonDesignPatternDemo.SingletonClasses
{
    public sealed class Logger 
    {
      /* 
      * ensures that only one instance of the object is created 
      */
        private static readonly Lazy<Logger> instance = new Lazy<Logger>(() => new Logger());

        /*
      * public property is used to return only one instance of the class
      * leveraging on the private property
      */
        public static Logger Instance
        {
            get
            {
                //Eager initialization for thread safety
                //if (instance == null)
                //    instance = new ApplicationConfig();
                return instance.Value;
            }
        }

        /*
      * Private constructor ensures that object is not
      * instantiated other than with in the class itself
      */
        private Logger()
        {  
        }


        /*
    * Public method which can be invoked through the singleton instance to log to file
    */
        public void Log(string message)
        {
            // Create a writer and open the file:

            var logFileWithPath = "C:\\logs\\"  + "log-" + DateTime.Now.Date.ToString("yyyy-MM-dd") + ".txt";

            var log = !File.Exists(logFileWithPath) ? new StreamWriter(logFileWithPath) : File.AppendText(logFileWithPath);

            // Write to the file:
            log.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:m:ss") + " : " + message);

            // Close the stream:
            log.Close(); 
        }
    }
}
