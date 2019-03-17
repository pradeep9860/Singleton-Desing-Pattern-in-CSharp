# Singletone Desing Pattern in C#

Singleton Pattern belongs to Creational type pattern. Gang of four(GOF) have defined five design patterns that belongs to creational design type category. Singleton is one among them and the rest are Factory, Abstract Factory, Builder and Prototype patterns. As the name implies, creational design type deals with object creation mechanisms. Basically, to simplify this, creational pattern explain us the creation of objects in a manner suitable to a given situation. 

Singleton design pattern is used when we need to ensure that only one object of a particular class is Instantiated. That single instance created is responsible to coordinate actions across the application. 

![alt text](https://4.bp.blogspot.com/-vXr-naNZZYc/WRcWLYXP5aI/AAAAAAAAk90/x2sksyqwKnYqZaXfRP06Pzu0tNWAlk5aQCLcB/s1600/Singleton%2BDesign%2BPattern.png)

If you look at the illustrated diagram above you will see different objects trying to invoke an object instantiated as singleton. This single instance of the object is responsible to invoke underneath methods or events.
## Advantages and Guidelines for Singleton implementation

Concurrent access to the resource is well managed by singleton design pattern.

As part of the Implementation guidelines we need to ensure that only one instance of the class exists by declaring all constructors of the class to be private.  Also, to control the singleton access we need to provide a static property that returns a single instance of the object.

## Implementation of Singletone Class 

### Singletone Class
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

### Basic Usases

          //get the instance of an singletone class and set the config value

            ApplicationConfig config1 = ApplicationConfig.Instance;
            config1.SetConfigValue(8);
            config1.PrintConfigValue("config1");


            //now we are going to get the instance to new varialble and see whats happens
            ApplicationConfig config2 = ApplicationConfig.Instance;
            config2.PrintConfigValue("config2"); // this will print the config value that is set by the config1 instance




