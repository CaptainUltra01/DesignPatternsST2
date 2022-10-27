using System;

/// <summary>
/// Класът Originator
/// </summary>
class Originator
{
    private string _state;

    public string State
    {
        get { return _state; }
        set
        {
            _state = value;
            Console.WriteLine("Състояние = " + _state);
        }
    }

    // Създава "снимка" на началното състояние
    public Memento CreateMemento()
    {
        return (new Memento(_state));
    }

    // Връща до начално състояние
    public void SetMemento(Memento memento)
    {
        Console.WriteLine("Връщане до състояние...");
        State = memento.State;
    }
}

/// <summary>
/// Класът Memento
/// </summary>
class Memento
{
    private string _state;

    // Конструктор
    public Memento(string state)
    {
        this._state = state;
    }

    // Взима или задава състояние
    public string State
    {
        get { return _state; }
    }
}

/// <summary>
/// Класът Caretaker
/// </summary>
class Caretaker
{
    private Memento _memento;

    // Взима или задава "снимка"
    public Memento Memento
    {
        set { _memento = value; }
        get { return _memento; }
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
        Originator o = new Originator();
        o.State = "Включено";

        // Съхранява вътрешно състояние
        Caretaker c = new Caretaker();
        c.Memento = o.CreateMemento();

        // Смяна на състоянието на Originator-а
        o.State = "Изключено";

        // Връща до запазено състояние
        o.SetMemento(c.Memento);

        Console.ReadKey();
    }
}
