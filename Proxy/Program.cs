// See https://aka.ms/new-console-template for more information
// How to use above Proxy class?
using Proxy;

ICar car = new ProxyCar(new Driver(15));
car.DriveCar();
car = new ProxyCar(new Driver(25));
car.DriveCar();