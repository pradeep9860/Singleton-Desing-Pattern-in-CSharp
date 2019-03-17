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
        /*
        * Private property initilized with null
        * ensures that only one instance of the object is created
        * based on the null condition
        */
        private static ApplicationConfig instance = null;

        /*
       * public property is used to return only one instance of the class
       * leveraging on the private property
       */
        public static ApplicationConfig Instance
        {
            get
            {
                if (instance == null)
                    instance = new ApplicationConfig();
                return instance;
            }
        }

        /*
        * Private constructor ensures that object is not
        * instantiated other than with in the class itself
        */
        private ApplicationConfig()
        {
            ConfigValue = 1; 
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
