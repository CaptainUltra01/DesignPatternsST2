using System;

/// <summary>
/// Клас Target
/// </summary>
class Employee
{
    protected string _employeeName;
    protected double _salary;
    protected string _tool;
    protected int _id;

    // Конструктор
    public Employee(string employeeName)
    {
        this._employeeName = employeeName;
    }

    public virtual void Display()
    {
    }
}

/// <summary>
/// Клас Adapter
/// </summary>
class EmployeeAdapter : Employee
{
    private EmployeeDataStorage _employeeDataStorage;


    // Конструктор
    public EmployeeAdapter(string name)
        : base(name)
    { 
    }

    public override void Display()
    {
        // Това, което ще се адаптира
        _employeeDataStorage = new EmployeeDataStorage();

        _id = _employeeDataStorage.GetID(_employeeName);
        _salary = _employeeDataStorage.GetSalary(_employeeName);
        _tool = _employeeDataStorage.GetTool(_employeeName);


        Console.WriteLine("Заплата в размер от " + _salary + " лв. беше преведена на " + _employeeName);

    }
}

/// <summary>
/// Клас Adaptee
/// </summary>
class EmployeeDataStorage
{
    // Връща стойност на Id
    public int GetID(string employee)
    {
        switch (employee)
        {
            case "Иван Иванов": return 101;
            case "Георги Георгиев": return 302;
            case "Митан Иванков": return 403;
            default: return 0;
        }
    }

    // Връща стойност на инструмент
    public string GetTool(string employee)
    {
        switch (employee)
        {
            case "Иван Иванов": return "Водоструйка";
            case "Георги Георгиев": return "Метла";
            case "Митан Иванков": return "Прахосмукачка";
            default: return "невалидно име";
        }
    }


    // Връща стойност на заплата
    public double GetSalary(string employee)
    {
        switch (employee)
        {
            case "Иван Иванов": return 1003.24;
            case "Георги Георгиев": return 503.1;
            case "Митан Иванков": return 864.51;
            default: return 0d;
        }
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

        // Създаване на адаптирани служители
        Employee emp1 = new EmployeeAdapter("Иван Иванов");
        emp1.Display();

        Employee emp2 = new EmployeeAdapter("Георги Георгиев");
        emp2.Display();

        Employee emp3 = new EmployeeAdapter("Митан Иванков");
        emp3.Display();
    }
}
