using System;

/// <summary>
/// Абстрактен клас Prototype
/// </summary>
abstract class Prototype
{
    private string _id;

    // Конструктор
    public Prototype(string id)
    {
        this._id = id;
    }

    // Взима ID
    public string Id
    {
        get { return _id; }
    }

    public abstract Prototype Clone();
}

/// <summary>
/// Клас ConcretePrototype2, наследяващ Prototype
/// </summary>
class ConcretePrototype1 : Prototype
{
    // Конструктор
    public ConcretePrototype1(string id)
        : base(id)
    {
    }

    // Връща копие
    public override Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone();
    }
}

/// <summary>
/// Клас ConcretePrototype2, наследяващ Prototype
/// </summary>
class ConcretePrototype2 : Prototype
{
    // Конструктор
    public ConcretePrototype2(string id)
        : base(id)
    {
    }

    // Връща копие
    public override Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone();
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
        // Създават се 2 инстанции и всяка се клонира

        ConcretePrototype1 p1 = new ConcretePrototype1("I");
        ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
        Console.WriteLine("Клониран: {0}", c1.Id);

        ConcretePrototype2 p2 = new ConcretePrototype2("II");
        ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
        Console.WriteLine("Клониран: {0}", c2.Id);

        Console.ReadKey();
    }
}