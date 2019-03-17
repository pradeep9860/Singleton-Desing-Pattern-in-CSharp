# Singletone Desing Pattern in C#

Singleton Pattern belongs to Creational type pattern. As discussed in our previous video, Gang of four have defined five design patterns that belongs to creational design type category. Singleton is one among them and the rest are Factory, Abstract Factory, Builder and Prototype patterns. As the name implies, creational design type deals with object creation mechanisms. Basically, to simplify this, creational pattern explain us the creation of objects in a manner suitable to a given situation. 

Singleton design pattern is used when we need to ensure that only one object of a particular class is Instantiated. That single instance created is responsible to coordinate actions across the application. 

![alt text](https://4.bp.blogspot.com/-vXr-naNZZYc/WRcWLYXP5aI/AAAAAAAAk90/x2sksyqwKnYqZaXfRP06Pzu0tNWAlk5aQCLcB/s1600/Singleton%2BDesign%2BPattern.png)

If you look at the illustrated diagram above you will see different objects trying to invoke an object instantiated as singleton. This single instance of the object is responsible to invoke underneath methods or events.
