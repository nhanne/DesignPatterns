using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    // Real object
    public class Car : ICar
    {
        public void DriveCar()
        {
            Console.WriteLine("Car has been driven! ");
        }
    }
    // Proxy object
    public class ProxyCar : ICar
    {
        private Driver driver;
        private ICar realCar;
        public ProxyCar(Driver driver)
        {
            this.driver = driver;
            this.realCar = new Car();
        }
        public void DriveCar()
        {
            if (driver.Age < 16)
                Console.WriteLine("Sorry, the driver is too young to drive.");
            else
                this.realCar.DriveCar();
        }
    }
    // Model
    public class Driver
    {
        public int Age { get; set; }
        public Driver(int age)
        {
            this.Age = age;
        }
    }
}
