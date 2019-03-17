using SingletoneDesignPatternDemo.SingletoneClasses;
using System;

namespace SingletoneDesignPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //get the instance of an singletone class and set the config value

            ApplicationConfig config1 = ApplicationConfig.Instance;
            config1.SetConfigValue(8);
            config1.PrintConfigValue("config1");


            //now we are going to get the instance to new varialble and see whats happens
            ApplicationConfig config2 = ApplicationConfig.Instance;
            config2.PrintConfigValue("config2"); // this will print the config value that is set by the config1 instance


            Console.ReadKey();
        }
    }
}
