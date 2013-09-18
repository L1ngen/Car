using System;

class Car
{

    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Car(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    // Talk about car
    public void TalkAboutCar()
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
        Car LinhsCar = new Car("Koenigsegg", "CCX", 2013);

        // Tell what car we made
        mrapansCar.TalkAboutCar();
        LinhsCar.TalkAboutCar();

    }
}
