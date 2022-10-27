using System;

/// <summary>
/// Клас Target
/// </summary>
class Target
{
    public virtual void Request()
    {
        Console.WriteLine("Извикан е Target Request()");
    }
}

/// <summary>
/// Клас Adapter, наследяващ Target
/// </summary>
class Adapter : Target
{
    private Adaptee _adaptee = new Adaptee();

    public override void Request()
    {
        // Възможно е да върши някаква работа
        //  и след това да извиква SpecificRequest метода
        _adaptee.SpecificRequest();
    }
}

/// <summary>
/// Клас Adaptee, който ще бъде адаптиран
/// </summary>
class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Извикан е SpecificRequest()");
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
        // Създаване на адаптер и подаване на заявка
        Target target = new Adapter();
        target.Request();

        Console.ReadKey();
    }
}
