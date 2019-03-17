using SingletonDesignPatternDemo.SingletonClasses;
using System;
using System.Threading.Tasks;

namespace SingletonDesignPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Parallel invocation test for thread safety


            Parallel.Invoke(
                () => FromConfig1(),
                () => FromConfig2()
            );

            //FromConfig1();  
            //FromConfig2();

            //set log to file
            var _logger = Logger.Instance; 
            //for exception
            _logger.Log("log to file");

            //for success
            _logger.Log("yes! we did it.", Enums.LogType.Success);
            Console.ReadKey();
        }

        private static void FromConfig2()
        {
            //now we are going to get the instance to new varialble and see whats happens
            ApplicationConfig config2 = ApplicationConfig.Instance;
            config2.PrintConfigValue("config2"); // this will print the config value that is set by the config1 instance
        }

        private static void FromConfig1()
        {
            //get the instance of an singletone class and set the config value

            ApplicationConfig config1 = ApplicationConfig.Instance;
            config1.SetConfigValue(8);
            config1.PrintConfigValue("config1");
        }
    }
}
