using System;

/// <summary>
/// Клас Originator
/// </summary>
class BurgerIngredients
{
    private bool _starterBurger;
    private bool _tomato;
    private bool _cucumber;
    private bool _cedar;
    private bool _lettuce;

    // Взима или задава стойност на _starterBurger
    public bool StarterBurger
    {
        get { return _starterBurger; }
        set
        {
            _starterBurger = value;
            Console.WriteLine("Начални съставки:  " + _starterBurger);
        }
    }

    // Взима или задава стойност на _tomato
    public bool Tomato
    {
        get { return _tomato; }
        set
        {
            _tomato = value;
            Console.WriteLine("Домати: " + _tomato);
        }
    }

    // Взима или задава стойност на _cucumber
    public bool Cucumber
    {
        get { return _cucumber; }
        set
        {
            _cucumber = value;
            Console.WriteLine("Краставици: " + _cucumber);
        }
    }

    // Взима или задава стойност на _cedar
    public bool Cedar
    {
        get { return _cedar; }
        set
        {
            _cedar = value;
            Console.WriteLine("Чедър: " + _cedar);
        }
    }

    // Взима или задава стойност на _lettuce
    public bool Lettuce
    {
        get { return _lettuce; }
        set
        {
            _lettuce = value;
            Console.WriteLine("Маруля: " + _lettuce);
        }
    }


    // Съхранява "снимка"
    public Memento SaveMemento()
    {
        Console.WriteLine("--- Запазва се състояние ---\n");
        return new Memento(_starterBurger, _tomato, _cucumber, _cedar, _lettuce);
    }

    // Връща "снимка"
    public void RestoreMemento(Memento memento)
    {
        Console.WriteLine("\n--- Връща се състояние ---");
        this.StarterBurger = memento.StarterBurger;
        this.Tomato = memento.Tomato;
        this.Cucumber = memento.Cucumber;
        this.Cedar = memento.Cedar;
        this.Lettuce = memento.Lettuce;
        Console.WriteLine();
    }
}

/// <summary>
/// Класът Memento
/// </summary>
class Memento
{
    private bool _starterBurger;
    private bool _tomato;
    private bool _cucumber;
    private bool _cedar;
    private bool _lettuce;

    // Конструктор
    public Memento(bool starterBurger, bool tomato, bool cucumber, bool cedar, bool lettuce)
    {
        this._starterBurger = starterBurger;
        this._tomato = tomato;
        this._cucumber = cucumber;
        this._cedar = cedar;
        this._lettuce = lettuce;
    }

    // Взима или задава стойност на _starterBurger
    public bool StarterBurger
    {
        get { return _starterBurger; }
        set { _starterBurger = value; }
    }

    // Взима или задава стойност на _tomato
    public bool Tomato
    {
        get { return _tomato; }
        set { _tomato = value; }
    }

    // Взима или задава стойност на _cucumber
    public bool Cucumber
    {
        get { return _cucumber; }
        set { _cucumber = value; }
    }

    // Взима или задава стойност на _cedar
    public bool Cedar
    {
        get { return _cedar; }
        set { _cedar = value; }
    }

    // Взима или задава стойност на _lettuce
    public bool Lettuce
    {
        get { return _lettuce; }
        set { _lettuce = value; }
    }
}

/// <summary>
/// Класът Caretaker
/// </summary>
class IngredientsMemento
{
    private Memento _memento;

    // Пропърти
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
        IngredientsMemento ingMem = new IngredientsMemento();

        BurgerIngredients burgerIngredients = new BurgerIngredients();
        burgerIngredients.StarterBurger = true;
        // Запазва състояние
        ingMem.Memento = burgerIngredients.SaveMemento();

        burgerIngredients.Tomato = true;
        // Запазва състояние
        ingMem.Memento = burgerIngredients.SaveMemento();

        burgerIngredients.Cucumber = true;
        // Запазва състояние
        ingMem.Memento = burgerIngredients.SaveMemento();

        burgerIngredients.Cedar = true;
        // Връща състояние
        burgerIngredients.RestoreMemento(ingMem.Memento);

        burgerIngredients.Cedar = false;
        // Запазва състояние
        ingMem.Memento = burgerIngredients.SaveMemento();

        burgerIngredients.Lettuce = true;
        // Запазва състояние
        ingMem.Memento = burgerIngredients.SaveMemento();

        Console.ReadKey();
    }
}
