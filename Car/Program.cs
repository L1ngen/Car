using System;

class Car
{

    public static string Brand { get; set; }
    public static string Model { get; set; }
    public static int Year { get; set; }

    public Car(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    // Talk about car
    public static void TalkAboutCar()
    { 
    Console.WriteLine("You have a " + Brand + " " + Model + " from " + Year + "!");
    }
}



class Program
{
    static void Main()
    {
        // Make new car
        Car mrapansCar = new Car("Skoda", "Octavia", 2000); 

        // Tell what car we made
        Car.TalkAboutCar();
    }
}
