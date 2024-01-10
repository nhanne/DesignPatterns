using Decorator;

var basicBike = new AluminiumBike();
BikeAccessories upgraded = new SportPackage(basicBike);
upgraded = new SecurityPackage(upgraded);
Console.WriteLine($"Bike: '{upgraded.GetDetails()}' Cost:{ upgraded.GetPrice()}");