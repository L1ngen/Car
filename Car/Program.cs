using System;

class Car
{

    public string Brand { private get; private set; }
    public string Model { private get; private set; }

    public Car(string brand, string model)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    // Talk about car
    public static void TalkAboutCar()
    { 
    Console.WriteLine("You have a " + Brand + " " + Model + " from " + Year;
    }
}



class Program
{
    static void Main(string[] args)
    {
        // Make new car
        Car mrapansCar = new Car(Skoda, "Octavia", 2000); 

        // Tell what care we made
        Car.TalkAboutCar()
    }
}
