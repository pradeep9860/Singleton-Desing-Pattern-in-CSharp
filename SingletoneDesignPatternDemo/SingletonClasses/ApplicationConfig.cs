using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPatternDemo.SingletonClasses
{
    /*
    *  Sealed restricts the inheritance
    */
    public sealed class ApplicationConfig
    { 
        //Lazy initialization
        /*
        * Private property initilized with null
        * ensures that only one instance of the object is created
        * based on the null condition
        */
        private static readonly Lazy<ApplicationConfig> instance = new Lazy<ApplicationConfig>(()=> new ApplicationConfig());


        //adding counter variable to see how many times initialize our singleton class
        private int count = 0;

        /*
       * public property is used to return only one instance of the class
       * leveraging on the private property
       */
        public static ApplicationConfig Instance
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
        private ApplicationConfig()
        {
            ConfigValue = 1;
            count++;
            Console.WriteLine($"ApplicationConfig object is instantiated {count} times.");
        }
         
        private int ConfigValue { get; set; }

        /*
       * Public method which can be invoked through the singleton instance to print current config value
       */
        public void PrintConfigValue(string key)
        {
            Console.WriteLine($"Config Value from {key}: {ConfigValue}");
        }

        /*
      * Public method which can be invoked through the singleton instance to set new value to config property
      */
        public void SetConfigValue(int newValue)
        {
            this.ConfigValue = newValue;
        }
    }
}
