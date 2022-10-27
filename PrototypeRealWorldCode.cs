using System;
using System.Collections.Generic;


/// <summary>
/// Абстрактен клас Prototype
/// </summary>
abstract class Vehicle
{
    public abstract Vehicle Clone();
}

/// <summary>
/// Клас ConcretePrototype1
/// </summary>
class Bike : Vehicle
{
    protected int _seats;
    protected int _wheels;
    protected string _fuel;

    // Конструктор
    public Bike(int seats, int wheels, string fuel)
    {
        _seats = seats;
        _wheels = wheels;
        _fuel = fuel;
    }

    // Създаване на копие
    public override Vehicle Clone()
    {
        Console.WriteLine("Клониране на мотор с {0} места, {1} колела, тип гориво: {2} ", _seats, _wheels, _fuel);
        return this.MemberwiseClone() as Bike;
    }
}

/// <summary>
/// Клас ConcretePrototype2
/// </summary>
class Car : Vehicle
{
    private int _seats;
    private int _wheels;
    private string _fuel;

    // Конструктор
    public Car(int seats, int wheels, string fuel)
    {
        _seats = seats;
        _wheels = wheels;
        _fuel = fuel;
    }

    // Създаване на копие
    public override Vehicle Clone()
    {
        Console.WriteLine("Клониране на кола с {0} места, {1} колела, тип гориво: {2} ", _seats, _wheels, _fuel);
        return this.MemberwiseClone() as Car;
    }
}

/// <summary>
/// Мениджър на прототипи
/// </summary>
class VehicleManager
{
    // Масив
    private Dictionary<string, Vehicle> _vehicles = new Dictionary<string, Vehicle>();

    // Обхождане на масив

    public Vehicle this[string key]
    {
        get { return _vehicles[key]; }
        set { _vehicles.Add(key, value); }
    }
}


/// <summary>
/// Main клас
/// </summary>
class MainApp
{
    /// <summary>
    /// Main метод
    /// </summary>
    static void Main()
    {
        VehicleManager vehicleManager = new VehicleManager();
        // Предварително съществуващи превозни средства
        vehicleManager["Seat Leon 1.8T"] = new Car(5, 4, "Бензин");
        vehicleManager["BMW S1000RR"] = new Car(2, 2, "Бензин");


        // Добавяне на нови превозни средства
        vehicleManager["Seat Leon 1.9TDI"] = new Car(5, 4, "Дизел");
        vehicleManager["Yamaha YZF-R1M"] = new Bike(1, 2, "Бензин");
        vehicleManager["BMW Isetta"] = new Car(1, 3, "Газ");

        // Потребителят клонира избрани превозни средства
        Bike bike1 = vehicleManager["BMW S1000RR"].Clone() as Bike;
        Bike bike2 = vehicleManager["Yamaha YZF-R1M"].Clone() as Bike;
        Car car1 = vehicleManager["Seat Leon 1.9TDI"].Clone() as Car;
        Car car2 = vehicleManager["BMW Isetta"].Clone() as Car;

        Console.ReadKey();
    }
}
